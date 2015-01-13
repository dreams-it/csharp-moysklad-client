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
    public class Company : Organization
    {
        /// <summary>
        /// Идентификатор 
        /// </summary>
        [XmlElement(ElementName="uuid")]
        public Guid Uuid { get; set; }

        public bool PayerVat { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class CompanyCollection
    {
        [XmlElement(ElementName = "company")]
        public CompanyCollection()
        {
            Companies = new List<Company>();
        }

        public List<Company> Companies { get; set; }
    }
}
