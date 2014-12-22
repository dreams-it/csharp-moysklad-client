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
    /// Модель списания 
    /// </summary>
    public class Loss : RecordOperation, IKeyItem<int>
    {
        public int Id { get; set; }
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
        public bool Applicable { get; set; }

        /// <summary>
        /// Время списания
        /// </summary>
        public string Moment { get; set; }
          
        /// <summary>
        /// Сумма (цена) списания
        /// </summary>
        public Sum Sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<LossPosition> LossPositions { get; set; }
    }
}
