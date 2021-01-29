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
    }
}