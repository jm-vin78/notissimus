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
    }
}