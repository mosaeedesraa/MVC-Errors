# MVC Errors

# Catch all error in your web site

# Installation : 

1 - Write in Web.config : 

<customErrors mode="Off" />

2 - Wite this for All Conreollers
   
    public class HomeController : BaseController
    
3 - In Base Controller we will catch all errors in our site : 

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


