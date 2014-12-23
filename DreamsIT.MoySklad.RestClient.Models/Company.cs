using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Контрагент
    /// </summary>
    public class Company : Organization, IKeyItem<int>
    {
        public int Id { get; set; }
        public bool PayerVat { get; set; }
    }
}
