using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplication.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public string Index()
        {
            return "Hi this is my first controller";
        }

        [ActionName("pi")]
        public ActionResult PrettyIndex(string id)
        {
            return RedirectToAction("Index","Home");
            //return $"Hi {id}, This is your first controller";
        }
    }
}