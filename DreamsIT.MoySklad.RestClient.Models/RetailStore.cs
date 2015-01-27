using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель точки продажу
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", ElementName = "retailStore", IsNullable = false)]
    public partial class RetailStore : IKeyItem<Guid>
    {
        [Key]
        [IgnoreDataMember]
        [XmlIgnore]
        public Guid Id { get; set; }

        /// <summary>
        /// Активная ли точка продажа
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "active")]
        public bool Active { get; set; }

        /// <summary>
        /// Адреса точки продажу
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Идентификатор юр.лица
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "myCompanyUuid")]
        public Guid MyCompanyUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "priceTypeUuid")]
        public Guid PriceTypeUuid { get; set; }

        /// <summary>
        /// Идентификатор склада
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "warehouseUuid")]
        public Guid WarehouseUuid { get; set; }

        /// <summary>
        /// Имя точки продажу
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Имя того, кто последний раз делал обновление
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "updatedBy")]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "readMode")]
        public ReadMode ReadMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "changeMode")]
        public ChangeMode ChangeMode { get; set; }

        /// <summary>
        /// Идентификатор пользователя создавшего запись
        /// </summary>
        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }

        /// <summary>
        /// Идентификатор профиля пользователя, который создал запись
        /// </summary>
        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }

        /// <summary>
        /// Идентификатор точки продажу
        /// </summary>
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "externalcode")]
        public string Externalcode { get; set; }

        /// <summary>
        /// Описание
        /// </summary> 
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public partial class RetailStores
    {
        public RetailStores()
        {
            Items = new List<RetailStore>();
        }
        [XmlElement(ElementName = "retailStore")]
        public List<RetailStore> Items { get; set; }
    }
}
