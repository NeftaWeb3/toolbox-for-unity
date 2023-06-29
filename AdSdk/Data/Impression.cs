using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Impression
    {
        public enum States
        {
            Created,
            Requested,
            Available,
            Shown
        }
        
        [DataMember(Name = "id")] public string _id;
        [DataMember(Name = "metric")] public Metric[] _metrics;
        [DataMember(Name = "banner")] public Banner _banner;
        [DataMember(Name = "video")] public Video _video;
        [DataMember(Name = "displaymanager")] public string _renderingManager;
        [DataMember(Name = "displaymanagerver")] public string _renderingManagerVersion;
        [DataMember(Name = "instl")] public int _isInterstitialOrFullScreen;
        [DataMember(Name = "tagid")] public string _tagId;
        [DataMember(Name = "bidfloor")] public float _bidFloor;
        [DataMember(Name = "bidfloorcur")] public string _bidFloorCurrency;
        [DataMember(Name = "clickbrowser")] public int _isNativeBrowser;
        [DataMember(Name = "secure")] public int _isSecureImpressionUrlRequired;
        [DataMember(Name = "iframebuster")] public string[] _supportedFrameBusters;
        [DataMember(Name = "exp")] public int _suggestedDelayFromAuctionToImpression;
        [DataMember(Name = "ext")] public string _ext;

        [IgnoreDataMember] public Bid _bid;
    }
}