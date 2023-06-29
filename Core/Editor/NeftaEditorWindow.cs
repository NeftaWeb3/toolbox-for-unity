using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Nefta.Core.Editor
{
    public class NeftaEditorWindow : EditorWindow
    {
        private const string SdkDevelopmentSymbol = "NEFTA_SDK_DBG";
        private const string SdkReleaseSymbol = "NEFTA_SDK_REL";

        private static NeftaEditorWindow _instance;
        private static List<INeftaEditorModule> _editorModules;
        
        private bool _groupEnabled;
        private Dictionary<string, Action> _pages;
        private string _selectedPage;
        private Color _originalBackgroundColor;
        private Texture2D _logo;
        private bool _isDevelopmentMode;

        public static NeftaEditorWindow Instance;

        [InitializeOnLoadMethod]
        private static void Init()
        {
            var defines = GetDefines();
            var isDevelopment = defines.Contains(SdkDevelopmentSymbol);
            var isRelease = defines.Contains(SdkReleaseSymbol);
            if (!isDevelopment && !isRelease)
            {
                SetSymbolEnabled(SdkDevelopmentSymbol, true);
            }
        }

        public static void RegisterModule(INeftaEditorModule module)
        {
            _editorModules ??= new List<INeftaEditorModule>();
            if (!_editorModules.Contains(module))
            {
                _editorModules.Add(module);
            }
        }
        
        [MenuItem("Window/Nefta SDK")]
        private static void OpenNeftaSDKWindow()
        {
            OpenNeftaSDKWindow(null);
        }

        public static void OpenNeftaSDKWindow(string page)
        {
            _instance = (NeftaEditorWindow)GetWindow(typeof(NeftaEditorWindow), true, "Nefta SDK");
            _instance.minSize = new Vector2(580f, 220f);
            _instance._selectedPage = page ?? "Welcome";
            _instance.Show();
        }

        private void Initialize()
        {
            Instance = this;
            
            var logoPath = AssetDatabase.GUIDToAssetPath("972cbec602f9a44089f7ec035d5564e4");
            _logo = AssetDatabase.LoadAssetAtPath<Texture2D>(logoPath);

            Instance._isDevelopmentMode = GetDefines().Contains(SdkDevelopmentSymbol);

            _pages = new Dictionary<string, Action>
            {
                { "Welcome", OnWelcomePage },
                { "Utility", OnUtilityPage }
            };

            if (_editorModules != null)
            {
                foreach (var module in _editorModules)
                {
                    module.AddPages(_pages);
                }
            }
        }

        private void OnGUI()
        {
            if (_pages == null)
            {
                Initialize(); 
            }
            
            const float padding = 4;
            var windowRect = position;
            var menuRect = new Rect(padding, 110, 200, windowRect.height - padding);
            var pageRect = new Rect(padding + menuRect.width + padding, 110, windowRect.width - menuRect.width - padding * 3, windowRect.height - padding);

            _originalBackgroundColor = GUI.backgroundColor;
            
            GUI.DrawTexture(new Rect(windowRect.width * 0.5f - 128, 0, 256, 100), _logo);
            
            GUILayout.BeginArea(menuRect);
            foreach (var page in _pages)
            {
                OnMenuButton(page.Key);
            }
            GUILayout.EndArea();

            GUILayout.BeginArea(pageRect);
            _pages[_selectedPage]();
            GUILayout.EndArea();
        }

        private void OnWelcomePage()
        {
            GUILayout.Label("Welcome to Nefta Web3 SDK.");
            
            if (GUILayout.Button("Getting started"))
            {
                Application.OpenURL("https://docs.nefta.io/docs/neftaunity-sdk");    
            }
            if (GUILayout.Button("Documentation"))
            {
                Application.OpenURL("https://neftaweb3.github.io/toolbox-for-unity/api/Nefta.ToolboxSdk.Toolbox.html");
            }
        }

        private void OnUtilityPage()
        {
            var isDevelopment = GUILayout.Toggle(_isDevelopmentMode, "Enable logging for the current platform");
            if (isDevelopment != _isDevelopmentMode)
            {
                _isDevelopmentMode = isDevelopment;
                SetSymbolEnabled(SdkDevelopmentSymbol, isDevelopment);
                SetSymbolEnabled(SdkReleaseSymbol, !isDevelopment);
            }
            
            GUILayout.Space(20);
            
            if (GUILayout.Button("Clear cached player In PlayerPrefs"))
            {
                NeftaCore.ClearPrefs();
                
                Debug.Log("Cached player data cleared");
            }
        }

        private void OnMenuButton(string page)
        {
            if (_selectedPage == page)
            {
                GUI.backgroundColor = Color.green;
            }
            if (GUILayout.Button(page))
            {
                _selectedPage = page;
            }
            GUI.backgroundColor = _originalBackgroundColor;
        }

        private static BuildTargetGroup GetNamedBuildTarget()
        {
            var target = EditorUserBuildSettings.activeBuildTarget;
            return BuildPipeline.GetBuildTargetGroup(target);
        }
        
        public static string GetDefines()
        {
            return PlayerSettings.GetScriptingDefineSymbolsForGroup(GetNamedBuildTarget());
        }

        public static void SetSymbolEnabled(string symbol, bool enabled)
        {
            var defines = GetDefines();
            if (enabled)
            {
                defines += $";{symbol}";
            }
            else
            {
                var symbolIndex = defines.IndexOf(symbol, StringComparison.InvariantCulture);
                if (symbolIndex == 0)
                {
                    defines = defines.Replace(symbol, "");
                }
                else if (symbolIndex > 0)
                {
                    defines = defines.Replace($";{symbol}", "");
                }
            }
            PlayerSettings.SetScriptingDefineSymbolsForGroup(GetNamedBuildTarget(), defines);
        }
    }   
}
