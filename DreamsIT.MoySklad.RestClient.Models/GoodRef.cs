using DreamsIT.Data.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class GoodRef : IKeyItem<Guid>
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Идентификатор ссылки на объект класса Type (идентификатор товара для типа Good)
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// Название экземпляру класса Type (для товара - название товара)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип класса Type
        /// </summary>
        public string ObjectType { get; set; }
    }
}
