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
    /// Модель категории товару
    /// </summary>
    public class GoodFolder : IKeyItem<Guid>
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Не активная ли категория
        /// </summary>
        public bool Archived { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// Дата последнего обновления категории
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///Дата последнего обновления категории
        /// </summary>
        public string Updated { get; set; }
        /// <summary>
        /// Имя того, кто последний обновил запись
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ReadMode ReadMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid ChangeMode { get; set; }
        /// <summary>
        /// Идентификатор пользователя создавшего запись
        /// </summary>
        public Guid AccountUuid { get; set; }
        /// <summary>
        /// Идентификатор профиля пользователя, создал запись
        /// </summary>
        public Guid AccountId { get; set; }
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Externalcode { get; set; }
    }
}
