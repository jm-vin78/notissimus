using System.Xml;

namespace Offers.Models
{
    internal class Tour : OfferBase
    {
        public string Delivery { get; set; }
        public string LocalDeliveryCost { get; set; }
        public string WorldRegion { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Days { get; set; }
        public string DataTourBegin { get; set; }
        public string DataTourEnd { get; set; }
        public string Name { get; set; }
        public string HotelStars { get; set; }
        public string Room { get; set; }
        public string Meal { get; set; }
        public string Included { get; set; }
        public string Transport { get; set; }

        public Tour(XmlNode nodeItem, string nodeType) : base(nodeItem, nodeType)
        {
            Delivery = nodeItem.SelectSingleNode("delivery").InnerText;
            LocalDeliveryCost = nodeItem.SelectSingleNode("local_delivery_cost").InnerText;
            WorldRegion = nodeItem.SelectSingleNode("worldRegion").InnerText;
            Country = nodeItem.SelectSingleNode("country").InnerText;
            Region = nodeItem.SelectSingleNode("region").InnerText;
            Days = nodeItem.SelectSingleNode("days").InnerText;
            DataTourBegin = nodeItem.SelectNodes("dataTour").Item(0).InnerText;
            DataTourEnd = nodeItem.SelectNodes("dataTour").Item(1).InnerText;
            Name = nodeItem.SelectSingleNode("name").InnerText;
            HotelStars = nodeItem.SelectSingleNode("hotel_stars").InnerText;
            Room = nodeItem.SelectSingleNode("room").InnerText;
            Meal = nodeItem.SelectSingleNode("meal").InnerText;
            Included = nodeItem.SelectSingleNode("included").InnerText;
            Transport = nodeItem.SelectSingleNode("transport").InnerText;
        }
    }
}