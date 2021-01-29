namespace Offers.Models
{
    internal class Audiobook : OfferBase
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string PerformedBy { get; set; }
        public string PerformanceType { get; set; }
        public string Storage { get; set; }
        public string Format { get; set; }
        public string RecordingLength { get; set; }
        public string Downloadable { get; set; }
    }
}