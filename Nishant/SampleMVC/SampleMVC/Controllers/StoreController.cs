using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVC.Models;

namespace SampleMVC.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            BookViewModel viewModel=new BookViewModel();
            viewModel.FillBooks();
            return View(viewModel.Books);
        }
    }
}