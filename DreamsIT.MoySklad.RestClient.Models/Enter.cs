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
    /// Модель оприходования 
    /// </summary>
    public class Enter : RecordOperation, IKeyItem<int>
    {
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid TargetAgentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid TargetSourceUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Applicable { get; set; }

        /// <summary>
        /// Время оприходования
        /// </summary>
        public string Moment { get; set; }

        /// <summary>
        /// Описание оприходования
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Сумма (цена) оприходования
        /// </summary>
        public Sum Price { get; set; }

        /// <summary>
        /// Список значений оприходования
        /// </summary>
        public List<EnterPosition> EnterPositions { get; set; }
    }
}
