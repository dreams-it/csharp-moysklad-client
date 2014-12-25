using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель розничной торговли
    /// </summary>
    public class RetailDemand : IKeyItem<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Идентификатор контрагента
        /// </summary>
        public Guid TargetAgentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid RetailStoreUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid SourceAgentUuid { get; set; }

        /// <summary>
        /// Идентификатор складу з которого выгружают товар
        /// </summary>
        public Guid SourceStoreUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Applicable { get; set; }

        /// <summary>
        /// Время проведения торговли
        /// </summary>
        public string Moment { get; set; }

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
        public bool vatIncluded { get; set; }

        /// <summary>
        /// Дата создания записи розничной торговли
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Имя того, кто создал запись розничной торговли
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Имя записи розничной торговли
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления записи
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто последний обновлял запись
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Идентификатор пользователя создавшего запись
        /// </summary>
        public Guid AccountUuid { get; set; }

        /// <summary>
        /// Идентификатор профиля пользователя, создал запись
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// Идентификатор записи розничной торговли
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ExternalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Sum Sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<LossPosition> LossPositions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ChangeMode ChangeMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ReadMode ReadMode { get; set; }
    }
}
