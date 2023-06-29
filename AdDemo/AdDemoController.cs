using System.Collections.Generic;
using Nefta.AdSdk;
using UnityEngine;

namespace Nefta.AdDemo
{
    public class AdDemoController : MonoBehaviour
    {
        [SerializeField] private RectTransform _contentRect;
        [SerializeField] private RectTransform _placementRect;

        [SerializeField] private PlacementController _placementPrefab;

        private AdManager _adManager;
        private bool _isBannerShown;
        private Dictionary<string, PlacementController> _placementControllers;
        
        private void Awake()
        {
            _adManager = AdManager.Init("3");
            _adManager.UserId = "user1";

            _adManager.OnReady += OnReady;
            _adManager.OnLoad += OnLoad;
            _adManager.OnLoadFail += OnLoadFail;
            _adManager.OnShow += OnShow;
            _adManager.OnClose += OnClose;
            _adManager.OnUserRewarded += OnUserRewarded;

            AdjustOffsets(0);
        }

        private void Update()
        {
            if (_adManager != null)
            {
                _adManager.OnUpdate();
            }
        }

        private void OnReady()
        {
            _placementControllers = new Dictionary<string, PlacementController>();
            foreach (var adPlacement in AdManager.Instance.Placements)
            {
                var placementController = Instantiate(_placementPrefab, _placementRect);
                placementController.SetData(adPlacement.Value);
                
                _placementControllers.Add(adPlacement.Key, placementController);
            }
        }

        private void OnLoad(AdPlacement placement)
        {
            _placementControllers[placement._id].OnLoad();
        }

        private void OnLoadFail(AdPlacement placement, AdPlacement.LoadFailReason failReason)
        {
            _placementControllers[placement._id].OnLoadFail(failReason);
        }

        private void OnShow(AdPlacement placement)
        {
            _placementControllers[placement._id].OnShow();
            if (placement._type == ImpressionType.Banner)
            {
                AdjustOffsets(placement._screenHeight);
            }
        }

        private void OnClose(AdPlacement placement)
        {
            _placementControllers[placement._id].OnClose();
            if (placement._type == ImpressionType.Banner)
            {
                AdjustOffsets(0);
            }
        }

        private void OnUserRewarded(AdPlacement placement)
        {
            Debug.Log($"OnUserRewarded for placement {placement._id}");
        }
        
        private void AdjustOffsets(int bannerHeight)
        {
            var topObstruction = Screen.height - Screen.safeArea.height - Screen.safeArea.y;
            _contentRect.offsetMax = new Vector2(0, -(topObstruction + bannerHeight) / Screen.height) * ((RectTransform)transform).rect.size.y;
        }
    }
}
