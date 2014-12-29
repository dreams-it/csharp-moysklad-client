using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;
using System.ComponentModel.DataAnnotations;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель точки продажу
    /// </summary>
    public class RetailStore : IKeyItem<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Активная ли точка продажа
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Адреса точки продажу
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Идентификатор юр.лица
        /// </summary>
        public Guid MyCompanyUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid PriceTypeUuid { get; set; }

        /// <summary>
        /// Идентификатор склада
        /// </summary>
        public Guid WarehouseUuid { get; set; }

        /// <summary>
        /// Имя точки продажу
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто последний раз делал обновление
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
        /// Идентификатор профиля пользователя, который создал запись
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// Идентификатор точки продажу
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Externalcode { get; set; }

        /// <summary>
        /// Описание
        /// </summary>       
        public string Description { get; set; }
        

    }
}
