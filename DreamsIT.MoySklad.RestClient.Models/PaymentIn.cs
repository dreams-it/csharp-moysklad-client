using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель безналичного прихода 
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "paymentIn", IsNullable = false)]
    public class PaymentIn : Payment
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "incomingNumber")]
        public Guid incomingNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "paymentPurpose")]
        public String paymentPurpose { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "demandsUuid")]
        [XmlArrayItem(ElementName = "demandRef")]
        public List<Guid> DemandsUuid { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class PaymentInCollection
    {
        public PaymentInCollection()
        {
            PaymentInList = new List<PaymentIn>();
        }

        public List<PaymentIn> PaymentInList { get; set; }
    }
}
