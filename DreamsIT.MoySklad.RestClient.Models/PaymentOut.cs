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
    /// Модель безналичной выплаты
    /// </summary>
    public class PaymentOut : Payment
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid TargetAccountUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid SourceAccountUuid { get; set; }
    }

    public class PaymentOutCollection
    {
        public PaymentOutCollection()
        {
            PaymentOutList = new List<PaymentOut>();
        }

        public List<PaymentOut> PaymentOutList { get; set; }
    }
}
