using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class SeatBid
    {
        [DataMember(Name = "bid")] public List<Bid> _bids;
        [DataMember(Name = "seat")] public string _seatId;
        [DataMember(Name = "group")] public int _isGroupedImpression;
        [DataMember(Name = "ext")] public Ext _ext;
    }
}