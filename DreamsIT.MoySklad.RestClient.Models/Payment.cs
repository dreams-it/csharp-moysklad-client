using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;
using System.ComponentModel.DataAnnotations;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class Payment: IKeyItem<Guid>
    {
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid ExpenseItemUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PaymentPurpose { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid TargetAgentUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid SourceAgentUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Applicable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Moment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool PayerVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Double Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool VatIncluded { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Created { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Updated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String UpdatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ReadMode ReadMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ChangeMode ChangeMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid AccountUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid AccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Externalcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Sum Sum { get; set; }
    }
}
