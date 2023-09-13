using Lab2023.Ej3.EF.Logic;
using Lab2023.Ej3.EF.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace Lab2023.Ej6.WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        private CustomersLogic _customerLogic = new CustomersLogic();
        public IHttpActionResult GetCustomers()
        {
            try
            {
                List<CustomersDTO> listaCustomers = this._customerLogic.GetAll();

                return Ok(listaCustomers);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, $"Ocurrió un error: {ex.Message}");
            }
        }
        public IHttpActionResult GetCustomerById(string id)
        {
            try
            {
                CustomersDTO customer = this._customerLogic.GetById(id);

                return Ok(customer);
            }
            catch (Exception ex)
            {
                object response = new { message = $"Ocurrió un error: {ex.Message}", result = false };

                return Content(HttpStatusCode.BadRequest, response);
            }
        }
        public IHttpActionResult PostAgregarCustomer([FromBody] CustomersDTO customer)
        {
            try
            {
                bool created = _customerLogic.Add(customer);
                if (created)
                {
                    object response = new { message = "El cliente ha sido creado con éxito.", result = true };

                    return Content(HttpStatusCode.OK, response);
                } else
                {
                    object response = new { message = "Ocurrió un error mientras se creaba el customer", result = false, error = false };

                    return Content(HttpStatusCode.NoContent, response);
                }
            }
            catch (Exception ex)
            {
                object response = new { message = $"Ocurrió un error: {ex.Message}", result = false, error = true };

                return Content(HttpStatusCode.BadRequest, response);
            }
        }
        public IHttpActionResult PutActualizarCustomer([FromBody] CustomersDTO customer, string id)
        {
            try
            {
                bool updated = _customerLogic.Update(customer, id);
                if (updated)
                {
                    object response = new { message = "El cliente ha sido actualizado con éxito.", result = true };

                    return Content(HttpStatusCode.OK, response);
                } else
                {
                    object response = new { message = "No se produjeron cambios en el customer", result = false, error = false };

                    return Content(HttpStatusCode.NoContent, response);
                }
            }
            catch (Exception ex)
            {
                object response = new { message = $"Ocurrió un error: {ex.Message}", result = false, error = true };

                return Content(HttpStatusCode.BadRequest, response);
            }
        }
        public IHttpActionResult DeleteBorrarCustomer(string id)
        {
            try
            {
                bool deleted = _customerLogic.Delete(id);
                if (deleted)
                {
                    object response = new { message = "El cliente ha sido borrado con éxito.", result = true };

                    return Content(HttpStatusCode.OK, response);
                }
                else
                {
                    object response = new { message = "Ocurrió un error mientras se borraba el customer", result = false };

                    return Content(HttpStatusCode.BadRequest, response);
                }
            }
            catch (Exception ex)
            {
                object response = new { message = $"Ocurrió un error: {ex.Message}", result = false };

                return Content(HttpStatusCode.BadRequest, response);
            }
            
        }
    }
}