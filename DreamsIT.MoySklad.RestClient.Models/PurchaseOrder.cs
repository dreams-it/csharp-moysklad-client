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
    /// Модель заказов поставщику
    /// </summary>
    public class PurchaseOrder : Order
    {
        public PurchaseOrder()
        {
            CustomerOrdersUuid = new List<Guid>();
            InternalOrders = new List<InternalOrder>();
            SuppliesUuid = new List<Guid>();
        }
        /// <summary>
        /// Идентификатор записи о заказе покупателя
        /// </summary>
        public Guid Uuid { get; set; }
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
        public virtual List<Guid> CustomerOrdersUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual List<InternalOrder> InternalOrders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual List<Guid> SuppliesUuid { get; set; }
    }
}