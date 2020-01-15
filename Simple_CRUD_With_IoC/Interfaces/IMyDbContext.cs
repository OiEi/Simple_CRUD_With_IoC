using Simple_CRUD_With_IoC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Simple_CRUD_With_IoC.Interfaces
{
    public interface IMyDbContext
    {
        //DbSet<Employee> Employees { get; set; }
        //DbSet<Company> Companies { get; set; }
        //DbSet<Pasport> Pasports { get; set; }
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
        void Dispose();
    }
}