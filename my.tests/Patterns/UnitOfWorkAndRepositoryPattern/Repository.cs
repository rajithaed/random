using System;
using System.Data.Entity;
using System.Linq;

namespace my.tests.Patterns.UnitOfWorkAndRepositoryPattern
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MyDbcOntext _dbContext;

        public Repository(MyDbcOntext context)
        {
            _dbContext = context;
        }

        private IDbSet<T> DbSet => _dbContext.Set<T>();

        public IQueryable<T> Entities => DbSet;

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }
    }
}