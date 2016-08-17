using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get|HttpVerbs.Post)]
        [ActionName("ping")]
        public string TestMe()
        {
            return "Passed Routing Test";
        }

        [NonAction]
        public void Test()
        {

        }

        //[HttpPost]
        //public ActionResult Edit(int id)
        //{
        //    return RedirectToAction("Index");
        //}
    }
}