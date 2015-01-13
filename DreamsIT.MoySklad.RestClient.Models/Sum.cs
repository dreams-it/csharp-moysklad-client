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
    /// Модель Сумма
    /// </summary>
    [ComplexType]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "sum", IsNullable = false)]
    public class Sum
    {
        /// <summary>
        /// Сумма
        /// </summary>
        [XmlAttribute(AttributeName = "sum")]
        public double SumVal { get; set; }

        /// <summary>
        /// Сумма в валюте
        /// </summary>
        [XmlAttribute(AttributeName = "sumInCurrency")]
        public double SumInCurrency { get; set; }
    }
}
