using System.Collections.Generic;
using System.Xml;

namespace Nefta.AdSdk.Data.Vast
{
    public class Vast
    {
        public string _errorUrl;
        public string _impressionUrl;
        public List<Creative> _creatives;

        public void Read(XmlReader reader)
        {
            reader.ReadToFollowing("Impression");
            reader.Read();
            _impressionUrl = reader.Value;

            reader.ReadToFollowing("Creatives");
            ConsumeTillNext(reader);
            _creatives = new List<Creative>();
            while (reader.NodeType != XmlNodeType.EndElement)
            {
                var creativeId = reader.GetAttribute("id");
                ConsumeTillNext(reader);

                Creative creative = null;
                if (reader.Name == "Linear")
                {
                    creative = new LinearCreative();
                    creative.Read(reader);
                }
                else if (reader.Name == "CompanionAds")
                {
                    creative = new CompanionCreative();
                    creative.Read(reader);
                }

                creative._id = creativeId;
                _creatives.Add(creative);
                ConsumeTillNext(reader);
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