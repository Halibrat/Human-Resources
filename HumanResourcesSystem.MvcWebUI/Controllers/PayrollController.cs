using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Entities.Concrete;
using HumanResourcesSystem.MvcWebUI.Filters;
using HumanResourcesSystem.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;
using System.Web.Mvc;

namespace HumanResourcesSystem.MvcWebUI.Controllers
{
    public class PayrollController : Controller
    {
        private IPayrollService _payrollService;
        
        
        public PayrollController(IPayrollService payrollService)
        {
            _payrollService = payrollService;
        }
        // GET: Payro
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            
            return View();
        }
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Add(Payroll payroll)
        {
            _payrollService.Add(payroll);
            return RedirectToAction("GetAll");
        }

        public ActionResult GetAll(int page=1)
        {
            List<Payroll> pay =_payrollService.GetAll();
           
            return View(pay.ToPagedList(page,1));
        }

        public ActionResult Delete(int page=1)
        {
            List<Payroll> pay = _payrollService.GetAll();
            return View(pay.ToPagedList(page,4));
        }

        [ExceptionHandler]
        public ActionResult PayrollDelete(string id)
        {
            Payroll payroll = _payrollService.GetById(Convert.ToInt32(id));
            _payrollService.Delete(payroll);
            List<Payroll> pay = _payrollService.GetAll();
            return View("Delete", pay);
        }

       



        

    }
    
}