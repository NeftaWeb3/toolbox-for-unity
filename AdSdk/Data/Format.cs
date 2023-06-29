using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Format
    {
        [DataMember(Name = "w")] public int _width;
        [DataMember(Name = "h")] public int _height;
        [DataMember(Name = "wratio")] public int _relativeWidth;
        [DataMember(Name = "hratio")] public int _relativeHeight;
    }
}