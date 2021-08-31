using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Domain.ViewModel
{
    public class CityViewModel : IBaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string State { get; set; }

        public string Update { get; set; }

        public List<ForecastViewModel> ListForecast { get; set; }
    }
}
