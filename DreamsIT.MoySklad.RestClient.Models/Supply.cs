using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель класса приема 
    /// </summary>
    public class Supply : Product
    {
        /// <summary>
        /// Номер приема товара
        /// </summary>
        public int? IncomingNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public OverheadDistribution OverheadDistribution { get; set; }

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
        public Guid TargetStoreUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Applicable { get; set; }

        /// <summary>
        /// Дата приема товара
        /// </summary>
        public string Moment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid TargetAccountUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid SourceAccountId { get; set; }

        /// <summary>
        /// Сумма приема товара
        /// </summary>
        public Sum Sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> IncoicesInUuid { get; set; }

        /// <summary>
        /// Накладные расходы
        /// </summary>
        public Price Overhead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> PaymentsUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ShipmentIn ShipmentIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> PurchaseReturnsUuid { get; set; }
    }
}
