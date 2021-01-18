using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Entities.Concrete;
using HumanResourcesSystem.MvcWebUI.Filters;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumanResourcesSystem.MvcWebUI.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: User
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
        public ActionResult Add(User user)
        {
            _userService.Add(user);
            return View(user);
        }
    }
}