using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class Supply
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
        public Guid AccountId { get; set; }

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
        public bool VatIcluded { get; set; }

        /// <summary>
        /// Дата создания записи приема товара
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Имя того, кто создал запись о приеме товара
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Название приема товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления товара
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто проводил последнее обновление товара
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

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
        /// Идентификатор записи приема товару
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ExternalCode { get; set; }

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
