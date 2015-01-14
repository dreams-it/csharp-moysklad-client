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
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "good", IsNullable = false)]
    public class Good : IKeyItem<Guid>
    {
        /// <summary>
        /// Модель продукта
        /// </summary>
        [XmlIgnore]
        public Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "isSerialTrackable")]
        public bool IsSerialTrackable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "buyPrice")]
        public Double BuyPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "weight")]
        public Double Weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "volume")]
        public Double Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "minPrice")]
        public Double MinPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "uomUuid")]
        public Guid UomUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "salePrice")]
        public Double SalePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "archived")]
        public bool Archived { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "parentUuid")]
        public Guid ParentUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "productCode")]
        public String ProductCode { get; set; }
        /// <summary>
        ///  Имя продукта
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public String Name { get; set; }
        /// <summary>
        /// Дата последнего обновления записи
        /// </summary>
        [XmlAttribute(AttributeName = "updated")]
        public  DateTime updated { get; set; }
        /// <summary>
        /// Имя того, кто делал последнеее обновление
        /// </summary>
        [XmlAttribute(AttributeName = "updatedBy")]
        public  DateTime updatedBy { get; set; }
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
        /// 
        /// </summary>
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "code")]
        public String Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "externalcode")]
        public String Externalcode { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        [XmlElement(ElementName = "description")]
        public String Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "salePrice")]
        public List<Price> SalePrices { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "preferences")]
        public Preferences Preferences { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "images")]
        public Images Images { get; set; }
    }

    //[ComplexType]
    //public class SalePrice
    //{
    //    public SalePrice()
    //    {
    //        SalePrices = new List<Price>();
    //    }

    //    [XmlArray(ElementName = "price")]
    //    public List<Price> SalePrices { get; set; }
    //}

    public class GoodCollection
    {
        public GoodCollection()
        {
            GoodList = new List<Good>();
        }

        public List<Good> GoodList { get; set; }
    }
}
