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
    /// Модель цена
    /// </summary>
    public class Price: IKeyItem<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PriceTypeUuid { get; set; }
        public double Value { get; set; }
        public ReadMode ReadMode { get; set; }
        public ChangeMode ChangeMode { get; set; }
        public Guid AccountUuid { get; set; }
        public Guid AccountId { get; set; }
        public Guid Uuid { get; set; }
    }
}
