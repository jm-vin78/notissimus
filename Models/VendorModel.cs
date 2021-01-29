using System.Xml;

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
        public VendorModel(XmlNode nodeItem, string nodeType) : base(nodeItem, nodeType)
        {
            Cbid = nodeItem.Attributes["cbid"].Value;
            Delivery = nodeItem.SelectSingleNode("delivery").InnerText;
            LocalDeliveryCost = nodeItem.SelectSingleNode("local_delivery_cost").InnerText;
            TypePrefix = nodeItem.SelectSingleNode("typePrefix").InnerText;
            Vendor = nodeItem.SelectSingleNode("vendor").InnerText;
            VendorCode = nodeItem.SelectSingleNode("vendorCode").InnerText;
            Model = nodeItem.SelectSingleNode("model").InnerText;
        }
    }
}