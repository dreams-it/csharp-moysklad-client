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
    /// Модель заказ покупателя 
    /// </summary>
    public class CustomerOrder : Order, IKeyItem<int>
    {

        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid SourceStoreUuid { get; set; }
                
        /// <summary>
        /// 
        /// </summary>
        public bool VatIncluded { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// Имя того, кто создал запись
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Идентификатор работника, который сделал запись
        /// </summary>
        public Guid EmployeeUuid { get; set; }

        /// <summary>
        /// Название заказа покупателя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления информации о заказе покупателя (запись)
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто последний обновлял информацию о заказе покупателя (запись)
        /// </summary>
        public string UpdatedBy { get; set; }
                
        /// <summary>
        /// 
        /// </summary>
        public List<Guid> DemandsUuid { get; set; }
                
        /// <summary>
        /// 
        /// </summary>
        public List<Guid> PurchaseOrdersUuid { get; set; }
    }
}
