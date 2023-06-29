using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class InitRequest
    {
        [DataMember(Name = "app_id")] public string _appId;
        [DataMember(Name = "nuid")] public string _nuid;
    }
}