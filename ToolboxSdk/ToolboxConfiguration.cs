using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nefta.ToolboxSdk
{
    public class ToolboxConfiguration : ScriptableObject
    {
        [Serializable]
        public class OAuthProvider
        {
            public enum Providers
            {
                Facebook,
                Google,
                Apple,
                Twitch,
                Discord
            }

            public Providers _id;
            public string _clientId;
            public string _secret;
        }
        
        public const string FileName = "ToolboxConfiguration";
        
        public string _marketplaceId;
        public Toolbox.PreloadStrategies _preloadStrategy;
        public List<OAuthProvider> _oAuthProviders;
    }
}