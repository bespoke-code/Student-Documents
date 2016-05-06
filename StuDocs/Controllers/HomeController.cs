using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StuDocs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Како до сега не го измислија ова?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Имате забелешки, сугестии, пофалби и/или критики? Пишете ни!";

            return View();
        }
    }
}