using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "shipmentIn", IsNullable = false)]
    public partial class ShipmentIn:Shipment, IKeyItem<Guid>
    {
        [Key]
        public Guid Id { get; set; }

        [XmlAttribute(AttributeName = "overhead")]
        public double OverHead { get; set; }
    }
}
