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
    /// Модель позиции оприходования 
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "enterPosition", IsNullable = false)]
    public partial class EnterPosition : IKeyItem<Guid>
    {
        public EnterPosition()
        {
            Tags = new List<Tags>();
            Things = new List<Things>();
        }

        [XmlIgnore]
        public Guid Id { get; set; }
        /// <summary>
        /// скидка
        /// </summary>
        [XmlAttribute(AttributeName = "discount")]
        public double Discount { get; set; }

        /// <summary>
        /// количество
        /// </summary>
        [XmlAttribute(AttributeName = "quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// Идентификатор партии (накладной)
        /// </summary>
        [XmlAttribute(AttributeName = "consignmentUuid")]
        public Guid ConsigmentUuid { get; set; }

        /// <summary>
        /// идентификатор товара
        /// </summary>
        [XmlAttribute(AttributeName = "goodUuid")]
        public Guid GoodUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "vat")]
        public int Vat { get; set; }

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
        /// идентификатор записи
        /// </summary>
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Базовая цена
        /// </summary>
        [XmlElement(ElementName = "basePrice")]
        public Sum BasePrice { get; set; }

        /// <summary>
        /// Конечная цена
        /// </summary>
        [XmlElement(ElementName = "price")]
        public Sum Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "things")]
        public virtual List<Things> Things { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "tags")]
        public virtual List<Tags> Tags { get; set; }
    }
}
