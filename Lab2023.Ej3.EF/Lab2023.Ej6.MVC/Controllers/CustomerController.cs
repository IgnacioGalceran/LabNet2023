using Lab2023.Ej3.EF.Logic;
using Lab2023.Ej3.EF.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Lab2023.Ej6.MVC.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            CustomersLogic logic = new CustomersLogic();
            List<CustomersDTO> customers = logic.GetAll();

            return View(customers);
        }
        public ActionResult Form(string id)
        {
            CustomersLogic customerLogic = new CustomersLogic();

            if (!string.IsNullOrEmpty(id))
            {
                CustomersDTO customer = customerLogic.GetById(id);

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
            try
            {
                CustomersLogic customerLogic = new CustomersLogic();
                CustomersDTO newCustomer = new CustomersDTO
                {
                    ContactName = customer.ContactName,
                    CompanyName = customer.CompanyName,
                    City = customer.City,
                };

                bool result = customerLogic.Add(newCustomer);

                return Json(new { result = result, error = false });
            }
            catch (Exception ex)
            {
                return Json(new { result = false, error = true, message = ex.Message });
            }
        }
        public ActionResult UpdateCustomer(CustomersDTO customer)
        {
            try
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

                return Json(new { result = result, error = false });
            }
            catch (Exception ex)
            {
                return Json(new { result = false, error = true, message = ex.Message });
            }
        }
        public ActionResult DeleteCustomer(string idCustomer)
        {
            try
            {
                CustomersLogic customer = new CustomersLogic();
                bool result = customer.Delete(idCustomer);

                return Json(new { result = result, error = false });
            }
            catch (Exception ex)
            {
                return Json(new { result = false, error = true, message = ex.Message });
            }
        }
    }
}