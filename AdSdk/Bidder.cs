using System;
using System.Security.Cryptography;
using System.Text;
using Nefta.AdSdk.Data;
using Nefta.Core;
using UnityEngine;
using UnityEngine.Networking;

namespace Nefta.AdSdk
{
    internal class Bidder
    {
        private AdManager _adManager;
        private int _bidCount;
        private string _deviceIdSha1;
        private string _deviceIdMda5;

        public void Init(AdManager adManager)
        {
            _adManager = adManager;

            var hashBuilder = new StringBuilder();
            var deviceId = Encoding.UTF8.GetBytes(SystemInfo.deviceUniqueIdentifier);
            var hashBytes = new SHA1Managed().ComputeHash(deviceId);
            foreach (var hashByte in hashBytes)
            {
                hashBuilder.Append(hashByte.ToString("x2"));
            }

            _deviceIdSha1 = hashBuilder.ToString();
            hashBuilder.Clear();

            hashBytes = MD5.Create().ComputeHash(deviceId);
            foreach (var hashByte in hashBytes)
            {
                hashBuilder.Append(hashByte.ToString("x2"));
            }
            _deviceIdMda5 = hashBuilder.ToString();
        }

        public void LoadAd(AdPlacement adPlacement)
        {
            Impression impression = new Impression
            {
                _tagId = adPlacement._id,
                _bidFloor = adPlacement._floorPriceInUsd
            };
            
            switch (adPlacement._type)
            {
                case ImpressionType.Banner:
                    impression._id = "banner";
                    impression._banner = new Banner
                    {
                        _width = adPlacement._configWidth,
                        _height = adPlacement._configHeight
                    };
                    break;
                case ImpressionType.Interstitial:
                    impression._id = "interstitial";
                    impression._banner = new Banner
                    {
                        _width = adPlacement._configWidth,
                        _height = adPlacement._configHeight
                    };
                    impression._isInterstitialOrFullScreen = 1;
                    break;
                case ImpressionType.VideoAd:
                    impression._id = "video";
                    impression._video = new Video
                    {
                        _width = (int)Screen.safeArea.width,
                        _height = (int)Screen.safeArea.height
                    };
                    impression._isInterstitialOrFullScreen = 1;
                    break;
            }
            
            RequestBid(adPlacement, impression);
        }

        private void RequestBid(AdPlacement adPlacement, Impression impression)
        {
            var bidRequest = new BidRequest
            {
                _id = $"auction_{_bidCount}",
                _auctionType = 1,
                _allowedCurrencies = new[] { "USD" },
                _impressions = new[] { impression },
                _application = new Data.Application
                {
                    _id = UnityEngine.Application.buildGUID,
                    _name = UnityEngine.Application.productName,
                    _bundle = UnityEngine.Application.identifier,
                    _version = UnityEngine.Application.version
                },
                _device = new Device
                {
                    _model = SystemInfo.deviceModel,
                    
                    _operatingSystem = SystemInfo.operatingSystem,
                    
                    _hardwareVersion = SystemInfo.graphicsDeviceVersion,
                    _screenHeight = Screen.height,
                    _screenWidth = Screen.width,
                    _dotsPerInch = (int) Screen.dpi,

                    _deviceIdSha1 = _deviceIdSha1,
                    _deviceIdMd5 = _deviceIdMda5,
                },
                _user = new User
                {
                    id = _adManager.UserId
                },
                _ext = new BidRequestExt
                {
                    _nefta = new BidRequestExtNefta
                    {
                        _neftaUserId = NeftaCore.Instance.NeftaUser?._userId,
                        _appId = _adManager.PublisherId,
                        _publisherId = _adManager.PublisherId,
                        _sdkVersion = UnityEngine.Application.version
                    }
                }
            };
            var body = _adManager.RestHelper.Serialize(bidRequest);
            var webRequest =_adManager.RestHelper.CreatePostRequest("https://rtb.nefta.app/bidder/bid", body);
            webRequest.SendWebRequest().completed += operation =>
            {
                OnBidResponse(webRequest, adPlacement);
            };
            _bidCount++;
        }

        private void OnBidResponse(UnityWebRequest request, AdPlacement adPlacement)
        {
            var responseCode = request.responseCode;
            var data = request.downloadHandler.data;
            NeftaCore.Info($"Response statusCode: {responseCode} body:{Encoding.UTF8.GetString(data)}");

            try
            {
                var bidResponse = _adManager.RestHelper.Deserialize<BidResponse>(data);
                if (bidResponse._seatBids.Count > 0 && bidResponse._seatBids[0]._bids.Count > 0)
                {
                    var bid = bidResponse._seatBids[0]._bids[0];
                    if (bid._width == 0 || bid._height == 0)
                    {
                        bid._width = adPlacement._configWidth;
                        bid._height = adPlacement._configHeight;
                    }
                
                    NeftaCore.Info($"Got bid \"{bid._id}\" for placement {adPlacement._type}({adPlacement._id})");
                    _adManager.OnPlacementBidLoad(adPlacement, bid);
                }
                else
                {
                    NeftaCore.Info($"No bids for placement {adPlacement._type}({adPlacement._id})");
                    _adManager.OnPlacementLoadFail(adPlacement, AdPlacement.LoadFailReason.NoBids);
                }
            }
            catch (Exception e)
            {
                NeftaCore.Warn($"Error retrieving bid: {e.Message}");
                _adManager.OnPlacementLoadFail(adPlacement, AdPlacement.LoadFailReason.BidError);
            }
            
            request.Dispose();
        }
    }
}
