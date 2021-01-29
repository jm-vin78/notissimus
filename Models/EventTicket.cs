using System.Xml;

namespace Offers.Models
{
    internal class EventTicket : OfferBase
    {
        public string Delivery { get; set; }
        public string LocalDeliveryCost { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Hall { get; set; }
        public string HallPlan { get; set; }
        public string HallPart { get; set; }
        public string Date { get; set; }
        public string IsPremiere { get; set; }
        public string IsKids { get; set; }

        public EventTicket(XmlNode nodeItem, string nodeType) : base(nodeItem, nodeType)
        {
            Delivery = nodeItem.SelectSingleNode("delivery").InnerText;
            LocalDeliveryCost = nodeItem.SelectSingleNode("local_delivery_cost").InnerText;
            Name = nodeItem.SelectSingleNode("name").InnerText;
            Place = nodeItem.SelectSingleNode("place").InnerText;
            Hall = nodeItem.SelectSingleNode("hall").InnerText;
            HallPlan = nodeItem.SelectSingleNode("hall").Attributes["plan"].Value;
            HallPart = nodeItem.SelectSingleNode("hall_part").InnerText;
            Date = nodeItem.SelectSingleNode("date").InnerText;
            IsPremiere = nodeItem.SelectSingleNode("is_premiere").InnerText;
            IsKids = nodeItem.SelectSingleNode("is_kids").InnerText;
        }
    }
}