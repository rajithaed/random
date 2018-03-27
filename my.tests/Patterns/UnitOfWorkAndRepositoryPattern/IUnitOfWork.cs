using System;
using System.Collections.Generic;
using System.Text;
using my.tests.Patterns.UnitOfWorkAndRepositoryPattern.Entities;

namespace my.tests.Patterns.UnitOfWorkAndRepositoryPattern
{
    public interface IUnitOfWork
    {
        IRepository<Author> AuthorRepository { get; }
        IRepository<Book> BookRepository { get; }

        void Commit();
        void RejectChanges();
        void Dispose();
    }
}
