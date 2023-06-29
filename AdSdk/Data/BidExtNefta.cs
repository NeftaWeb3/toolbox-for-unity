using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class BidExtNefta
    {
        [DataMember(Name = "tracking_click_url")] public string _tracking_click_url;
        [DataMember(Name = "redirect_click_url")] public string _redirect_click_url;
    }
}