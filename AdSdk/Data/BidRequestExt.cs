using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class BidRequestExt
    {
        [DataMember(Name = "nefta")] public BidRequestExtNefta _nefta;
    }
}