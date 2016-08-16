using MyFirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplication.Controllers
{
    public class DemoController : Controller
    {
        private string[] items = new[] { "item1", "item2", "item3" };

        // GET: Demo
        public ActionResult Index()
        {
            return View(items);
        }

        public ActionResult Display()
        {
            List<Bus> items = new List<Bus>();
            items.Add(new Bus() { Id = 1, RegistrationNumber = "123" });
            items.Add(new Bus() { Id = 11, RegistrationNumber = "1234" });
            return View(items);
        }
    }
}