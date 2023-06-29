using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class User
    {
        [DataMember(Name = "id")] public string id;
    }
}