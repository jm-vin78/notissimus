using System.Xml;

namespace Offers.Models
{
    internal class ArtistTitleDVD : OfferBase
    {
        public string Delivery { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Media { get; set; }
        public string Starring { get; set; }
        public string Director { get; set; }
        public string OriginalName { get; set; }
        public string Country { get; set; }

        public ArtistTitleDVD(XmlNode nodeItem, string nodeType) : base(nodeItem, nodeType)
        {
            Delivery = nodeItem.SelectSingleNode("delivery").InnerText;
            Title = nodeItem.SelectSingleNode("title").InnerText;
            Year = nodeItem.SelectSingleNode("year").InnerText;
            Media = nodeItem.SelectSingleNode("media").InnerText;
            Starring = nodeItem.SelectSingleNode("starring").InnerText;
            Director = nodeItem.SelectSingleNode("director").InnerText;
            OriginalName = nodeItem.SelectSingleNode("originalName").InnerText;
            Country = nodeItem.SelectSingleNode("country").InnerText;
        }
    }
}