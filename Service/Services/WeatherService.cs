using Domain.Entities;
using Domain.ViewModel;
using Infra.CrossCutting.APIs;
using Infra.Data.Interfaces;
using Service.Adapter;
using Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;
        private WeatherForecastAdapter _adapter;

        public WeatherService(IWeatherRepository weatherRepository) => _weatherRepository = weatherRepository;

        public List<WeatherViewModel> GetWeathersList()
        {
            List<WeatherViewModel> viewModelList = new List<WeatherViewModel>();

            var listWeather = _weatherRepository.TakeWeatherOnDatabsa();
            foreach (var element in listWeather)
            {
                var weather = new WeatherViewModel { Initials = element.Initials, Description = element.Description };
                viewModelList.Add(weather);
            }

            return viewModelList;
        }

        public Weather GetWeather(string initial)
        {
            return _weatherRepository.GetWeatherOnDatabsa(initial);
        }

        public async Task<List<CityViewModel>> FindCity(string city)
        {
            _adapter = new WeatherForecastAdapter();

            var cities = await ConsultingImpeApi.GetCities(city);
            var result = cities.ListCities;

            return _adapter.ConvertCityListToViewModel(result);
        }

        public async Task<CityViewModel> FindForecastWather(int id)
        {
            _adapter = new WeatherForecastAdapter();
            var city = await ConsultingImpeApi.GetForecastWeather(id);
            var result = _adapter.ConvertCityToViewModel(city);

            result.ListForecast.ForEach(value => { value.WeatherObj = GetWeather(value.WeatherIni); });

            return result;
        }
    }

}