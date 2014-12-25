using DreamsIT.Data.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// stockTO - модель залишку на складі
    /// </summary>
    public class StockTO:IKeyItem<Guid>
    {
        public Guid Id { get; set; }
        /// <summary>
        /// единицы измерения
        /// </summary>
        public string UomName { get; set; }

        /// <summary>
        /// количество
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// количество зарезервированого
        /// </summary>
        public double Reserve { get; set; }

        /// <summary>
        /// Количество единиц в доставке 
        /// </summary>
        public double InTransit { get; set; }

        /// <summary>
        /// количество единиц в доставке 
        /// </summary>
        public double Stock { get; set; }

        /// <summary>
        /// Общая сумма
        /// </summary>
        public double SumTotal { get; set; }

        /// <summary>
        /// сумма продажи
        /// </summary>
        public double SaleAmount { get; set; }

        /// <summary>
        /// минимальное возможное количество на складе
        /// </summary>
        public double MinimalBalance { get; set; }

        /// <summary>
        /// категория товара
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ExternalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid ParentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool DefaultConsigment { get; set; }

        /// <summary>
        /// Цена продажи
        /// </summary>
        public double SalePrice { get; set; }

        /// <summary>
        /// список товаров
        /// </summary>
        public List<GoodRef> GoodRefs { get; set; }
    }
}
