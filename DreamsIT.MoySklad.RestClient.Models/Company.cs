using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Контрагент
    /// </summary>
    public class Company : Organization
    {
        /// <summary>
        /// Идентификатор 
        /// </summary>
        public Guid Uuid { get; set; }

        public bool PayerVat { get; set; }
    }
}
