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
    /// Модель заказ покупателя 
    /// </summary>
    public partial class CustomerOrder : Order
    {
        /// <summary>
        /// Идентификатор записи о заказе покупателя
        /// </summary>
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "sourceStoreUuid")]
        public Guid SourceStoreUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "demandsUuid")]
        public virtual List<Guid> DemandsUuid { get; set; }
                
        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "purchaseOrdersUuid")]
        public virtual List<Guid> PurchaseOrdersUuid { get; set; }
    }
}
