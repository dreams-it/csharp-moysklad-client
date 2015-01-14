using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    /// <summary>
    /// Модель работника:
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "employee", IsNullable = false)]
    public class Employee : IKeyItem<Guid>
    {
        [XmlIgnore]
        public Guid Id { get; set; }
        /// <summary>
        /// Идентификатор пользователя, который создал запись
        /// </summary>
        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }

        /// <summary>
        /// Идентификатор профиля пользователя, который создал запись
        /// </summary>
        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }

        /// <summary>
        /// Идентификатор работника
        /// </summary>
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "externalcode")]
        public string ExternalCode { get; set; }

        /// <summary>
        /// Описание работника
        /// </summary>
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Активный ли пользователь
        /// </summary>
        [XmlAttribute(AttributeName = "archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// Ел. Почта работника
        /// </summary>
        [XmlAttribute(AttributeName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Имя работника
        /// </summary>
        [XmlAttribute(AttributeName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия работника
        /// </summary>
        [XmlAttribute(AttributeName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Отчество работника
        /// </summary>
        [XmlAttribute(AttributeName = "middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Телефон работника
        /// </summary>
        [XmlAttribute(AttributeName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Идентификатор работника
        /// </summary>
        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Имя работника в системе
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления информации об работнике
        /// </summary>
        [XmlAttribute(AttributeName = "updated")]
        public  DateTime updated { get; set; }

        /// <summary>
        /// Имя того, кто обновил информацию о пользователе
        /// </summary>
        [XmlAttribute(AttributeName = "updatedBy")]
        public  DateTime updatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "readMode")]
        public ReadMode ReadMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "changeMode")]
        public ChangeMode ChangeMode { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class EmployeeCollection
    {
        public EmployeeCollection()
        {
            EmployeesList = new List<Employee>();
        }

        public List<Employee> EmployeesList { get; set; }
    }
}
