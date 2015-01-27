using DreamsIT.Data.BaseTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель реквизитов
    /// </summary>
    [ComplexType]
    [XmlRoot(ElementName = "requisite")]
    public partial class Requisite
    {
        /// <summary>
        /// Официальное название
        /// </summary>
        [XmlAttribute(AttributeName = "legalTitle")]
        public string LegalTitle { get; set; }

        /// <summary>
        /// Официальный адрес
        /// </summary>
        [XmlAttribute(AttributeName = "legalAddress")]
        public string LegalAddress { get; set; }

        /// <summary>
        /// Текущий адрес
        /// </summary>
        [XmlAttribute(AttributeName = "actualAddress")]
        public string ActualAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "inn")]
        public string Inn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "okpo")]
        public string Okpo { get; set; }

        [XmlAttribute(AttributeName = "ogrn")]
        public string Ogrn { get; set; }

        [XmlAttribute(AttributeName = "ogrnip")]
        public string Ogrnip { get; set; }

        [XmlAttribute(AttributeName = "nomerSvidetelstva")]
        public string NoverSvidetelstva { get; set; }
    }
}
