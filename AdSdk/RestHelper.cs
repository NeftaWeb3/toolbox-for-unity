using System.Collections.Generic;
using Nefta.AdSdk.Resolvers;
using Nefta.Core;
using UnityEngine.Networking;
using Utf8Json;
using Utf8Json.Resolvers;

namespace Nefta.AdSdk
{
    public class RestHelper : IJsonFormatterResolver
    {
        private readonly List<IJsonFormatterResolver> _resolvers;

        public RestHelper()
        {
            _resolvers = new List<IJsonFormatterResolver>
            {
                EnumResolver.UnderlyingValue,
                StandardResolver.Default,
                DynamicGenericResolver.Instance,
                AdResolvers.Instance
            };
        }

        public UnityWebRequest CreatePostRequest(string url, byte[] body)
        {
            var uploadHandler = new UploadHandlerRaw(body) { contentType = "application/json" };
            var request = new UnityWebRequest(url, UnityWebRequest.kHttpVerbPOST, new DownloadHandlerBuffer(), uploadHandler);
            NeftaCore.Info($"CreatePostRequest {url} body:{System.Text.Encoding.UTF8.GetString(body)}");
            return request;
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