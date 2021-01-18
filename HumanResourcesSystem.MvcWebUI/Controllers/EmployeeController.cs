using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.DataAccess.Abstract;
using HumanResourcesSystem.DataAccess.Concrete.EntityFramework;
using HumanResourcesSystem.Entities.Concrete;
using HumanResourcesSystem.MvcWebUI.Filters;
using HumanResourcesSystem.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Mvc;

namespace HumanResourcesSystem.MvcWebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
       
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
     
        }
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            
            return View();
        }
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Add(Employee employee )
        {
            _employeeService.Add(employee);
            return RedirectToAction("GetAll");
        }

        public ActionResult Update(string id)
        {
            Employee employee = _employeeService.GetById(Convert.ToInt32(id));
            return View("Update",employee);
        }
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Update(Employee employee)
        {
          
            _employeeService.Update(employee);

            return RedirectToAction("GetAll");
        }
        public ActionResult Delete()
        {
            List<Employee> emp = _employeeService.GetAll();
            return View(emp);
        }
        [ExceptionHandler]
        public ActionResult DeleteEmployee(string id)
        {

            
            Employee employee = _employeeService.GetById(Convert.ToInt32(id));
            _employeeService.Delete(employee);
            List<Employee> emp = _employeeService.GetAll();
            return View("Delete",emp);
        }
        public ActionResult GetAll()
        {

            var model = new EmployeeListViewModel
            {
                Employees = _employeeService.GetAll()
            };
            return View(model);
        

        }
        [ExceptionHandler]
        public ActionResult Search(string text)
        {
            List<Employee> emp = _employeeService.GetAll();

            if (!string.IsNullOrEmpty(text))
            {
                
                emp= _employeeService.GetByName(text);
              
            }
            return View(emp);
        }
    }
}