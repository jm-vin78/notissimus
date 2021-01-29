namespace Offers.Models
{
    internal class VendorModel : OfferBase
    {
        public string Cbid { get; set; }
        public string Delivery { get; set; }
        public string LocalDeliveryCost { get; set; }
        public string TypePrefix { get; set; }
        public string Vendor { get; set; }
        public string VendorCode { get; set; }
        public string Model { get; set; }
    }
}