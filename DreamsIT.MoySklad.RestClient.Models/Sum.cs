using DreamsIT.Data.BaseTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    [ComplexType]
    public class Sum
    {
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
