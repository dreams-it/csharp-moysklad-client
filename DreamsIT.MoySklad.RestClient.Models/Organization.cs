using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    public class Organization : IKeyItem<Guid>
    {
        public Organization()
        {
            Tags = new List<Tags>();
        }

        [Key]
        [XmlIgnore]
        public Guid Id { get; set; }
        /// <summary>
        /// Тип компании
        /// </summary>
        [XmlAttribute(AttributeName = "companyType")]
        public CompanyType CompanyType { get; set; }

        /// <summary>
        /// Скидка
        /// </summary>
        [XmlAttribute(AttributeName = "discount")]
        public double Discount { get; set; }

        [XmlAttribute(AttributeName = "autoDiscount")]
        public double AutoDiscount { get; set; }
        /// <summary>
        /// Коррекция скидки
        /// </summary>
        [XmlAttribute(AttributeName = "discountCorrection")]
        public double DiscountCorrection { get; set; }

        /// <summary>
        /// Не активный ли Organization
        /// </summary>
        [XmlAttribute(AttributeName = "archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// Дата создания в системе
        /// </summary>
        [XmlAttribute(AttributeName = "created")]
        public string Created { get; set; }

        /// <summary>
        /// Название Organization
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        [XmlAttribute(AttributeName = "updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Имя того, кто делал последнее обновление
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

        /// <summary>
        /// Идентификатор пользователя, который создал запись
        /// </summary>
        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }

        /// <summary>
        /// Идентификатор профиля пользователя, который создал запись
        /// </summary>
        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "externalcode")]
        public string ExternalCode { get; set; }
        /// <summary>
        /// Описание 
        /// </summary>
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Модель реквизитов 
        /// </summary>
        [XmlElement(ElementName = "requisite")]
        public Requisite Requisite { get; set; }

        /// <summary>
        /// Модель банкового счета
        /// </summary>
        [XmlElement(ElementName = "bankAccount")]
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// Контакты
        /// </summary>
        [XmlElement(ElementName = "contact")]
        public Contact Contact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual List<Tags> Tags { get; set; }
    }
}
