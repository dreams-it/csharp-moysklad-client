using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель позиции списания 
    /// </summary>
   public class LossPosition
    {
       public double Discount { get; set; }
       public double Quantity { get; set; }
       public Guid ConsignmentUuid { get; set; }
       public Guid GoodUuid { get; set; }
       public int Vat { get; set; }
       public ReadMode ReadMode { get; set; }
       public ChangeMode ChangeMode { get; set; }
       public Guid AccountUuid { get; set; }
       public Guid AccountId { get; set; }
       public Guid Uuid { get; set; }
       public Sum BasePrice { get; set; }
       public Sum Price { get; set; }
       public Things Things { get; set; }
       public Tags Tags { get; set; }
       
    }
}
