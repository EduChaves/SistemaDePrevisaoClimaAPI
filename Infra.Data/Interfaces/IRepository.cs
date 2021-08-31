using System.Linq;

namespace Infra.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity: class
    {
        IQueryable<TEntity> TakeWeatherOnDatabsa();
    }
}
