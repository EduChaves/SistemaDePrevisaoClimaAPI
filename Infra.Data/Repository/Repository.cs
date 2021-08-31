using Infra.Data.Contexts;
using Infra.Data.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly Context _context;

        public Repository(Context context) => _context = context;

        public IQueryable<TEntity> TakeWeatherOnDatabsa()
        {
            try
            {
                return _context.Set<TEntity>();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
