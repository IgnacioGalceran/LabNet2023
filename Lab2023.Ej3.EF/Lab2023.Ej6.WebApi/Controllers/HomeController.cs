using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2023.Ej6.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Customers()
        {
            ViewBag.Title = "Customer Page";

            return View();
        }
        public ActionResult Form()
        {
            ViewBag.Title = "Form Page";

            return View();
        }
        public ActionResult TiempoAPI()
        {
            ViewBag.Title = "Weather Page";

            return View();
        }
    }
}
