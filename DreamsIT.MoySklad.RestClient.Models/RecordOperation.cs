using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public partial class RecordOperation : IKeyItem<Guid>
    {
        [XmlIgnore]
        public Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "payerVat")]
        public bool PayerVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName="rate")]
        public double Rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "vatIncluded")]
        public bool VatIcluded { get; set; }

        /// <summary>
        /// Дата создания записи 
        /// </summary>
        [XmlAttribute(AttributeName="created")]
        public string Created { get; set; }

        /// <summary>
        /// Имя того, кто создал запись
        /// </summary>
        [XmlAttribute(AttributeName="createdBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Название 
        /// </summary>
        [XmlAttribute(AttributeName="name")]
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления товара
        /// </summary>
        [XmlAttribute(AttributeName="updated")]
        public DateTime Updated { get; set; }
        /// <summary>
        /// Имя того, кто последний обновлял запись
        /// </summary>
        [XmlAttribute(AttributeName="updatedBy")]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("readMode")]
        public ReadMode ReadMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("changeMode")]
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
        /// 
        /// </summary>
        [XmlElement(ElementName = "externalcode")]
        public string ExternalCode { get; set; }

    }
}
