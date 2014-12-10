using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class Enter
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid TargetAgentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid TargetSourceUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Applicable { get; set; }

        /// <summary>
        /// Время оприходования
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
        public bool VatIncluded { get; set; }

        /// <summary>
        /// Дата создания записи оприходования
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Имя того, кто создал запись оприходования
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Имя записи оприходования
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
        /// Идентификатор пользователя, который создал запись
        /// </summary>
        public Guid AccountUuid { get; set; }

        /// <summary>
        /// Идентификатор профиля пользователя, который создал запись
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ReadMode ReadMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ChangeMode ChangeMode { get; set; }

        /// <summary>
        /// Идентификатор записи оприходования
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ExternalCode { get; set; }

        /// <summary>
        /// Описание оприходования
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Сумма (цена) оприходования
        /// </summary>
        public Price Price { get; set; }

        /// <summary>
        /// Список значений оприходования
        /// </summary>
        public List<EnterPosition> EnterPositions { get; set; }
    }
}
