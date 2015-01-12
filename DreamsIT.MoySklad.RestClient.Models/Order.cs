using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;

namespace DreamsIT.MoySklad.RestClient.Models
{

    public class Order:IKeyItem<Guid>
    {

        public Guid Id { get; set; }
        /// <summary>
        /// Зарезервирована сумма (ожидаемая)
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
        public bool Applicable { get; set; }

        /// <summary>
        /// Дата заказа покупателя
        /// </summary>
        public string Moment { get; set; }

        /// <summary>
        /// идентификатор покупателя
        /// </summary>
        public Guid TargetAccountUuid { get; set; }

        /// <summary>
        /// Идентификатор продавца (тот, кто отдает товар)
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
        /// Дата создания
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Имя того, кто создал запись
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Идентификатор работника, который сделал запись
        /// </summary>
        public Guid EmployeeUuid { get; set; }

        /// <summary>
        /// Название заказа покупателя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления информации о заказе покупателя (запись)
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто последний обновлял информацию о заказе покупателя (запись)
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
        public List<Guid> IncoicesUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> PaymentsUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PurchaseOrderPosition PurchaseOrderPosition { get; set; }
    }
}
