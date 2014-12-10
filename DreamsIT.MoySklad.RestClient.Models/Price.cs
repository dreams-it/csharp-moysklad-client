using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class Price
    {
        /// <summary>
        /// Сумма (цена)
        /// </summary>
        public double Sum { get; set; }

        /// <summary>
        /// Сумма в валюте
        /// </summary>
        public double SumInCurrency { get; set; }
    }
}
