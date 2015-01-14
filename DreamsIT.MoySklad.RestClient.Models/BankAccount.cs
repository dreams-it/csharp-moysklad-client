using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
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
    /// Модель банкового счета
    /// </summary>
    [ComplexType]
    [XmlRoot(ElementName = "bankAccount")]
    public class BankAccount
    {
        /// <summary>
        /// Номер счета
        /// </summary>
        [XmlAttribute(AttributeName = "accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Положение банка
        /// </summary>
        [XmlAttribute(AttributeName = "bankLocation")]
        public string BankLocation { get; set; }

        /// <summary>
        /// Название банка
        /// </summary>
        [XmlAttribute(AttributeName = "bankName")]
        public string BankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "bic")]
        public string Bic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "correspondentAccount")]
        public string CorrectspondentAccount { get; set; }

        /// <summary>
        /// Банк по умолчанию
        /// </summary>
        [XmlAttribute(AttributeName = "isDefault")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        [XmlAttribute(AttributeName = "updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Имя того, кто делал обновление
        /// </summary>
        [XmlAttribute(AttributeName = "updatedBy")]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "readMode")]
        public ReadMode ReadMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "changeMode")]
        public ChangeMode ChangeMode { get; set; }

        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }

        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }

        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }
    }
}
