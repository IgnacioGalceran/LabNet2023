using Lab2023.Ej3.EF.Logic;
using Lab2023.Ej3.EF.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2023.Ej6.MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var logic = new CustomersLogic();
            List<CustomersDTO> customers = logic.GetAll();

            return View(customers);
        }

        // DELETE: Customer
        public ActionResult DeleteCustomer(string idCustomer)
        {
            CustomersLogic customer = new CustomersLogic();
            bool result = customer.Delete(idCustomer);

            return Json(new { result = result });
        }
    }
}