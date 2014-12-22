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
    /// Модель работника (employee):
    /// </summary>
    public class Employee : IKeyItem<int>
    {
        public int Id { get; set; }
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
        public Guid Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ExternalCode { get; set; }

        /// <summary>
        /// Описание работника
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Активный ли пользователь
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// Ел. Почта работника
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Имя работника
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия работника
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество работника
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Телефон работника
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Идентификатор работника
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// Имя работника в системе
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления информации об работнике
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто обновил информацию о пользователе
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
    }
}
