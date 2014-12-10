using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class Demand
    {
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
        public Guid SourceStoreUuid { get; set; }

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
        /// Дата создания записи
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Имя того, кто создал запись
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Идентификатор работника кто создал запись
        /// </summary>
        public Guid EmployeeUuid { get; set; }

        /// <summary>
        /// Имя отгрузки товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления записи о товаре
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто последний обновил запись об отгрузке товара
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
        /// Идентификатор пользователя создавшего запись
        /// </summary>
        public Guid AccountUuid { get; set; }

        /// <summary>
        /// Идентификатор профиля пользователя, создал запись
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// Идентификатор записи о отгрузку товара
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ExternalCode { get; set; }

        /// <summary>
        /// Цена (сумма) за товар
        /// </summary>
        public Sum Sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> InvoicesOutUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> PaymentsUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ShipmentOut ShipmentOut { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Extension Extension { get; set; }

    }
}
