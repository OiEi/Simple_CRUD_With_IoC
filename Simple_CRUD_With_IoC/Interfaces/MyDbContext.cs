using Simple_CRUD_With_IoC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simple_CRUD_With_IoC.Interfaces
{
    public class MyDbContext : DbContext, IMyDbContext
    {
        public MyDbContext() : base ("MyDB")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Pasport> Pasports { get; set; }
    }
}