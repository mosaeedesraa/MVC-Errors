using MVC_Errors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Errors.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        ///  Save Exception in DB
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;
            filterContext.ExceptionHandled = true;

            // Error Detail
            Error error = new Error();
            error.CreatedDate = DateTime.Now;
            error.Message = exception.Message;
            error.ActionName = filterContext.RouteData.Values["action"].ToString();
            error.ControllerName = filterContext.RouteData.Values["controller"].ToString();
            // save error in database
            //db.Errors.Insert(error);

            // if you want to redirect to another page
            var Result = this.View("_Error", new HandleErrorInfo(exception,
                filterContext.RouteData.Values["controller"].ToString(),
                filterContext.RouteData.Values["action"].ToString()));

            filterContext.Result = Result;

            return;
        }


    }
}
