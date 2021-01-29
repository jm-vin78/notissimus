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
    }
}