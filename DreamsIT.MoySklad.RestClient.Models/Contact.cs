using DreamsIT.Data.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class Contact : IKeyItem<int>
    {
        public int Id { get; set; }
        /// <summary>
        /// Адреса
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phones { get; set; }

        /// <summary>
        /// Факс
        /// </summary>
        public string Faxes { get; set; }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string Mobiles { get; set; }

        /// <summary>
        /// Ел. Почта
        /// </summary>
        public string Email { get; set; }
    }
}
