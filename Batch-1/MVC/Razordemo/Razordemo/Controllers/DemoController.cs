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
        static Student s = new Student()
        {
            Id = 1,
            Name = "Demo",
            Standard = "LKG",
            IsFeePaid = true,
            Gender = Gender.Male
        };
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestStudent()
        {
            
            return View(s);
        }

        public ActionResult Edit(int  id)
        {

            return View(s);

        }

        [HttpPost]
        public ActionResult Edit(Student s1)
        {
            s = s1;
            return RedirectToAction("TestStudent");
        }


    }
}