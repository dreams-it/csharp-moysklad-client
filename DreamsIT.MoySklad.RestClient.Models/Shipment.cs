﻿using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    public class Shipment
    {
        [XmlAttribute(AttributeName = "discount")]
        public double Discount { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public double Quantity { get; set; }

        [XmlAttribute(AttributeName = "consignmentUuid")]
        public Guid ConsigmentUuid { get; set; }

        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }

        [XmlAttribute(AttributeName = "goodUuid")]
        public Guid GoodUuid { get; set; }

        [XmlAttribute(AttributeName = "vat")]
        public int Vat { get; set; }

        [XmlAttribute(AttributeName = "readMode")]
        public ReadMode ReadMode { get; set; }

        [XmlAttribute(AttributeName = "changeMode")]
        public ChangeMode ChangeMode { get; set; }

        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }

        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }

        [XmlElement(ElementName = "basePrice")]
        public Sum BasePrice { get; set; }

        [XmlElement(ElementName = "price")]
        public Sum Price { get; set; }

        [XmlElement(ElementName = "things")]
        public Things Things { get; set; }
    }
}
