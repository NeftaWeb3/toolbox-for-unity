using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Banner
    {
        [DataMember(Name = "format")] public Format[] _format;
        [DataMember(Name = "w")] public int _width;
        [DataMember(Name = "h")] public int _height;
        [DataMember(Name = "btype")] public int[] _blockedBannerTypes;
        [DataMember(Name = "battr")] public int[] _blockedCreativeAttributes;
        [DataMember(Name = "pos")] public int _positionOnScreen;
        [DataMember(Name = "mimes")] public string[] _supportedMimeTypes;
        [DataMember(Name = "topframe")] public int _isInTopFrame;
        [DataMember(Name = "expdir")] public int[] _expandDirections;
        [DataMember(Name = "api")] public int[] _supportedApiFrameworks;
        [DataMember(Name = "id")] public string _id;
        [DataMember(Name = "vcm")] public int _isEndCard;
        [DataMember(Name = "ext")] public string _ext;
    }
}