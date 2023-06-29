using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Device
    {
        [DataMember(Name = "ua")] public string _userAgent;
        [DataMember(Name = "geo")] public Geo _location;
        [DataMember(Name = "dnt")] public int _doNotTrack;
        [DataMember(Name = "lmt")] public int _isTrackingLimited;
        [DataMember(Name = "ip")] public string _ip;
        [DataMember(Name = "ipv6")] public string _ipv6;
        [DataMember(Name = "devicetype")] public int _type;
        [DataMember(Name = "make")] public string _manufacturer;
        [DataMember(Name = "model")] public string _model;
        [DataMember(Name = "os")] public string _operatingSystem;
        [DataMember(Name = "osv")] public string _operatingSystemVersion;
        [DataMember(Name = "hwv")] public string _hardwareVersion;
        [DataMember(Name = "h")] public int _screenHeight;
        [DataMember(Name = "w")] public int _screenWidth;
        [DataMember(Name = "ppi")] public int _dotsPerInch;
        [DataMember(Name = "pxration")] public float _screenToRendererPixelRatio;
        [DataMember(Name = "js")] public int _isJavaScriptSupported;
        [DataMember(Name = "geofetch")] public int _isGeoLocationAvailableInJavaScript;
        [DataMember(Name = "flashver")] public string _flashVersion;
        [DataMember(Name = "language")] public string _language;
        [DataMember(Name = "carrier")] public string _carrier;
        [DataMember(Name = "mccmnc")] public string _mncCarrier;
        [DataMember(Name = "connectiontype")] public int _networkConnectionType;
        [DataMember(Name = "ifa")] public string _advertiserId;
        [DataMember(Name = "didsha1")] public string _deviceIdSha1;
        [DataMember(Name = "didmd5")] public string _deviceIdMd5;
        [DataMember(Name = "dpidsha1")] public string _platformDeviceIdSha1;
        [DataMember(Name = "dpidmd5")] public string _platformDeviceIdMd5;
        [DataMember(Name = "macsha1")] public string _macAddressSha1;
        [DataMember(Name = "macsmd5")] public string _macAddressMd5;
        [DataMember(Name = "ext")] public string _ext;
    }
}