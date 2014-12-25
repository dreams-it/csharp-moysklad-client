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
    public class Requisite
    {
        /// <summary>
        /// Официальное название
        /// </summary>
        public string LegalTitle { get; set; }

        /// <summary>
        /// Официальный адрес
        /// </summary>
        public string LegalAddress { get; set; }

        /// <summary>
        /// Текущий адрес
        /// </summary>
        public string ActualAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long Inn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long Kpp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long Okpo { get; set; }
    }
}
