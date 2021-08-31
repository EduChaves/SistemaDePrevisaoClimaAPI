using Domain.Entities;
using Domain.ViewModel;
using Infra.Data.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Adapter
{
    public class WeatherForecastAdapter : IWeatherForecastAdapter
    {
        private readonly IWeatherRepository _weatherRepository;

        public WeatherForecastAdapter() { }

        public WeatherForecastAdapter(IWeatherRepository weatherRepository) => _weatherRepository = weatherRepository;

        public List<CityViewModel> ConvertCityListToViewModel(List<City> cities)
        {
            List<CityViewModel> list = new List<CityViewModel>();

            cities.ForEach(data =>
            {
                var result = ConvertCityToViewModel(data);
                list.Add(result);
            });
            return list;
        }

        public CityViewModel ConvertCityToViewModel(City city) => new CityViewModel
        {
            Id = city.Id,
            Name = city.Name,
            State = city.State,
            Update = city.Update.ToString("dd/MM/yyyy"),
            ListForecast = ConvertForecastToViewModel(city.ListForecast)
        };

        public List<ForecastViewModel> ConvertForecastToViewModel(List<Forecast> forecasts)
        {
            List<ForecastViewModel> viewModelList = new List<ForecastViewModel>();

            forecasts.ForEach(forecast =>
            {
                var viewModel = new ForecastViewModel
                {
                    Day = forecast.Day.ToString("dd/MM/yyyy"),
                    WeatherIni = forecast.WeatherIni,
                    MaxTemperature = forecast.MaxTemperature,
                    MinTemperature = forecast.MinTemperature
                };
                viewModelList.Add(viewModel);
            });
            return viewModelList;
        }
    }
}
