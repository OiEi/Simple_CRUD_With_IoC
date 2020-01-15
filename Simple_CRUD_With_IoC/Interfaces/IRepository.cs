using Simple_CRUD_With_IoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_CRUD_With_IoC.Interfaces
{
    public interface IRepository<T> where T : class
    {
            
        IEnumerable<T> GetAll();
        T GetById(int id);
        //void Add(Employee product);
    }

}

