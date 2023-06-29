using Nefta.AdSdk;
using UnityEngine;
using UnityEngine.UI;

namespace Nefta.AdDemo
{
    public class PlacementController : MonoBehaviour
    {
        [SerializeField] private Text _placementIdText;
        [SerializeField] private Text _placementTypeText;
        [SerializeField] private Button _loadButton;
        [SerializeField] private Button _showButton;
        [SerializeField] private Button _closeButton;

        private string _placementId;
        private bool _isBanner;

        public void SetData(AdPlacement placement)
        {
            _placementId = placement._id;
            _isBanner = placement._type == ImpressionType.Banner;
            
            _placementIdText.text = placement._id;
            _placementTypeText.text = placement._type.ToString();

            _loadButton.onClick.AddListener(OnLoadClick);
            _showButton.onClick.AddListener(OnShowClick);
            _closeButton.onClick.AddListener(OnCloseClick);
            
            _showButton.interactable = false;
            _closeButton.gameObject.SetActive(false);
        }

        private void OnLoadClick()
        {
            AdManager.Instance.LoadAd(_placementId);
            
            _loadButton.interactable = false;
        }

        public void OnLoad()
        {
            _showButton.interactable = true;
        }

        public void OnLoadFail(AdPlacement.LoadFailReason state)
        {
            _loadButton.interactable = true;
        }

        public void OnShow()
        {
            if (_isBanner)
            {
                _showButton.gameObject.SetActive(false);
                _closeButton.gameObject.SetActive(true);
            }
            
            _showButton.interactable = false;
        }

        public void OnClose()
        {
            if (_isBanner)
            {
                _showButton.gameObject.SetActive(true);
                _closeButton.gameObject.SetActive(false);
            }
            
            _loadButton.interactable = true;
        }
        
        private void OnShowClick()
        {
            AdManager.Instance.ShowAd(_placementId);
            
            _showButton.interactable = false;
        }

        private void OnCloseClick()
        {
            AdManager.Instance.CloseAd();
        }
    }
}