using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class CustomerOrderPosition
    {
        /// <summary>
        /// скидка
        /// </summary>
        public double Discount { get; set; }

        /// <summary>
        /// количество
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// Идентификатор партии (накладной)
        /// </summary>
        public Guid ConsigmentUuid { get; set; }

        /// <summary>
        /// идентификатор товара
        /// </summary>
        public Guid GoodUuid { get; set; }

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
        /// идентификатор записи
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// Базовая цена
        /// </summary>
        public Price BasePrice { get; set; }

        /// <summary>
        /// Конечная цена
        /// </summary>
        public Price Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Things> Thinkgs { get; set; }

        /// <summary>
        /// резерв
        /// </summary>
        public double Reserve { get; set; }
    }
}
