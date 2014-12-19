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
    /// Модель отгрузки товара
    /// </summary>
    public class Demand: RecordOperation, IKeyItem<int>
    {
        public int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid TargetAgentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid SourceAgentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid SourceStoreUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid TargetAccountUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid SourceAccountUuid { get; set; }
        
        /// <summary>
        /// Цена (сумма) за товар
        /// </summary>
        public Sum Sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> InvoicesOutUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> PaymentsUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ShipmentOut ShipmentOut { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Extension Extension { get; set; }

    }
}
