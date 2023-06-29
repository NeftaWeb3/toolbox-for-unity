using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Site
    {
        [DataMember(Name = "id")] public string _id;
        [DataMember(Name = "name")] public string _name;
        [DataMember(Name = "domain")] public string _domain;
        [DataMember(Name = "cat")] public string[] _contentCategories;
        [DataMember(Name = "sectioncat")] public string[] _sectionCategories;
        [DataMember(Name = "pagecat")] public string[] _pageCategories;
        [DataMember(Name = "page")] public string _pageUrl;
        [DataMember(Name = "ref")] public string _referrerUrl;
        [DataMember(Name = "search")] public string _referrerSearch;
        [DataMember(Name = "mobile")] public int _isOptimizedForMobile;
        [DataMember(Name = "privacypolicy")] public int _hasPrivacyPolicy;
        [DataMember(Name = "publisher")] public Publisher _publisher;
        [DataMember(Name = "consent")] public Consent _consent;
        [DataMember(Name = "keywords")] public Publisher _keywords;
        [DataMember(Name = "ext")] public string _ext;
    }
}