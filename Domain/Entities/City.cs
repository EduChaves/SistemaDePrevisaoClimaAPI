using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Domain.Entities
{
    [Serializable, XmlRoot(ElementName = "cidade")]
    public class City : IBaseEntity
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "nome")]
        public string Name { get; set; }

        [XmlElement(ElementName = "uf")]
        public string State { get; set; }

        [XmlElement(ElementName = "atualizacao")]
        public DateTime Update { get; set; }

        [XmlElement(ElementName = "previsao")]
        public List<Forecast> ListForecast { get; set; }
    }
}
