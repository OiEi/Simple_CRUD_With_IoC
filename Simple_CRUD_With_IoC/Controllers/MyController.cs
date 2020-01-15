using Simple_CRUD_With_IoC.Interfaces;
using Simple_CRUD_With_IoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Simple_CRUD_With_IoC.Controllers
{
    public class MyController : ApiController
    {
        UnitOfWork unitOfWork;
        public MyController()
        {
            unitOfWork = new UnitOfWork();
        }
             
        
        [Route("api/get_all_empl")]
        public IEnumerable<Employee> Get()
        {
            
            {
                return unitOfWork.Employees.GetAll();
            }
        }
    }
}
