using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель точки продажу
    /// </summary>
    public class RetailStore : IKeyItem<int>
    {
        public int ID { get; set; }
        /// <summary>
        /// Активная ли точка продажа
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Адреса точки продажу
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Идентификатор юр.лица
        /// </summary>
        public Guid myCompanyUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid priceTypeUuid { get; set; }

        /// <summary>
        /// Идентификатор склада
        /// </summary>
        public Guid warehouseUuid { get; set; }

        /// <summary>
        /// Имя точки продажу
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто последний раз делал обновление
        /// </summary>
        public string updatedBy { get; set; }

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
        public Guid accountUuid { get; set; }

        /// <summary>
        /// Идентификатор профиля пользователя, который создал запись
        /// </summary>
        public Guid accountId { get; set; }

        /// <summary>
        /// Идентификатор точки продажу
        /// </summary>
        public Guid uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Externalcode { get; set; }

        /// <summary>
        /// Описание
        /// </summary>       
        public string description { get; set; }
        

    }
}
