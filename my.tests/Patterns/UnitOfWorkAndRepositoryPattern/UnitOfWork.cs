using System.Data.Entity;
using System.Linq;
using my.tests.Patterns.UnitOfWorkAndRepositoryPattern.Entities;

namespace my.tests.Patterns.UnitOfWorkAndRepositoryPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbcOntext _dbContext;

        public UnitOfWork(MyDbcOntext context)
        {
            _dbContext = context;
        }
        public IRepository<Author> AuthorRepository => new Repository<Author>(_dbContext);
        public IRepository<Book> BookRepository => new Repository<Book>(_dbContext);
        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void RejectChanges()
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries()
                .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}