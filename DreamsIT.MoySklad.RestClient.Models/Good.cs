using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class Good : IKeyItem<Guid>
    {
        public Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsSerialTrackable { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public Double BuyPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public Double Weight { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public Double Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public Double MinPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public Guid UomUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public Double SalePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public bool Archived { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public Guid ParentUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public String ProductCode { get; set; }
        /// <summary>
        ///  Имя продукта
        /// </summary>
       
        public String Name { get; set; }
        /// <summary>
        /// Дата последнего обновления записи
        /// </summary>
       
        public String Updated { get; set; }
        /// <summary>
        /// Имя того, кто делал последнеее обновление
        /// </summary>
       
        public String UpdatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public ReadMode ReadMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public ChangeMode ChangeMode { get; set; }
        /// <summary>
        /// Идентификатор пользователя создавшего запись
        /// </summary>
       
        public Guid AccountUuid { get; set; }
        /// <summary>
        /// Идентификатор профиля пользователя, создал запись
        /// </summary>
       
        /// <summary>
        /// 
        /// </summary>
       
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public String Code { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
       
        public String Externalcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public String Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public List<Price> SalePrices { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public Preferences Preferences { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public Images Images { get; set; }
        

    }
}
