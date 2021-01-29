using System.Xml;

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

        public Audiobook(XmlNode nodeItem, string nodeType) : base(nodeItem, nodeType)
        {
            Author = nodeItem.SelectSingleNode("author").InnerText;
            Name = nodeItem.SelectSingleNode("name").InnerText;
            Publisher = nodeItem.SelectSingleNode("publisher").InnerText;
            Year = nodeItem.SelectSingleNode("year").InnerText;
            ISBN = nodeItem.SelectSingleNode("ISBN").InnerText;
            Language = nodeItem.SelectSingleNode("language").InnerText;
            PerformedBy = nodeItem.SelectSingleNode("performed_by").InnerText;
            PerformanceType = nodeItem.SelectSingleNode("performance_type").InnerText;
            Storage = nodeItem.SelectSingleNode("storage").InnerText;
            Format = nodeItem.SelectSingleNode("format").InnerText;
            RecordingLength = nodeItem.SelectSingleNode("recording_length").InnerText;
            Downloadable = nodeItem.SelectSingleNode("downloadable").InnerText;
        }
    }
}