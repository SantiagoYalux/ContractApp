using ContractsApp.Repository.DBContext;
using ContractsApp.Repository.GenericInterfaces;
using System.Linq.Expressions;

namespace ContractsApp.Repository.GenericServices
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ContractcourseDbContext _dbContext;

        public GenericRepository(ContractcourseDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<T> Get(Expression<Func<T,bool>>? filter = null) 
        {
            IQueryable<T> Data = (filter == null) ? _dbContext.Set<T>() : _dbContext.Set<T>().Where(filter);
            return Data;
        }
    }
}
