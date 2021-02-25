using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BoyumITCodeChallenge.models
{
    [XmlRoot("WebOrder")]
    public class WebOrder
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlElement("Customer")]
        public string Customer { get; set; }
        [XmlElement("Date")]
        public string _Date {get; set;}
        [XmlIgnore]
        public DateTime Date {
            get { return DateTime.ParseExact(_Date, "yyyyMMdd", null); }
        }
        [XmlArray("Items")]
        public List<WebOrderItem> Items { get; set; }

        [XmlIgnore]
        public decimal totalPrice {
            get {
                decimal sum = 0;
                foreach( WebOrderItem item in Items)
                {
                    sum += item.Price * item.Quantity;
                }
                return sum;
            }
        }
        [XmlIgnore]
        public decimal priceAverage
        {
            get
            {
                decimal sum = 0;
                decimal totalItems = 0;
                foreach (WebOrderItem item in Items)
                {
                    sum += item.Price * item.Quantity;
                    totalItems += item.Quantity;
                }
                if (totalItems == 0)
                    return 0;
                return sum / totalItems;
            }
        }
    }
}
