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
    /// Модель складу (warehouse)
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "warehouse", IsNullable = false)]
    public class Warehouse : IKeyItem<Guid>
    {
        [Key]
        [XmlIgnore]
        public Guid Id { get; set; }
        /// <summary>
        /// Идентификатор компании
        /// </summary>
        [XmlAttribute(AttributeName = "agentUuid")]
        public Guid AgentUuid { get; set; }

        /// <summary>
        /// Не активный ли склад
        /// </summary>
        [XmlAttribute(AttributeName = "archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public Guid? ParentUuid
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_parentUuid))
                {
                    return Guid.Parse(_parentUuid);
                }
                return null;
            }
        }

        [XmlAttribute(AttributeName = "parentUuid")]
        public string _parentUuid { get; set; }


        /// <summary>
        /// Имя склада в системе
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновление
        /// </summary>
        [XmlAttribute(AttributeName = "updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Имя пользователя кто последний обновил запись
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
        /// Идентификатор склада
        /// </summary>
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }

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
        /// Описание склада
        /// </summary>
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Контакти скада
        /// </summary>
        [XmlElement(ElementName = "contact")]
        public Contact Contact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "slots")]
        public List<Slot> Slots { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class WarehouseCollection
    {
        public WarehouseCollection()
        {
            WarehouseList = new List<Warehouse>();
        }

        [XmlElement(ElementName = "warehouse")]
        public List<Warehouse> WarehouseList { get; set; }
    }
}
