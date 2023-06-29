using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Geo
    {
        [DataMember(Name = "lat")] public float _latitude;
        [DataMember(Name = "lon")] public float _longtitude;
        [DataMember(Name = "type")] public int _type;
        [DataMember(Name = "accuracy")] public int _estimatedLocationAccuracyInMeters;
        [DataMember(Name = "lastfix")] public int _numberOfSecondsSinceSync;
        [DataMember(Name = "ipservice")] public int _provider;
        [DataMember(Name = "country")] public string _country;
        [DataMember(Name = "region")] public string _region;
        [DataMember(Name = "regionfips104")] public string _regionFips;
        [DataMember(Name = "metro")] public string _metroCode;
        [DataMember(Name = "city")] public string _city;
        [DataMember(Name = "zip")] public string _zip;
        [DataMember(Name = "utcoffset")] public string _utcOffset;
        [DataMember(Name = "ext")] public string _ext;
    }
}