using System.Xml;

namespace Nefta.AdSdk.Data.Vast
{
    public class CompanionCreative : Creative
    {
        public override void Read(XmlReader reader)
        {
            reader.Skip();
        }
    }
}