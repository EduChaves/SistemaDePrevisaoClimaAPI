using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IWeatherForecastAdapter
    {
        List<CityViewModel> ConvertCityListToViewModel(List<City> cities);
        
        CityViewModel ConvertCityToViewModel(City city);

        List<ForecastViewModel> ConvertForecastToViewModel(List<Forecast> forecasts);
    }
}
