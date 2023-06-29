using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Bid
    {
        [DataMember(Name = "id")] public string _id;
        [DataMember(Name = "impid")] public string _impressionId;
        [DataMember(Name = "price")] public float _price;
        [DataMember(Name = "nurl")] public string _winNoticeUrl;
        [DataMember(Name = "burl")] public string _billingNoticeUrl;
        [DataMember(Name = "lurl")] public string _lostNoticeUrl;
        [DataMember(Name = "adm")] public string _adMarkup;
        [DataMember(Name = "adid")] public string _preloadedAdIdToServe;
        [DataMember(Name = "adomain")] public List<string> _advertiserDomain;
        [DataMember(Name = "bundle")] public string _bundle;
        [DataMember(Name = "iurl")] public string _url;
        [DataMember(Name = "cid")] public string _campaignId;
        [DataMember(Name = "crid")] public string _creativeQualityCheckId;
        [DataMember(Name = "tactic")] public string _tactic;
        [DataMember(Name = "cat")] public string[] _categories;
        [DataMember(Name = "attr")] public int[] _attributes;
        [DataMember(Name = "api")] public int _requiredApi;
        [DataMember(Name = "protocol")] public int _videoProtocol;
        [DataMember(Name = "qagmediarating")] public int _mediaRating;
        [DataMember(Name = "language")] public string _language;
        [DataMember(Name = "dealid")] public string _dealId;
        [DataMember(Name = "w")] public int _width;
        [DataMember(Name = "h")] public int _height;
        [DataMember(Name = "wratio")] public int _relativeWidth;
        [DataMember(Name = "hratio")] public int _relativeHeight;
        [DataMember(Name = "exp")] public int _suggestedDelayInSecondsFromAuctionToImpression;
        [DataMember(Name = "ext")] public BidExt _ext;
    }
}