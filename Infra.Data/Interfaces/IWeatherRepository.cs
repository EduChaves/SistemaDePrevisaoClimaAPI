using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Data.Interfaces
{
    public interface IWeatherRepository : IRepository<Weather> 
    {
        Weather GetWeatherOnDatabsa(string initial);
    }
}
