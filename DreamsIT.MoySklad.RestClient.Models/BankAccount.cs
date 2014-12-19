using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class BankAccount:IKeyItem<int>
    {
        public int ID { get; set; }
        /// <summary>
        /// Номер счета
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Положение банка
        /// </summary>
        public string BankLocation { get; set; }

        /// <summary>
        /// Название банка
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Bic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CorrectspondentAccount { get; set; }

        /// <summary>
        /// Банк по умолчанию
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто делал обновление
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
