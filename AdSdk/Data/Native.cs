using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Native
    {
        [DataMember(Name = "request")] public string _requestPayload;
        [DataMember(Name = "ver")] public string _adApiVersion;
        [DataMember(Name = "api")] public int[] _supportedApis;
        [DataMember(Name = "battr")] public int[] _blockedCreativeAttributes;
        [DataMember(Name = "ext")] public string _ext;
    }
}