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
    }
}