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

    public class Order:IKeyItem<Guid>
    {
        [XmlIgnore]
        public Guid Id { get; set; }
        /// <summary>
        /// Зарезервирована сумма (ожидаемая)
        /// </summary>
        [XmlAttribute(AttributeName = "reservedSum")]
        public double ReservedSum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "targetAgentUuid")]
        public Guid TargetAgentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "sourceAgentUuid")]
        public Guid SourceAgentUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "applicable")]
        public bool Applicable { get; set; }

        /// <summary>
        /// Дата заказа покупателя
        /// </summary>
        [XmlAttribute(AttributeName = "moment")]
        public string Moment { get; set; }

        /// <summary>
        /// идентификатор покупателя
        /// </summary>
        [XmlAttribute(AttributeName = "targetAccountUuid")]
        public Guid TargetAccountUuid { get; set; }

        /// <summary>
        /// Идентификатор продавца (тот, кто отдает товар)
        /// </summary>
        [XmlAttribute(AttributeName = "sourceAccountUuid")]
        public Guid SourceAccountUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "payerVat")]
        public bool PayerVat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "rate")]
        public double Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "vatIncluded")]
        public bool VatIncluded { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        [XmlAttribute(AttributeName = "created")]
        public string Created { get; set; }

        /// <summary>
        /// Имя того, кто создал запись
        /// </summary>
        [XmlAttribute(AttributeName = "createdBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Идентификатор работника, который сделал запись
        /// </summary>
        [XmlAttribute(AttributeName = "employeeUuid")]
        public Guid EmployeeUuid { get; set; }

        /// <summary>
        /// Название заказа покупателя
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Дата последнего обновления информации о заказе покупателя (запись)
        /// </summary>
        [XmlAttribute(AttributeName = "updated")]
        public string Updated { get; set; }

        /// <summary>
        /// Имя того, кто последний обновлял информацию о заказе покупателя (запись)
        /// </summary>
        [XmlAttribute(AttributeName = "updatedBy")]
        public string UpdatedBy { get; set; }
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

        /// <summary>
        /// Идентификатор пользователя создавшего запись
        /// </summary>
        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }

        /// <summary>
        /// Идентификатор профиля пользователя, создал запись
        /// </summary>
        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "externalcode")]
        public string ExternalCode { get; set; }

        /// <summary>
        /// Сумма заказу
        /// </summary>
        [XmlElement(ElementName = "sum")]
        public Sum Sum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "invoicesOutUuid")]
        public List<Guid> InvoicesUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "paymentsUuid")]
        public List<Guid> PaymentsUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "customerOrderPosition")]
        public List<PurchaseOrderPosition> PurchaseOrderPosition { get; set; }
    }
}
