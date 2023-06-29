using System.Collections.Generic;
using System.Xml;

namespace Nefta.AdSdk.Data.Vast
{
    public class LinearCreative : Creative
    {
        public float _duration;
        public Dictionary<string, string> _trackingEvents;
        public string _clickThrough;
        public string _clickUrl;
        public List<MediaFile> _mediaFiles;

        public override void Read(XmlReader reader)
        {
            while (reader.NodeType != XmlNodeType.EndElement)
            {
                if (reader.Name == "Duration")
                {
                    reader.Read();
                    var times = reader.Value.Split(':');
                    _duration = int.Parse(times[0]) * 3600 + int.Parse(times[1]) * 60 + int.Parse(times[2]);
                    ConsumeTillNext(reader);
                }  
                else if (reader.Name == "TrackingEvents")
                {
                    ConsumeTillNext(reader);
                    _trackingEvents = new Dictionary<string, string>();
                    while (reader.NodeType != XmlNodeType.EndElement)
                    {
                        var eventName = reader.GetAttribute("event");
                        reader.Read();
                        _trackingEvents.Add(eventName, reader.Value);
                        reader.Read();
                        ConsumeTillNext(reader);
                    }
                }
                else if (reader.Name == "VideoClicks")
                {
                    ConsumeTillNext(reader);
                    reader.Read();
                    _clickThrough = reader.Value;
                    ConsumeTillNext(reader);
                }
                else if (reader.Name == "MediaFiles")
                {
                    ConsumeTillNext(reader);
                    _mediaFiles = new List<MediaFile>();
                    while (reader.NodeType != XmlNodeType.EndElement)
                    {
                        var mediaFile = new MediaFile();
                        mediaFile._isStreamingDelivery = reader.GetAttribute("delivery") == "streaming";
                        mediaFile._width = int.Parse(reader.GetAttribute("width"));
                        mediaFile._height = int.Parse(reader.GetAttribute("height"));
                        reader.Read();
                        mediaFile._url = reader.Value;
                        _mediaFiles.Add(mediaFile);
                        reader.Read();
                        ConsumeTillNext(reader);
                    }
                }
                ConsumeTillNext(reader);
            }
        }

        private void ConsumeTillNext(XmlReader reader)
        {
            reader.Read();
            if (reader.NodeType == XmlNodeType.Whitespace)
            {
                reader.Read();
            }
        }
    }
}