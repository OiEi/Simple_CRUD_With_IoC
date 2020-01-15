using Simple_CRUD_With_IoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_CRUD_With_IoC.Interfaces
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private MyDbContext db;
        public EmployeeRepository (MyDbContext context)
        {
            db = context;
        }
    
        public IEnumerable<Employee> GetAll()
        {
            return db.Employees;
        }
        public Employee GetById(int id)
        {
            return db.Employees.Find(id);
        }
    
    }

    public class CompanyRepository : IRepository<Company>
    {
        private MyDbContext db;
        public CompanyRepository(MyDbContext context)
        {
            db = context;
        }

        public IEnumerable<Company> GetAll()
        {
            return db.Companies;
        }
        public Company GetById(int id)
        {
            return db.Companies.Find(id);
        }

    }
}