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
    /// Контрагент
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "company", IsNullable = false)]
    public partial class Company : Organization
    {
        /// <summary>
        /// Идентификатор 
        /// </summary>
        [XmlElement(ElementName="uuid")]
        public Guid Uuid { get; set; }

        [XmlAttribute(AttributeName = "payerVat")]
        public bool PayerVat { get; set; }

        [XmlAttribute(AttributeName = "discountCardNumber")]
        public string DiscountCardNumber { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public partial class CompanyCollection
    {
        public CompanyCollection()
        {
            Companies = new List<Company>();
        }

        [XmlElement(ElementName = "company")]
        public List<Company> Companies { get; set; }
    }
}
