using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель кассовой выплаты
    /// </summary>
    public class CashOut : Payment
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "expenseItemUuid")]
        public Guid ExpenseItemUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName="uuid")]
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName= "supplyUuid")]
        public Guid SupplyUuid { get; set; }

    }
}
