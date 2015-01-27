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
    /// Модель оприходования 
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "enter", IsNullable = false)]
    public partial class Enter : RecordOperation
    {
        public Enter()
        {
            EnterPositions = new List<EnterPosition>();
        }
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [XmlElement(ElementName="uuid")]
        public Guid Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "targetAgentUuid")]
        public Guid TargetAgentUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "targetStoreUuid")]
        public Guid TargetStoreUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "applicable")]
        public bool Applicable { get; set; }

        /// <summary>
        /// Время оприходования
        /// </summary>
        [XmlAttribute(AttributeName = "moment")]
        public string Moment { get; set; }

        /// <summary>
        /// Описание оприходования
        /// </summary>
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Сумма (цена) оприходования
        /// </summary>
        [XmlElement(ElementName = "sum")]
        public Sum Price { get; set; }

        /// <summary>
        /// Список значений оприходования
        /// </summary>
        [XmlElement(ElementName = "enterPosition")]
        public List<EnterPosition> EnterPositions { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public partial class EnterCollection
    {
        public EnterCollection()
        {
            Enters = new List<Enter>();
        }

        [XmlElement(ElementName = "enter")]
        public List<Enter> Enters { get; set; }
    }
}
