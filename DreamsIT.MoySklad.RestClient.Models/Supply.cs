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
    /// <summary>
    /// Модель класса приема 
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "supply", IsNullable = false)]
    public class Supply : RecordOperation
    {
        public Supply()
        {
            InvoicesInUuid = new List<Guid>();
            PurchaseReturnsUuid = new List<Guid>();
        }

        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [XmlElement(ElementName="uuid")]
        public Guid Uuid { get; set; }
        /// <summary>
        /// Номер приема товара
        /// </summary>
        [XmlAttribute(AttributeName = "incomingNumber")]
        public string IncomingNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "overheadDistribution")]
        public OverheadDistribution OverheadDistribution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "targetAgentUuid")]
        public Guid TargetAgentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "sourceAgentUuid")]
        public Guid SourceAgentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "targetStoreUuid")]
        public Guid TargetStoreUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "applicable")]
        public bool Applicable { get; set; }

        /// <summary>
        /// Дата приема товара
        /// </summary>
        [XmlAttribute(AttributeName = "moment")]
        public string Moment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "targetAccountUuid")]
        public Guid TargetAccountUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "sourceAccountUuid")]
        public Guid SourceAccountId { get; set; }

        /// <summary>
        /// Сумма приема товара
        /// </summary>
        [XmlElement(ElementName = "sum")]
        public Sum Sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "invoicesInUuid")]
        public virtual List<Guid> InvoicesInUuid { get; set; }

        /// <summary>
        /// Накладные расходы
        /// </summary>
        [XmlElement(ElementName = "overhead")]
        public Sum Overhead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "paymentsUuid")]
        public virtual List<Guid> PaymentsUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipmentIn")]
        public ShipmentIn ShipmentIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "purchaseReturnsUuid")]
        public virtual List<Guid> PurchaseReturnsUuid { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class SupplyCollection
    {
        public SupplyCollection()
        {
            Items = new List<Supply>();
        }
        [XmlElement(ElementName="supply")]
        public List<Supply> Items { get; set; }
    }
}
