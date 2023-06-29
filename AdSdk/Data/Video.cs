using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Video
    {
        [DataMember(Name = "mimes")] public string[] _supportedMimeTypes;
        [DataMember(Name = "minduration")] public int _minimumDurationInSeconds;
        [DataMember(Name = "maxduration")] public int _maximumDurationInSeconds;
        [DataMember(Name = "protocols")] public int[] _supportedProtocols;
        [DataMember(Name = "w")] public int _width;
        [DataMember(Name = "h")] public int _height;
        [DataMember(Name = "startdelay")] public int _preRollStartDelay;
        [DataMember(Name = "placement")] public int _placementType;
        [DataMember(Name = "linearity")] public int _mustBeLinear;
        [DataMember(Name = "skip")] public int _isSkippable;
        [DataMember(Name = "skipmin")] public int _canSkipAfter;
        [DataMember(Name = "sequence")] public int _orderInSequence;
        [DataMember(Name = "battr")] public int[] _blockedCreativeAttributes;
        [DataMember(Name = "maxextend")] public int _maxEimumExtendDuration;
        [DataMember(Name = "minbitrate")] public int _minimumBitRateInKbps;
        [DataMember(Name = "maxbitrate")] public int _maximumBitRateInKbps;
        [DataMember(Name = "boxingallowed")] public int _isLetterBoxingAllowed;
        [DataMember(Name = "playbackmethod")] public int[] _playBackMethods;
        [DataMember(Name = "playbackend")] public int _playbeckEndEvent;
        [DataMember(Name = "delivery")] public int[] _supportedDeliveryMethods;
        [DataMember(Name = "pos")] public int _adPositionOnScreen;
        [DataMember(Name = "companionad")] public Banner[] _companionBanners;
        [DataMember(Name = "api")] public int[] _supportedApiFrameworks;
        [DataMember(Name = "companiontype")] public int[] _supportedVastCompanionAdTypes;
        [DataMember(Name = "ext")] public string _ext;
    }
}