using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    [ComplexType]
    [XmlRoot(ElementName = "extension")]
    public partial class Extension
    {
        [XmlAttribute(AttributeName="opened")]
        public bool Opened { get; set; }

        [XmlAttribute(AttributeName = "loadName")]
        public string LoadName { get; set; }

        [XmlAttribute(AttributeName = "consignorIndication")]
        public string ConsignorIndication { get; set; }

        [XmlAttribute(AttributeName = "transportFacility")]
        public string TransportFacility { get; set; }

        [XmlAttribute(AttributeName = "carNumber")]
        public string CardNumber { get; set; }
    }
}
