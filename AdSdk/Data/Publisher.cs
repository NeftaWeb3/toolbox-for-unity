using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Publisher
    {
        [DataMember(Name = "id")] public string _id;
        [DataMember(Name = "name")] public string _name;
        [DataMember(Name = "cat")] public string[] _categories;
        [DataMember(Name = "domain")] public string _domain;
        [DataMember(Name = "ext")] public string _ext;
    }
}