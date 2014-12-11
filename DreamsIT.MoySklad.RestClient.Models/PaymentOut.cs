using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель безналичной выплаты
    /// </summary>
    class PaymentOut : Payment
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid TargetAccountUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid SourceAccountUuid { get; set; }
    }
}
