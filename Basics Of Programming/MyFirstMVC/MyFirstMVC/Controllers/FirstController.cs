using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVC.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public string Index()
        {
            return "hello";
        }
    }
}