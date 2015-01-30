using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using DreamsIT.Data.BaseTypes;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class Payment : IKeyItem<Guid>
    {
        [Key]
        [XmlIgnore]
        public Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "paymentPurpose")]
        public string PaymentPurpose { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "vatSum")]
        public double VatSum { get; set; }
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
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "moment")]
        public String Moment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "payerVat")]
        public bool PayerVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "rate")]
        public Double Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "vatIncluded")]
        public bool VatIncluded { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "created")]
        public String Created { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "createdBy")]
        public String CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public String Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "updated")]
        public string Updated { get; set; }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "externalcode")]
        public string Externalcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "sum")]
        public Sum Sum { get; set; }
    }
}
