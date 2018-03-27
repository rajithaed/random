using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using my.tests.Patterns.UnitOfWorkAndRepositoryPattern.Entities;

namespace my.tests.Patterns.UnitOfWorkAndRepositoryPattern
{
    public class MyDbcOntext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public MyDbcOntext(string connStr):base(connStr)
        {
            
        }
    }
}
