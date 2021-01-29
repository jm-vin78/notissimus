using System.Xml;

namespace Offers.Models
{
    internal class Book : OfferBase
    {
        public string Delivery { get; set; }
        public string LocalDeliveryCost { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Series { get; set; }
        public string Year { get; set; }
        public string ISBN { get; set; }
        public string Volume { get; set; }
        public string Part { get; set; }
        public string Language { get; set; }
        public string Binding { get; set; }
        public string PageExtent { get; set; }
        public string Downloadable { get; set; }

        public Book(XmlNode nodeItem, string nodeType) : base(nodeItem, nodeType)
        {
            Delivery = nodeItem.SelectSingleNode("delivery").InnerText;
            LocalDeliveryCost = nodeItem.SelectSingleNode("local_delivery_cost").InnerText;
            Author = nodeItem.SelectSingleNode("author").InnerText;
            Name = nodeItem.SelectSingleNode("name").InnerText;
            Publisher = nodeItem.SelectSingleNode("publisher").InnerText;
            Series = nodeItem.SelectSingleNode("series").InnerText;
            Year = nodeItem.SelectSingleNode("year").InnerText;
            ISBN = nodeItem.SelectSingleNode("ISBN").InnerText;
            Volume = nodeItem.SelectSingleNode("volume").InnerText;
            Part = nodeItem.SelectSingleNode("part").InnerText;
            Language = nodeItem.SelectSingleNode("language").InnerText;
            Binding = nodeItem.SelectSingleNode("binding").InnerText;
            PageExtent = nodeItem.SelectSingleNode("page_extent").InnerText;
            Downloadable = nodeItem.SelectSingleNode("downloadable").InnerText;
        }
    }
}