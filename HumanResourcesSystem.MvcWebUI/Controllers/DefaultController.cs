using DevFramework.Core.CrossCuttingConcerns.Security.Web;
using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.MvcWebUI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumanResourcesSystem.MvcWebUI.Controllers
{
    public class DefaultController : Controller
    {
        private IUserService _userService;
        public DefaultController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Login(string userName,string password)
        {
            var admin = _userService.GetByUserRoleName("Admin");
            var personnel = _userService.GetByUserRoleName("Personnel");
            var visitor = _userService.GetByUserRoleName("Visitor");
            var user = _userService.GetByUserNameAndPassword(userName, password);
            if (user != null)
            {
                if (visitor !=null)
                {
                    AuthenticationHelper.CreateAuthCookie(new Guid(), user.UserName, user.Email, DateTime.Now.AddDays(15), _userService.GetUserRoles(user).Select(u => u.RoleName).ToArray(), false, user.FirstName, user.LastName);
                    return Redirect("/SelfHistory/Index");
                }
                else if(personnel != null)
                {
                    AuthenticationHelper.CreateAuthCookie(new Guid(), user.UserName, user.Email, DateTime.Now.AddDays(15), _userService.GetUserRoles(user).Select(u => u.RoleName).ToArray(), false, user.FirstName, user.LastName);
                    return Redirect("/Personnel/Index");
                }
                else if (admin !=null)
                {
                    AuthenticationHelper.CreateAuthCookie(new Guid(), user.UserName, user.Email, DateTime.Now.AddDays(15), _userService.GetUserRoles(user).Select(u => u.RoleName).ToArray(), false, user.FirstName, user.LastName);
                    return Redirect("/Administrator/Index");
                }
               

            }
           

            return View();
          
           
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}