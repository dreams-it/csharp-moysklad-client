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

    public class ShipmentIn:IKeyItem<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Uuid { get; set; }

        public double OverHead { get; set; }

        public double Discount { get; set; }

        public double Quantity { get; set; }

        public Guid ConsigmentUuid { get; set; }

        public Guid GoodUuid { get; set; }

        public int Vat { get; set; }

        public ReadMode ReadMode { get; set; }

        public ChangeMode ChangeMode { get; set; }

        public Guid AccountUuid { get; set; }

        public Guid AccountId { get; set; }

        public Sum BasePrice { get; set; }

        public Sum Price { get; set; }

        public Things Things { get; set; }
    }
}
