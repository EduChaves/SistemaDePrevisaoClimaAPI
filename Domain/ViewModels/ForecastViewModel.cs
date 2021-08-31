using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Xml.Serialization;

namespace Domain.ViewModel
{
    public class ForecastViewModel
    {
        public string Day { get; set; }

        public string WeatherIni { get; set; }

        public Weather WeatherObj { get; set; }

        public int? MaxTemperature { get; set; }

        public int? MinTemperature { get; set; }
    }
}
