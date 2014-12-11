using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель безналичного прихода 
    /// </summary>
    class PaymentIn
    {
        public Guid incomingNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String paymentPurpose { get; set; }
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
        public Guid TargetAccountUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid SourceAccountUuid { get; set; }
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
        public String AccountUuid { get; set; }
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
        public Guid AccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Externalcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Sum Sum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Guid> DemandsUuid { get; set; }
        


    }
}
