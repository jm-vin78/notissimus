using System.Xml;

namespace Offers.Models
{
    internal class ArtistTitleCD : OfferBase
    {
        public string Delivery { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Media { get; set; }

        public ArtistTitleCD(XmlNode nodeItem, string nodeType) : base(nodeItem, nodeType)
        {
            Delivery = nodeItem.SelectSingleNode("delivery").InnerText;
            Artist = nodeItem.SelectSingleNode("artist").InnerText;
            Title = nodeItem.SelectSingleNode("title").InnerText;
            Year = nodeItem.SelectSingleNode("year").InnerText;
            Media = nodeItem.SelectSingleNode("media").InnerText;
        }
    }
}