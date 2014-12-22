using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class GoodFolder : IKeyItem<int>
    {
      public int Id { get; set; }
      /// <summary>
      /// Не активная ли категория
      /// </summary>
        public bool archived { get; set; }
        /// <summary>
        /// 
        /// </summary>
      public string productCode { get; set; }
      /// <summary>
      /// Дата последнего обновления категории
      /// </summary>
      public string name { get; set; }
      /// <summary>
      ///Дата последнего обновления категории
      /// </summary>
      public string updated { get; set; }
      /// <summary>
      /// Имя того, кто последний обновил запись
      /// </summary>
      public string updatedBy { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public ReadMode ReadMode { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public Guid changeMode { get; set; }
      /// <summary>
      /// Идентификатор пользователя создавшего запись
      /// </summary>
      public Guid accountUuid { get; set; }
      /// <summary>
      /// Идентификатор профиля пользователя, создал запись
      /// </summary>
      public Guid accountId { get; set; }
      /// <summary>
      /// Идентификатор категории
      /// </summary>
      public Guid uuid { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public String externalcode { get; set; }
    }
}
