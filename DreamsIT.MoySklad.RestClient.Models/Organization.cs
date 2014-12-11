using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;

namespace DreamsIT.MoySklad.RestClient.Models
{
    class Organization
    {
        /// <summary>
        /// Тип компании
        /// </summary>
        public CompanyType CompanyType { get; set; }

        /// <summary>
        /// Скидка
        /// </summary>
        public double Discount { get; set; }

        public double AutoDiscount { get; set; }
        /// <summary>
        /// Коррекция скидки
        /// </summary>
        public double DiscountCorrection { get; set; }

        /// <summary>
        /// Не активный ли Organization
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// Дата создания в системе
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Название Organization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто делал последнее обновление
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
        /// Идентификатор 
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
        /// Описание 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Модель реквизитов 
        /// </summary>
        public Requisite Requisite { get; set; }

        /// <summary>
        /// Модель банкового счета
        /// </summary>
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// Контакты
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Tags> Tags { get; set; }



    }
}
