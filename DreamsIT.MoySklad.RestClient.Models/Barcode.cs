using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "barcode", IsNullable = false)]
    public class Barcode:IKeyItem<Guid>
    {
        [XmlIgnore]
        public Guid Id { get; set; }

        [XmlAttribute(AttributeName = "barcode")]
        public string BarcodeValue { get; set; }

        [XmlAttribute(AttributeName = "barcodeType")]
        public BarcodeType BarcodeType { get; set; }

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

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class BarcodeCollection
    {
        public BarcodeCollection()
        {
            Barcodes = new List<Barcode>();
        }

        [XmlElement(ElementName = "barcode")]
        public List<Barcode> Barcodes { get; set; }
    }
}
