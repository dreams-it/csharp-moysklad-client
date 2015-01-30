using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель цена
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "price", IsNullable = false)]
    public class Price: IKeyItem<Guid>
    {
        [Key]
        [XmlIgnore]
        public Guid Id { get; set; }
        [XmlAttribute(AttributeName = "priceTypeUuid")]
        public Guid PriceTypeUuid { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public double Value { get; set; }
        [XmlAttribute(AttributeName = "readMode")]
        public ReadMode ReadMode { get; set; }
        [XmlAttribute(AttributeName = "changeMode")]
        public ChangeMode ChangeMode { get; set; }
        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }
        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }
    }
}
