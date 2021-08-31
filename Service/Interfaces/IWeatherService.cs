using Domain.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IWeatherService
    {
        List<WeatherViewModel> GetWeathersList();
        
        Task<List<CityViewModel>> FindCity(string city);

        Task<CityViewModel> FindForecastWather(int id);
    }
}
