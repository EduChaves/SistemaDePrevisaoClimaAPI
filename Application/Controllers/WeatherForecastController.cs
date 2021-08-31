using Domain.Entities;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(IWeatherService weatherService) => _weatherService = weatherService;

        [HttpGet("TakeWeather")]
        public async Task<ActionResult<IEnumerable<WeatherViewModel>>> TakeWeather() => await Task.Run(() => _weatherService.GetWeathersList());

        [HttpGet("TakeCities/{city}")]
        public async Task<ActionResult<List<CityViewModel>>> TakeCities(string city)
        {
            var result = await _weatherService.FindCity(city);

            return result;
        }

        [HttpGet("TakeForecastWeather/{id}")]
        public async Task<ActionResult<CityViewModel>> TakeForecastWeather(int id)
        {
            var result = await _weatherService.FindForecastWather(id);

            return result;
        }
    }
}
