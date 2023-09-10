using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2023.Ej6.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Ejercicio 6 - MVC con Razor";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto de Northwind.";

            return View();
        }
    }
}