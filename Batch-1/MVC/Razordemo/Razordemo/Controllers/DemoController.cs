using Razordemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razordemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestStudent()
        {
            Student s = new Student()
            {
                Id = 1,
                Name = "Demo",
                Standard = "LKG",
                IsFeePaid = true,
                Gender=Gender.Male
            };
            return View(s);
        }
    }
}