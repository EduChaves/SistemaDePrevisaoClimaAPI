using HtmlParserSharp.Core;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Domain.Entities
{
    [Serializable, XmlRoot(ElementName = "cidades", Namespace = "", IsNullable = true)]
    public class Cities
    {
        [XmlElement(ElementName = "cidade")]
        public List<City> ListCities { get; set; }
    }
}
