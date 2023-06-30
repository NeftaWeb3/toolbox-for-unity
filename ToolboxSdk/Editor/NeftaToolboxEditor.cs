using System;
using System.Collections.Generic;
using System.IO;
using Nefta.Core.Editor;
using UnityEditor;
using UnityEngine;

namespace Nefta.ToolboxSdk.Editor
{
    public class NeftaToolboxEditor : INeftaEditorModule
    {
        private const string MetaMaskIntegrationSymbol = "NEFTA_INTEGRATION_METAMASK";
        
        private ToolboxConfiguration _configuration;

        private bool _showMarketPlaceIdHint;
        private bool _isMetaMaskIntegration;
        private GUIStyle _multiLineLabelStyle;
        
        [InitializeOnLoadMethod]
        private static void Init()
        {
            var instance = new NeftaToolboxEditor();
            NeftaEditorWindow.RegisterModule(instance);
            
            instance._configuration = Resources.Load<ToolboxConfiguration>(ToolboxConfiguration.FileName);
            if (instance._configuration == null)
            {
                instance._configuration = ScriptableObject.CreateInstance<ToolboxConfiguration>();
                instance._configuration._preloadStrategy = Toolbox.PreloadStrategies.Full;

                var directory = "Assets/Resources";
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                AssetDatabase.CreateAsset(instance._configuration, $"{directory}/{ToolboxConfiguration.FileName}.asset");
                AssetDatabase.SaveAssets();
            }
            
            if (string.IsNullOrEmpty(instance._configuration._marketplaceId))
            {
                EditorApplication.delayCall += () =>
                {
                    NeftaEditorWindow.OpenNeftaSDKWindow("Toolbox");
                    instance._showMarketPlaceIdHint = true;
                };
            }
        }

        public void AddPages(Dictionary<string, Action> pages)
        {
            pages.Add("Toolbox", OnToolboxPage);
            
            _multiLineLabelStyle = EditorStyles.label;
            _multiLineLabelStyle.wordWrap = true;
            
            _isMetaMaskIntegration = NeftaEditorWindow.GetDefines().Contains(MetaMaskIntegrationSymbol);
        }
        
        private void OnToolboxPage()
        {
            if (_showMarketPlaceIdHint)
            {
                GUILayout.Label("To get started, configure your marketplaceId (starting with \"m-\") when initializing the Toolbox:",
                    _multiLineLabelStyle);
            }
            
            EditorGUILayout.BeginHorizontal();
            _configuration._marketplaceId = EditorGUILayout.TextField("Marketplace ID", _configuration._marketplaceId);
            if (GUILayout.Button("Apply"))
            {
                UpdateConfigurationOnDisk();

            }
            EditorGUILayout.EndHorizontal();
            
            GUILayout.Space(20);
            
            var isMetaMaskIntegration = GUILayout.Toggle(_isMetaMaskIntegration, "Enable MetaMask integration");
            if (isMetaMaskIntegration != _isMetaMaskIntegration)
            {
                _isMetaMaskIntegration = isMetaMaskIntegration;
                NeftaEditorWindow.SetSymbolEnabled(MetaMaskIntegrationSymbol, _isMetaMaskIntegration);
            }
            
            GUILayout.Space(20);
            
            var preloadStrategy = (Toolbox.PreloadStrategies) EditorGUILayout.EnumPopup("Preload strategy", _configuration._preloadStrategy);
            if (preloadStrategy != _configuration._preloadStrategy)
            {
                _configuration._preloadStrategy = preloadStrategy;
                
                UpdateConfigurationOnDisk();
            }
            
            GUILayout.Space(20);
            
            if (GUILayout.Button("Clear Asset cache"))
            {
                Toolbox.ClearCache();
                
                Debug.Log("Asset cache cleared");
            }
        }

        private void UpdateConfigurationOnDisk()
        {
            EditorUtility.SetDirty(_configuration);
            AssetDatabase.SaveAssetIfDirty(_configuration);
        }
    }   
}
