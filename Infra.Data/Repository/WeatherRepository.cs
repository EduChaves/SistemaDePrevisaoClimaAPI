using Domain.Entities;
using Infra.Data.Contexts;
using Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class WeatherRepository : Repository<Weather>, IWeatherRepository
    {
        private readonly Context _context;
        public WeatherRepository(Context context) : base(context) => _context = context;

        public Weather GetWeatherOnDatabsa(string initial)
        {
            var result = _context.Weathers.Where(value => value.Initials.Contains(initial)).First();
            return result;
        }

    }
}
