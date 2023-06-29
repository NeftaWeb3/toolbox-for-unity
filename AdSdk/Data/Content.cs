using System;
using System.Runtime.Serialization;

namespace Nefta.AdSdk.Data
{
    [Serializable]
    public class Content
    {
        [DataMember(Name = "id")] public string _id;
        [DataMember(Name = "episode")] public int _episode;
        [DataMember(Name = "title")] public string _title;
        [DataMember(Name = "series")] public string _name;
        [DataMember(Name = "season")] public string _season;
        [DataMember(Name = "artist")] public string _creditedArtist;
        [DataMember(Name = "genre")] public string _genre;
        [DataMember(Name = "album")] public string _album;
        [DataMember(Name = "isrc")] public string _recordingCode;
        [DataMember(Name = "producer")] public string _producer;
        [DataMember(Name = "url")] public string _url;
        [DataMember(Name = "cat")] public string[] _producerCategories;
        [DataMember(Name = "prodq")] public int _productionQuality;
        [DataMember(Name = "context")] public int _type;
        [DataMember(Name = "contentrating")] public string _contentRating;
        [DataMember(Name = "userrating")] public string _userRating;
        [DataMember(Name = "qagmediarating")] public string _mediaRating;
        [DataMember(Name = "keywords")] public string _keywords;
        [DataMember(Name = "livestream")] public int _isLive;
        [DataMember(Name = "sourcerelationship")] public int _isDirect;
        [DataMember(Name = "len")] public int _lengthInSeconds;
        [DataMember(Name = "language")] public string _language;
        [DataMember(Name = "embeddable")] public int _isEmbedded;
        [DataMember(Name = "data")] public AdditionalData[] _additionalData;
        [DataMember(Name = "ext")] public string _ext;
    }
}