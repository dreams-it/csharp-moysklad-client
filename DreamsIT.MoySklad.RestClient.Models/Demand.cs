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
    /// Модель отгрузки товара
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "demand", IsNullable = false)]
    public class Demand: RecordOperation
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [XmlElement(ElementName="uuid")]
        public Guid Uuid { get; set; }
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
        [XmlAttribute(AttributeName = "sourceStoreUuid")]
        public Guid SourceStoreUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "targetAccountUuid")]
        public Guid TargetAccountUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "sourceAccountUuid")]
        public Guid SourceAccountUuid { get; set; }

        [XmlAttribute(AttributeName = "applicable")]
        public bool Applicable { get; set; }

        /// <summary>
        /// Цена (сумма) за товар
        /// </summary>
        [XmlElement(ElementName = "sum")]
        public Sum Sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "invoicesOutUuid")]
        public List<Guid> InvoicesOutUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "paymentsUuid")]
        public List<Guid> PaymentsUuid { get; set; }

        [XmlArray(ElementName = "financeInRef")]
        public List<Guid> FinanceInRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "invoicesOutUuid")]
        public List<ShipmentOut> ShipmentOut { get; set; }

        [XmlArray(ElementName = "salesReturnsUuid")]
        public List<Guid> SalesReturnUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "extension")]
        public Extension Extension { get; set; }

    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class DemandCollection
    {
        public List<Demand> Demands { get; set; }
    }
}
