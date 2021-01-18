using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumanResourcesSystem.MvcWebUI.Filters
{
    public class ExceptionHandlerAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var message = filterContext.Exception.Message;
            filterContext.Controller.ViewData.ModelState.AddModelError("UserException", message);
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult
            {
                ViewData = new ViewDataDictionary(filterContext.Controller.ViewData)
            };
        }
    }
}