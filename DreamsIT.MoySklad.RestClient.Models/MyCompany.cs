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
    /// Юр. лицо
    /// </summary>
    public class MyCompany : Organization
    {
        /// <summary>
        /// Идентификатор 
        /// </summary>
        public Guid Uuid { get; set; }

        public string Director { get; set; }

        /// <summary>
        /// Имя главного бухгалтера
        /// </summary>
        public string ChiefAccountant { get; set; }
    }

    public class MyCompanyCollection
    {
        public List<MyCompany> MyCompanies { get; set; }
    }
}
