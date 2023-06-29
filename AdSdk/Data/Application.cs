using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Application
    {
        [DataMember(Name = "id")] public string _id;
        [DataMember(Name = "name")] public string _name;
        [DataMember(Name = "bundle")] public string _bundle;
        [DataMember(Name = "domain")] public string _domain;
        [DataMember(Name = "storeurl")] public string _storeUrl;
        [DataMember(Name = "cat")] public string[] _contentCategories;
        [DataMember(Name = "sectioncat")] public string[] _sectionCategories;
        [DataMember(Name = "pagecat")] public string[] _pageCategories;
        [DataMember(Name = "ver")] public string _version;
        [DataMember(Name = "privacypolicy")] public int _hasPrivacyPolicy;
        [DataMember(Name = "paid")] public int _isPaid;
        [DataMember(Name = "publisher")] public Publisher _publisher;
        [DataMember(Name = "content")] public Content _content;
        [DataMember(Name = "keywords")] public string _keywords;
        [DataMember(Name = "ext")] public string _ext;
    }
}