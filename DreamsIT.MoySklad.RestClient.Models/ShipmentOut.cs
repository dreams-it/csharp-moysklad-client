using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class ShipmentOut : IKeyItem<int>
    {
        public int ID { get; set; }
        /// <summary>
        /// Скидка
        /// </summary>
        public double Discount { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// Идентификатор партии (накладной)
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
    }
}
