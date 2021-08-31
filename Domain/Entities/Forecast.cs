using System;
using System.Xml.Serialization;

namespace Domain.Entities
{
    [Serializable, XmlRoot(ElementName = "previsao", IsNullable = true)]
    public class Forecast
    {
        [XmlElement(ElementName = "dia")]
        public DateTime Day { get; set; }

        [XmlElement(ElementName = "tempo")]
        public string WeatherIni { get; set; }

        public Weather WeatherObj { get; set; }

        [XmlElement(ElementName = "maxima")]
        public int MaxTemperature { get; set; }

        [XmlElement(ElementName = "minima")]
        public int MinTemperature { get; set; }
    }
}
