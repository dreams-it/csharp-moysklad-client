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
    /// Модель остатка на складе - stockTO
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "stockTO", IsNullable = false)]
    public class StockTO:IKeyItem<Guid>
    {
        public StockTO()
        {
            GoodRefs = new List<GoodRef>();
        }

        [XmlIgnore]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        /// <summary>
        /// единицы измерения
        /// </summary>
        [XmlAttribute(AttributeName = "uomName")]
        public string UomName { get; set; }

        /// <summary>
        /// количество
        /// </summary>
        [XmlAttribute(AttributeName = "quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// количество зарезервированого
        /// </summary>
        [XmlAttribute(AttributeName = "reserve")]
        public double Reserve { get; set; }

        /// <summary>
        /// Количество единиц в доставке 
        /// </summary>
        [XmlAttribute(AttributeName = "inTransit")]
        public double InTransit { get; set; }

        /// <summary>
        /// количество единиц в доставке 
        /// </summary>
        [XmlAttribute(AttributeName = "stock")]
        public double Stock { get; set; }

        /// <summary>
        /// Общая сумма
        /// </summary>
        [XmlAttribute(AttributeName = "sumTotal")]
        public double SumTotal { get; set; }

        /// <summary>
        /// сумма продажи
        /// </summary>
        [XmlAttribute(AttributeName = "saleAmount")]
        public double SaleAmount { get; set; }

        /// <summary>
        /// минимальное возможное количество на складе
        /// </summary>
        [XmlAttribute(AttributeName = "minimumBalance")]
        public double MinimalBalance { get; set; }

        /// <summary>
        /// категория товара
        /// </summary>
        [XmlAttribute(AttributeName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "externalCode")]
        public string ExternalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "parentUuid")]
        public Guid ParentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "defaultConsignment")]
        public bool DefaultConsigment { get; set; }

        /// <summary>
        /// Цена продажи
        /// </summary>
        [XmlAttribute(AttributeName = "salePrice")]
        public double SalePrice { get; set; }

        /// <summary>
        /// Cписок товаров
        /// </summary>
        [XmlElement(ElementName = "goodRef")]
        public virtual List<GoodRef> GoodRefs { get; set; }

        [XmlAttribute(AttributeName = "productCode")]
        public string ProductCode { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class StockTOCollection
    {
        public StockTOCollection()
        {
            StockTOList = new List<StockTO>();
        }

        [XmlElement(ElementName = "stockTO")]
        public List<StockTO> StockTOList { get; set; }
    }
}
