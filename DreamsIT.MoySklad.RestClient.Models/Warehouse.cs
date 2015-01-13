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
    /// Модель складу (warehouse):
    /// </summary>
    public class Warehouse : IKeyItem<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Идентификатор компании
        /// </summary>
        public Guid AgentUuid { get; set; }

        /// <summary>
        /// Не активный ли склад
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ParentUuid { get; set; }

        /// <summary>
        /// Имя склада в системе
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновление
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя пользователя кто последний обновил запись
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
        /// Идентификатор склада
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ExternalCode { get; set; }

        /// <summary>
        /// Описание склада
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Контакти скада
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Slot> Slots { get; set; }
    }

    public class WarehouseColllection
    {
        public WarehouseColllection()
        {
            WarehouseList = new List<Warehouse>();
        }

        public List<Warehouse> WarehouseList { get; set; }
    }
}
