using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class PurchaseOrderPosition : IKeyItem<int>
    {
        public int Id { get; set; }
        /// <summary>
        /// Скидка
        /// </summary>
        public double Discount { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid ConsigmentUuid { get; set; }

        /// <summary>
        /// Идентификатор товара
        /// </summary>
        public Guid GoodUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Vat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ReadMode ReadMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ChangeMode ChangeMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid AccountUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// Идентификатор модели (позиции заказу)
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// Цена без скидки
        /// </summary>
        public Sum BasePrice { get; set; }

        /// <summary>
        /// Цена со скидкой
        /// </summary>
        public Sum Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Things> Thinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double Reserve { get; set; }
    }
}
