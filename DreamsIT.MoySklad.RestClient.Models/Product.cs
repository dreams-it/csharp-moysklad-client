using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;

namespace DreamsIT.MoySklad.RestClient.Models
{
   public class Product
    {

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
        /// Дата создания записи 
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Имя того, кто создал запись
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Название 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления товара
        /// </summary>
        public string Updated { get; set; }
        /// <summary>
        /// Имя того, кто последний обновлял запись
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
        /// Идентификатор записи
        /// </summary>
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ExternalCode { get; set; }

    }
}
