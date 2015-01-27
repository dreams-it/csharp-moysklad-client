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
    /// Юр. лицо
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "myCompany", IsNullable = false)]
    public partial class MyCompany : Organization
    {
        /// <summary>
        /// Идентификатор 
        /// </summary>
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }

        [XmlAttribute(AttributeName = "director")]
        public string Director { get; set; }

        /// <summary>
        /// Имя главного бухгалтера
        /// </summary>
        [XmlAttribute(AttributeName="chiefAccountant")]
        public string ChiefAccountant { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public partial class MyCompanyCollection
    {
        public MyCompanyCollection()
        {
            MyCompanies = new List<MyCompany>();
        }
        [XmlElement(ElementName = "myCompany")]
        public List<MyCompany> MyCompanies { get; set; }
    }
}
