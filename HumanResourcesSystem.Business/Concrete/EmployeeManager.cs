using DevFramework.Core.Aspects.Postsharp.AuthorizationAspects;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Business.ValidationRules.FluentValidation;
using HumanResourcesSystem.DataAccess.Abstract;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        private IUserDal _userDal;
        public EmployeeManager(IEmployeeDal employeeDal,IUserDal userDal)
        {
            _employeeDal = employeeDal;
            _userDal = userDal;
        }

        [FluentValidationAspect(typeof(EmployeeValidator))]
        [SecuredOperation(Roles ="Admin")]
        public void Add(Employee employee)
        {
            
            _employeeDal.Add(employee);
        }
        [SecuredOperation(Roles = "Admin")]
        public void Delete(Employee employee)
        {
            try
            {
                _employeeDal.Delete(employee);
            }
            catch (Exception)
            {

                throw new Exception("Silme İşlemi Gerçekleştirilmedi");
            }
        }
        [SecuredOperation(Roles = "Admin,Personnel")]
        public List<Employee> GetAll()
        {
            return _employeeDal.GetList();
        }
        [SecuredOperation(Roles = "Admin,Personnel")]
        public Employee GetById(int id)
        {
            return _employeeDal.Get(e => e.Id == id);
        }
        [SecuredOperation(Roles ="Admin")]
        public List<Employee> GetByName(string text)
        {
            return _employeeDal.GetList(e => e.FirstName.ToLower().Contains(text.ToLower()));
        }

        [SecuredOperation(Roles = "Admin")]
        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }

       
    }
}
