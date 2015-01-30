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
    /// Модель покупки заказа позиции
    /// </summary>
    public class PurchaseOrderPosition : IKeyItem<Guid>
    {
        public PurchaseOrderPosition()
        {
            Thinks = new List<Things>();
        }
        [Key]
        [XmlIgnore]
        public Guid Id { get; set; }
        /// <summary>
        /// Скидка
        /// </summary>
        [XmlAttribute(AttributeName="discount")]
        public double Discount { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [XmlAttribute(AttributeName="quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName="consignmentUuid")]
        public Guid ConsigmentUuid { get; set; }

        /// <summary>
        /// Идентификатор товара
        /// </summary>
        [XmlAttribute(AttributeName="goodUuid")]
        public Guid GoodUuid { get; set; }

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
        /// 
        /// </summary>
        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }

        /// <summary>
        /// Идентификатор модели (позиции заказу)
        /// </summary>
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Цена без скидки
        /// </summary>
        [XmlElement(ElementName = "basePrice")]
        public Sum BasePrice { get; set; }

        /// <summary>
        /// Цена со скидкой
        /// </summary>
        [XmlElement(ElementName = "price")]
        public Sum Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "things")]
        public virtual List<Things> Thinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "reserve")]
        public double Reserve { get; set; }
    }
}
