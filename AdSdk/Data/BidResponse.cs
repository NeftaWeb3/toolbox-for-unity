using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class BidResponse
    {
        [DataMember(Name = "id")] public string _id;
        [DataMember(Name = "seatbid")] public List<SeatBid> _seatBids;
        [DataMember(Name = "bidid")] public string _bidId;
        [DataMember(Name = "cutomdata")] public string _customData;
        [DataMember(Name = "nbr")] public int _reasonForNotBidding;
        [DataMember(Name = "ext")] public BidResponseExt _ext;
    }
}