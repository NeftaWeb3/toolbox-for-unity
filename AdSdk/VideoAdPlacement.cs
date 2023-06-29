using System;
using System.Collections.Generic;
using System.IO;
using Nefta.AdSdk.Data.Vast;
using Nefta.Core;
using UnityEngine;
using UnityEngine.Networking;

namespace Nefta.AdSdk
{
    public class VideoAdPlacement : AdPlacement
    {
        public struct ProgressCallback
        {
            public readonly float _time;
            public readonly string _url;

            public ProgressCallback(float time, string url)
            {
                _time = time;
                _url = url;
            }
        }
        
        private UnityWebRequest _webRequest;
        private Action<AdPlacement> _onLoad;
        
        public Vast _vast;
        public LinearCreative _creative;
        public bool _isRewardSent;
        public List<ProgressCallback> _callbacks;
        
        public string VideoPath { get; private set; }

        public VideoAdPlacement(string id, float floorPriceInUsd) : base(ImpressionType.VideoAd, id, floorPriceInUsd, 0, 0, Position.Center)
        {
            _vast = new Vast();
            _callbacks = new List<ProgressCallback>();
        }

        public override void OnClose()
        {
            base.OnClose();
            
            try
            {
                File.Delete(VideoPath);
            }
            catch (Exception e)
            {
                NeftaCore.Warn($"Error deleting creative {_creative._id} ({VideoPath}): {e.Message}");
            }
            VideoPath = null;

            _creative = null;
            _callbacks.Clear();
        }

        public void StartLoading(Action<AdPlacement> onLoad)
        {
            _onLoad = onLoad;
            
            var url = _creative._mediaFiles[0]._url;

            _webRequest = UnityWebRequest.Get(url);
            _webRequest.SendWebRequest().completed += OnVideoLoad;
        }

        private void OnVideoLoad(AsyncOperation operation)
        {
            if (_webRequest.result != UnityWebRequest.Result.Success)
            {
                NeftaCore.Warn("Video preloading failed: " + _webRequest.error);
            }

            try
            {
                var directory = GetAssetDirectory();
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                
                var hash = new Hash128();
                hash.Append(_webRequest.url);
                VideoPath = $"{directory}/{hash.ToString()}{Path.GetExtension(_webRequest.url)}";
                
                File.WriteAllBytes(VideoPath, _webRequest.downloadHandler.data);
                NeftaCore.Info($"Saved creative {_creative._id} to {VideoPath}");
            }
            catch (Exception e)
            {
                NeftaCore.Warn($"Error saving creative {_creative._id} to {VideoPath}: {e.Message}");
            }

            _isCreativeLoaded = true;
            _webRequest.Dispose();
            _webRequest = null;

            _onLoad(this);
        }

        public static string GetAssetDirectory()
        {
            return $"{Application.persistentDataPath}/NEFTAAdSDK";
        }
    }
}