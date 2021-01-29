using System.Xml;

namespace Offers.Models
{
    internal abstract class OfferBase
    {
        public string Id { get; set; }
        public string OfferType { get; set; }
        public string Bid { get; set; }
        public string Available { get; set; }

        public string Url { get; set; }
        public string Price { get; set; }
        public string CurrencyId { get; set; }
        public string CategoryIdType { get; set; }
        public string CategoryId { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }

        public OfferBase(XmlNode nodeItem, string nodeType)
        {
            Id = nodeItem.Attributes["id"].Value;
            OfferType = nodeType;
            Bid = nodeItem.Attributes["bid"].Value;
            Available = nodeItem.Attributes["available"].Value;

            Url = nodeItem.SelectSingleNode("url").InnerText;
            Price = nodeItem.SelectSingleNode("price").InnerText;
            CurrencyId = nodeItem.SelectSingleNode("currencyId").InnerText;
            CategoryIdType = nodeItem.SelectSingleNode("categoryId").Attributes["type"].Value;
            CategoryId = nodeItem.SelectSingleNode("categoryId").InnerText;
            Picture = nodeItem.SelectSingleNode("picture").InnerText;
            Description = nodeItem.SelectSingleNode("description").InnerText;
        }
    }
}