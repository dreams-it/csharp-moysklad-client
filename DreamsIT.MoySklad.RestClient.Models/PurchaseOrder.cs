using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class PurchaseOrder
    {
        /// <summary>
        /// Запланированная дата поставки
        /// </summary>
        public string DeliveryPlannedMoment { get; set; }

        /// <summary>
        /// Зарезервированная сума заказа
        /// </summary>
        public double ReservedSum { get; set; }

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
        /// Дата проведения платежа
        /// </summary>
        public string Moment { get; set; }

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
        public double Rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool VatIncluded { get; set; }

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Имя того, кто сделали запись заказа
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Идентификатор пользователя, который сделал запись заказа
        /// </summary>
        public Guid EmployeeUuid { get; set; }

        /// <summary>
        /// Название заказа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто делал последнее обновление
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ReadMode ReadMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ChangeMode ChangeMode { get; set; }

        /// <summary>
        /// Идентификатор пользователя, который создал запись
        /// </summary>
        public Guid AccountUuid { get; set; }

        /// <summary>
        /// Идентификатор профиля пользователя, который создал запись
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// Идентификатор записи заказу
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ExternalCode { get; set; }

        /// <summary>
        /// Сумма заказу
        /// </summary>
        public Sum Sum { get; set; }

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
