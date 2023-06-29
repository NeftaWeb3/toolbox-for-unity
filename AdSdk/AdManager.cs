using System;
using System.Collections.Generic;
using System.Text;
using Nefta.AdSdk.Data;
using Nefta.Core;
using UnityEngine;
using UnityEngine.Networking;

namespace Nefta.AdSdk
{
    public class AdManager
    {
        private const float InitRetryCooldown = 5f;
        
        private Bidder _bidder;
        private AdRenderer _adRenderer;
        private UnityWebRequest _webRequest;
        private float _timeSinceLastInitRetry;
        
        internal string PublisherId;
        internal RestHelper RestHelper;

        public Dictionary<string, AdPlacement> Placements;

        public static AdManager Instance;

        public Action OnReady;
        public Action<AdPlacement> OnLoad;
        public Action<AdPlacement, AdPlacement.LoadFailReason> OnLoadFail;
        public Action<AdPlacement> OnShow;
        public Action<AdPlacement> OnClose;
        public Action<AdPlacement> OnUserRewarded;

        public bool IsReady => Placements != null;

        /// <summary>
        /// Set custom userId for s2s tracking
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Initialization method which should be called before any other interaction with the ad SDK
        /// </summary>
        public static AdManager Init(string publisherId)
        {
            NeftaCore.Init();
            
            Instance = new AdManager();
            Instance.PublisherId = publisherId;
            Instance.RestHelper = new RestHelper();
            Instance.InitConfiguration();

            Instance._bidder = new Bidder();
            Instance._bidder.Init(Instance);
            var renderer = Resources.Load<AdRenderer>("_NeftaAdRenderer");
            Instance._adRenderer = UnityEngine.Object.Instantiate(renderer);
            Instance._adRenderer.Init(Instance);

            return Instance;
        }

        /// <summary>
        /// By calling this method you have full control over execution order
        /// This method should be called to ensure correct ad rending behaviour
        /// </summary>
        public void OnUpdate()
        {
            if (IsReady)
            {
                _adRenderer.OnUpdate();
            }
            else if (_webRequest == null)
            {
                _timeSinceLastInitRetry += Time.unscaledDeltaTime;
                if (_timeSinceLastInitRetry >= InitRetryCooldown)
                {
                    InitConfiguration();
                }
            }
        }

        /// <summary>
        /// Start bidding for specific ad placement
        /// </summary>
        /// <param name="placementId"></param>
        public void LoadAd(string placementId)
        {
            if (Placements.TryGetValue(placementId, out var placement))
            {
                _bidder.LoadAd(placement);
            }
        }

        /// <summary>
        /// Checks if ad offer is loaded and ready to show for tge specific placement after calling LoadAd
        /// </summary>
        /// <param name="placementId">The ad placement id</param>
        /// <returns>True if offer is available and ready to show</returns>
        public bool IsAdAvailable(string placementId)
        {
            if (Placements.TryGetValue(placementId, out var placement))
            {
                return placement._isCreativeLoaded;
            }

            return false;
        }

        /// <summary>
        /// Returns the price publisher will pay to show the available ad
        /// </summary>
        /// <param name="placementId">The ad placement id</param>
        /// <returns>Price of showing available ad in USD</returns>
        public float GetAvailableAdPrice(string placementId)
        {
            if (Placements.TryGetValue(placementId, out var adPlacement))
            {
                if (adPlacement._bid != null)
                {
                    return adPlacement._bid._price;
                }
            }

            return -1;
        }

        /// <summary>
        /// Start showing specific ad placement
        /// </summary>
        /// <param name="placementId"></param>
        public void ShowAd(string placementId)
        {
            if (Placements.TryGetValue(placementId, out var adPlacement))
            {
                if (adPlacement._isCreativeLoaded)
                {
                    UnityWebRequest.Get(adPlacement._bid._winNoticeUrl).SendWebRequest();
                    _adRenderer.ShowAd(adPlacement);
                }
            }
        }

        /// <summary>
        /// Force closing of ad at specific placement
        /// </summary>
        public void CloseAd()
        {
            _adRenderer.CloseAd();
        }

        internal void OnPlacementBidLoad(AdPlacement adPlacement, Bid bid)
        {
            adPlacement._bid = bid;
  
            _adRenderer.LoadAd(adPlacement);
        }

        internal void OnPlacementCreativeLoad(AdPlacement adPlacement)
        {
            adPlacement._isCreativeLoaded = true;
            
            OnLoad?.Invoke(adPlacement);
        }

        internal void OnPlacementLoadFail(AdPlacement adPlacement, AdPlacement.LoadFailReason failReason)
        {
            OnLoadFail?.Invoke(adPlacement, failReason);
        }

        private void InitConfiguration()
        {
            var nuid = NeftaCore.Instance.NeftaUser?._userId;
            var initRequest = new InitRequest() { _appId = PublisherId, _nuid = nuid };
            var body = RestHelper.Serialize(initRequest);
            _webRequest = RestHelper.CreatePostRequest(NeftaCore.BaseUrl + "/ad/sdk/init", body);
            _webRequest.SendWebRequest().completed += OnInitResponse;
            _timeSinceLastInitRetry = 0;
        }

        private void OnInitResponse(AsyncOperation operation)
        {
            var responseCode = _webRequest.responseCode;
            var data = _webRequest.downloadHandler.data;
            NeftaCore.Info($"Response statusCode: {responseCode} body:{Encoding.UTF8.GetString(data)}");
            
            try
            {
                var initResponse = RestHelper.Deserialize<InitResponse>(data);
                if (NeftaCore.Instance.NeftaUser == null || NeftaCore.Instance.NeftaUser._userId != initResponse._nuid)
                {
                    NeftaCore.Instance.NeftaUser ??= new NeftaUser();
                    NeftaCore.Instance.NeftaUser._userId = initResponse._nuid;
                }

                var placements = new Dictionary<string, AdPlacement>();
                foreach (var adUnit in initResponse._adUnits)
                {
                    AdPlacement adPlacement;
                    switch (adUnit._type)
                    {
                        case "rewarded_video":
                            adPlacement = new VideoAdPlacement(adUnit._id, 0f);
                        break;
                        case "banner":
                            adPlacement =
                                new AdPlacement(
                                    ImpressionType.Banner,
                                    adUnit._id,
                                    0f,
                                    adUnit._width,
                                    adUnit._height,
                                    AdPlacement.Position.Top);
                        break;
                        case "interstitial":
                            adPlacement =
                                new AdPlacement(
                                    ImpressionType.Interstitial,
                                    adUnit._id,
                                    0f,
                                    adUnit._width,
                                    adUnit._height,
                                    AdPlacement.Position.Center);
                            break;
                        default:
                            continue;
                    }
                    placements.Add(adUnit._id, adPlacement);
                }

                Placements = placements;
            }
            catch (Exception e)
            {
                NeftaCore.Warn($"Error retrieving init configuration: {e.Message}");
            }

            _webRequest.Dispose();
            _webRequest = null;
            
            OnReady?.Invoke();
        }

        internal void OnAdShow(AdPlacement adPlacement)
        {
            OnShow?.Invoke(adPlacement);
        }

        internal void OnAdReward(AdPlacement adPlacement)
        {
            OnUserRewarded?.Invoke(adPlacement);
        }

        internal void OnAdClose(AdPlacement adPlacement)
        {
            adPlacement.OnClose();
            OnClose?.Invoke(adPlacement);
        }
    }
}