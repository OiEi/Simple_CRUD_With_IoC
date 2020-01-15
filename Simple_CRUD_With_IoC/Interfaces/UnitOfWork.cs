using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_CRUD_With_IoC.Interfaces
{
    public class UnitOfWork
    {
        private MyDbContext db = new MyDbContext();
        private EmployeeRepository employeeRepository;
        private CompanyRepository companyRepository;


        public EmployeeRepository Employees
        {
            get
            {
                if (employeeRepository == null)
                    employeeRepository = new EmployeeRepository(db);
                return employeeRepository;
            }
        }

        public CompanyRepository Companies
        {
            get
            {
                if (companyRepository == null)
                    companyRepository = new CompanyRepository(db);
                return companyRepository;
            }
        }


        public void Save()
        {
            db.SaveChanges();
        }




    }


}