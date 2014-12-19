using DreamsIT.Data.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class Sum : IKeyItem<int>
    {
        public int ID { get; set; }
        /// <summary>
        /// Сумма
        /// </summary>
        public double SumVal { get; set; }

        /// <summary>
        /// Сумма в валюте
        /// </summary>
        public double SumInCurrency { get; set; }
    }
}
