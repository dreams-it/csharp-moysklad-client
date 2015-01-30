using DreamsIT.Data.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель записи остатка на складе
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "goodRef", IsNullable = false)]
    public class GoodRef : IKeyItem<Guid>
    {
        [XmlIgnore]
        public Guid Id { get; set; }
        /// <summary>
        /// Идентификатор ссылки на объект класса Type (идентификатор товара для типа Good)
        /// </summary>
        [XmlAttribute(AttributeName = "uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Название экземпляру класса Type (для товара - название товара)
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Тип класса Type
        /// </summary>
        [XmlAttribute(AttributeName = "objectType")]
        public string ObjectType { get; set; }

        public string Code { get; set; }
    }
}
