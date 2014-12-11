using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class PurchaseOrder : Order
    {
        /// <summary>
        /// Запланированная дата поставки
        /// </summary>
        public string DeliveryPlannedMoment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid TargetStoreUuid { get; set; }
            
        /// <summary>
        /// 
        /// </summary>
        public List<Guid> CustomerOrdersUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<InternalOrder> InternalOrders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> IncoicesUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> PaymentsUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PurchaseOrderPosition PurchaseOrderPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> SuppliesUuid { get; set; }
    }
}
