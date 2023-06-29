using System;
using System.IO;
using Nefta.Core;
using Nefta.ToolboxSdk.Authorization;
using Nefta.ToolboxSdk.GamerAssets;
using Nefta.ToolboxSdk.GamerManagement;
using Nefta.ToolboxSdk.Marketplace;
using Nefta.ToolboxSdk.Nft;
using UnityEngine;

namespace Nefta.ToolboxSdk
{
    public class Toolbox : INeftaModule
    {
        internal const string Version = "2.0.4";
        
        public enum PreloadStrategies
        {
            None,
            OnlyFromCache,
            Full
        }

        private NeftaCore _neftaCore;

        public static Toolbox Instance;

        public ToolboxConfiguration Configuration;
        public RestHelper RestHelper;
        public AuthorizationHelper Authorization;
        public GamerManagementHelper GamerManagement;
        public GamerAssetsHelper GamerAssets;
        public MarketplaceHelper Marketplace;

        public static void Init()
        {
            var neftaCore = NeftaCore.Init();
            
            Instance = new Toolbox();
            Instance.Configuration = Resources.Load<ToolboxConfiguration>("ToolboxConfiguration");
            Instance.RestHelper = new RestHelper();
            Instance.Authorization = new AuthorizationHelper(Instance);
            Instance.GamerManagement = new GamerManagementHelper();
            Instance.GamerAssets = new GamerAssetsHelper();
            Instance.Marketplace = new MarketplaceHelper();
            
            Instance._neftaCore = neftaCore;
        }

        public NeftaUser User
        {
            get => _neftaCore.NeftaUser;
            set => _neftaCore.NeftaUser = value;
        }
        
        private static string GetAssetDirectory()
        {
            return $"{Application.persistentDataPath}/NEFTAToolboxSDK/NFTAssets";
        }

        public static void ClearCache()
        {
            var path = GetAssetDirectory();
            if (!Directory.Exists(path))
            {
                return;
            }
            Directory.Delete(path, true);
        }
        
        private string GetAssetPath(NftAsset asset)
        {
            var nameHash = new Hash128();
            nameHash.Append(asset._imageUrl);
            return $"{GetAssetDirectory()}/{nameHash.ToString()}";
        }

        public Texture2D LoadCachedAsset(NftAsset asset)
        {
            Texture2D texture = null;
            var path = GetAssetPath(asset);
            try
            {
                if (!File.Exists(path))
                {
                    return null;
                }

                var textureBytes = File.ReadAllBytes(path);
                texture = new Texture2D(2, 2);
                texture.LoadImage(textureBytes);
            }
            catch (Exception e)
            {
                NeftaCore.Warn($"Error loading texture {asset._name} from {path}: {e.Message}");
            }

            return texture;
        }
        
        public void CacheAsset(NftAsset asset, Texture2D texture)
        {
            var path = GetAssetPath(asset);
            try
            {
                var directory = GetAssetDirectory();
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var textureBytes = texture.EncodeToPNG();
                File.WriteAllBytes(path, textureBytes);
                NeftaCore.Info($"Saved {asset._name} to {path}");
            }
            catch (Exception e)
            {
                NeftaCore.Warn($"Error saving {asset._name} to {path}: {e.Message}");
            }
        }
    }
}