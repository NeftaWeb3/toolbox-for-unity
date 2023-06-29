using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class BidRequest
    {
        [DataMember(Name = "id")] public string _id;
        [DataMember(Name = "at")] public int _auctionType;
        [DataMember(Name = "cur")] public string[] _allowedCurrencies;
        [DataMember(Name = "imp")] public Impression[] _impressions;
        [DataMember(Name = "site")] public Site _site;
        [DataMember(Name = "app")] public Application _application;
        [DataMember(Name = "device")] public Device _device;
        [DataMember(Name = "user")] public User _user;
        [DataMember(Name = "ext")] public BidRequestExt _ext;
    }
}