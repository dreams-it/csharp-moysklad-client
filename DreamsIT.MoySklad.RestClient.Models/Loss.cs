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
    /// Модель списания 
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "loss", IsNullable = false)]
    public class Loss : RecordOperation
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [XmlElement(ElementName="uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [XmlAttribute(AttributeName = "sourceAgentUuid")]
        public Guid SourceAgentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "sourceStoreUuid")]
        public Guid SourceStoreUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "applicable")]
        public bool Applicable { get; set; }

        /// <summary>
        /// Время списания
        /// </summary>
        [XmlAttribute(AttributeName = "moment")]
        public string Moment { get; set; }
          
        /// <summary>
        /// Сумма (цена) списания
        /// </summary>
        [XmlElement(ElementName = "sum")]
        public Sum Sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlArray(ElementName = "lossPosition")]
        public List<LossPosition> LossPositions { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class LossCollection
    {
        public LossCollection()
        {
            LossList = new List<Loss>();
        }

        [XmlElement(ElementName = "loss")]
        public List<Loss> LossList { get; set; }
    }
}
