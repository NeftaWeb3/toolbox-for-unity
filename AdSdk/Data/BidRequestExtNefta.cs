using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class BidRequestExtNefta
    {
        [DataMember(Name = "nuid")] public string _neftaUserId;
        [DataMember(Name = "puid")] public string _publisherId;
        [DataMember(Name = "app_id")] public string _appId;
        [DataMember(Name = "test")] public bool _test;
        [DataMember(Name = "sdk_version")] public string _sdkVersion;
    }
} 