using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface IEmployeeService
    {
        void Add(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);
        List<Employee> GetAll();
        Employee GetById(int id);
        List<Employee> GetByName(string text);
    }
}
