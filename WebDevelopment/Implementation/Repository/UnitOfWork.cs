using WebDevelopment.Contract.Repository;
using WebDevelopment.Models.Context;

namespace WebDevelopment.Implementation.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
