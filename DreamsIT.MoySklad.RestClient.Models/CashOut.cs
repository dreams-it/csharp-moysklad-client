using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель кассовой выплаты
    /// </summary>
    public class CashOut : Payment, IKeyItem<int>
    {
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid SupplyUuid { get; set; }

    }
}
