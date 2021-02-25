using System.Xml.Serialization;

namespace BoyumITCodeChallenge.models
{
    [XmlType("Item")]
    public class WebOrderItem
    {
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("Price")]
        public decimal Price { get; set; }
        [XmlElement("Quantity")]
        public decimal Quantity { get; set; }
    }
}
