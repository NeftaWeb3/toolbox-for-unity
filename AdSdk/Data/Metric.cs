using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Metric
    {
        [DataMember(Name = "type")] public string _type;
        [DataMember(Name = "value")] public float _value;
        [DataMember(Name = "vendor")] public float _vendor;
        [DataMember(Name = "ext")] public string _ext;
    }
}