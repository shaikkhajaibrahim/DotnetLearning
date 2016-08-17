using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id=null)
        {
            if(!string.IsNullOrWhiteSpace(id))
            {
                ViewBag.Message = $"Your application description page with id {id}";
            }
            else
            {
                ViewBag.Message = "Your application description page.";
            }
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}