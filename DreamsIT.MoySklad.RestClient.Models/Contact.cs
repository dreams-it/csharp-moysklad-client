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
    [ComplexType]
    [XmlRoot(ElementName="contact")]
    public class Contact
    {
        /// <summary>
        /// Адреса
        /// </summary>
        [XmlAttribute(AttributeName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        [XmlAttribute(AttributeName = "phones")]
        public string Phones { get; set; }

        /// <summary>
        /// Факс
        /// </summary>
        [XmlAttribute(AttributeName = "faxes")]
        public string Faxes { get; set; }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        [XmlAttribute(AttributeName = "mobiles")]
        public string Mobiles { get; set; }

        /// <summary>
        /// Ел. Почта
        /// </summary>
        [XmlAttribute(AttributeName = "email")]
        public string Email { get; set; }
    }
}
