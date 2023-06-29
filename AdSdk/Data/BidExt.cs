using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class BidExt
    {
        [DataMember(Name = "nefta")] public BidExtNefta _nefta;
    }
}