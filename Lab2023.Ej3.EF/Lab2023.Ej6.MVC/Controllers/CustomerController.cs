using Lab2023.Ej3.EF.Entities;
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
            CustomersLogic logic = new CustomersLogic();
            List<CustomersDTO> customers = logic.GetAll();

            return View(customers);
        }
        public ActionResult Form(string id)
        {
            CustomersLogic logic = new CustomersLogic();

            if (!string.IsNullOrEmpty(id))
            {
                CustomersDTO customer = logic.GetById(id);

                if (customer == null)
                {
                    return HttpNotFound();
                }

                return View("Form", customer);
            }
            else
            {
                return View("Form", new CustomersDTO { CustomerID = null });
            }
        }
        public ActionResult InsertCustomer(CustomersDTO customer)
        {
            CustomersLogic customerLogic = new CustomersLogic();
            CustomersDTO newCustomer = new CustomersDTO
            {
                CustomerID = customer.CustomerID,
                ContactName = customer.ContactName,
                CompanyName = customer.CompanyName,
                City = customer.City,
            };

            bool result = customerLogic.Add(newCustomer);

            return Json(new { result = result });
        }
        public ActionResult UpdateCustomer(CustomersDTO customer)
        {
            CustomersLogic customerLogic = new CustomersLogic();
            CustomersDTO updCustomer = new CustomersDTO
            {
                CustomerID = customer.CustomerID,
                ContactName = customer.ContactName,
                CompanyName = customer.CompanyName,
                City = customer.City,
            };

            bool result = customerLogic.Update(updCustomer, customer.CustomerID);

            return Json(new { result = result });
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