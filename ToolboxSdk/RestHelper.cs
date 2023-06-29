using System;
using System.Collections.Generic;
using UnityEngine;
using Nefta.Core;
using Nefta.Core.Resolvers;
using Nefta.ToolboxSdk.Resolvers;
using UnityEngine.Networking;
using Utf8Json;
using Utf8Json.Resolvers;

namespace Nefta.ToolboxSdk
{
    public class RestHelper : IJsonFormatterResolver
    {
        private readonly List<IJsonFormatterResolver> _resolvers;
        private readonly string _userAgent;
        
        public RestHelper()
        {
            _resolvers = new List<IJsonFormatterResolver>
            {
                EnumResolver.UnderlyingValue,
                StandardResolver.Default,
                CoreResolvers.Instance,
                ToolboxResolvers.Instance
            };
            
            _userAgent = $"{Application.identifier}/{Application.version} {SystemInfo.deviceModel}";
        }
        
        public void SendGetRequest(string endPoint, Action<RestResponse> callback)
        {
            var url = NeftaCore.BaseUrl + endPoint;
            var request = UnityWebRequest.Get(url);
            SetHeaders(request);
            NeftaCore.Info($"SendGetRequest request {endPoint}");
            SendRequest(request, callback);
        }
        
        public void SendPostRequest(string endPoint, byte[] body, Action<RestResponse> callback)
        {
            var url = NeftaCore.BaseUrl + endPoint;
            var uploadHandler = new UploadHandlerRaw(body) { contentType = "application/json" };
            var request = new UnityWebRequest(url, UnityWebRequest.kHttpVerbPOST, new DownloadHandlerBuffer(), uploadHandler);
            SetHeaders(request);
            NeftaCore.Info($"SendPostRequest request {url} body:{System.Text.Encoding.UTF8.GetString(body)}");
            SendRequest(request, callback);
        }

        private void SendRequest(UnityWebRequest request, Action<RestResponse> callback)
        {
            request.SendWebRequest().completed += operation =>
            {
                var response = new RestResponse
                {
                    IsSuccess = request.result == UnityWebRequest.Result.Success,
                    StatusCode = request.responseCode,
                    Body = request.downloadHandler.data
                };
                request.Dispose();

                NeftaCore.Info($"Response statusCode: {response.StatusCode} body:{System.Text.Encoding.UTF8.GetString(response.Body)}");
                callback?.Invoke(response);
            };
        }

        private void SetHeaders(UnityWebRequest request)
        {
            request.SetRequestHeader("User-Agent", _userAgent);
            if (NeftaCore.Instance.NeftaUser != null && !string.IsNullOrEmpty(NeftaCore.Instance.NeftaUser._token))
            {
                request.SetRequestHeader("Authorization", "Bearer " + NeftaCore.Instance.NeftaUser._token);
            }
        }

        public byte[] Serialize<T>(T body)
        {
            return JsonSerializer.Serialize(body, this);
        }
        
        public T Deserialize<T>(byte[] json)
        {
            var reader = new JsonReader(json);
            return JsonSerializer.Deserialize<T>(ref reader, this);
        }

        public IJsonFormatter<T> GetFormatter<T>()
        {
            foreach (var item in _resolvers)
            {
                var f = item.GetFormatter<T>();
                if (f != null)
                {
                    return f;
                }
            }
            return null;
        }
        
    }
}