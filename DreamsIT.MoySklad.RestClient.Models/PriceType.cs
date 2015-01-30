using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Цена розница с картой
    /// </summary>
    class PriceType
    {
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
        public Guid AccountUuid { get; set; }
        public Guid AccountId { get; set; }
        public Guid Uuid { get; set; }
    }
}
