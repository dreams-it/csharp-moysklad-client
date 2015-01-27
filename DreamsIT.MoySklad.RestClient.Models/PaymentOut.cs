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
    /// Модель безналичной выплаты
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "paymentOut", IsNullable = false)]
    public partial class PaymentOut : Payment
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName="uuid")]
        public Guid Uuid { get; set; }
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
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public partial class PaymentOutCollection
    {
        public PaymentOutCollection()
        {
            PaymentOutList = new List<PaymentOut>();
        }

        [XmlElement(ElementName = "paymentOut")]
        public List<PaymentOut> PaymentOutList { get; set; }
    }
}
