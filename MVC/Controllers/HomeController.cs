using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          
            if(this.HttpContext.Session["name"] ==null)
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            else
                ViewBag.Message = "Welcome to ASP.NET MVC! " + this.HttpContext.Session["name"].ToString();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
