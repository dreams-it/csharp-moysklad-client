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
    /// Модель категории товару
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "goodFolder", IsNullable = false)]
    public class GoodFolder : IKeyItem<Guid>
    {
        [XmlIgnore]
        public Guid Id { get; set; }
        /// <summary>
        /// Не активная ли категория
        /// </summary>
        [XmlAttribute(AttributeName = "archived")]
        public bool Archived { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "productCode")]
        public string ProductCode { get; set; }
        /// <summary>
        /// Дата последнего обновления категории
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        /// <summary>
        ///Дата последнего обновления категории
        /// </summary>
        [XmlAttribute(AttributeName = "updated")]
        public DateTime Updated { get; set; }
        /// <summary>
        /// Имя того, кто последний обновил запись
        /// </summary>
        [XmlAttribute(AttributeName = "updatedBy")]
        public  string UpdatedBy { get; set; }
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
        /// Идентификатор пользователя создавшего запись
        /// </summary>
        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }
        /// <summary>
        /// Идентификатор профиля пользователя, создал запись
        /// </summary>
        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "externalcode")]
        public String Externalcode { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class GoodFolderCollection
    {
        public GoodFolderCollection()
        {
            GoodFolders = new List<GoodFolder>();
        }

        [XmlElement(ElementName = "goodFolder")]
        public List<GoodFolder> GoodFolders { get; set; }
    }
}
