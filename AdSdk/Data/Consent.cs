using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Consent
    {
        [DataMember(Name = "id")] public string _id;
    }
}