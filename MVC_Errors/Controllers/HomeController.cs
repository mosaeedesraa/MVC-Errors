using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Errors.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            int i = 4;
            int j = 0;
            int z = i / j;

            return View();
        }

    }
}
