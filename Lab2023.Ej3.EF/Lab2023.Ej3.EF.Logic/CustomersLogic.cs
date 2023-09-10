using Lab2023.Ej3.EF.Entities;
using Lab2023.Ej3.EF.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Lab2023.Ej3.EF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<CustomersDTO, string>
    {
        public List<CustomersDTO> GetAll()
        {
            IEnumerable<Customers> customers = context.Customers.AsEnumerable();
            List<CustomersDTO> result = customers.Select(c => new CustomersDTO
            {
                CustomerID = c.CustomerID,
                ContactName = c.ContactName,
                CompanyName = c.CompanyName,
                City = c.City,
            }).Take(10).ToList();

            return result;
        }
        public CustomersDTO GetById(string id)
        {
            Customers customer = context.Customers.FirstOrDefault(c => c.CustomerID == id);

            if (customer == null)
            {
                throw new IdNoEncontrado();
            }

            CustomersDTO customerDTO = new CustomersDTO
            {
                CustomerID = customer.CustomerID,
                ContactName = customer.ContactName,
                CompanyName = customer.CompanyName,
                City = customer.City,
            };

            return customerDTO;
        }
        public bool Add(CustomersDTO newCustomer)
        {
            string customerId = GenerarID.Generador(newCustomer.CompanyName);
            bool result = false; 
            int count = context.Customers.Count(c => c.CustomerID == customerId);

            if (count > 0)
            {
                Random random = new Random();
                string uniqueId = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 5).Select(s => s[random.Next(s.Length)]).ToArray());
                customerId = uniqueId;
            }

            Customers customer = new Customers
            {
                CustomerID = customerId,
                CompanyName = newCustomer.CompanyName,
                ContactName = newCustomer.ContactName,
                City = newCustomer.City,
            };

            context.Customers.Add(customer);
            result = context.SaveChanges() > 0;

            return result;
        }
        public bool Delete(string customerId)
        {
            bool result = false;
            Customers clienteAEliminar = context.Customers.FirstOrDefault(c => c.CustomerID == customerId) ?? throw new IdNoEncontrado();

            if (clienteAEliminar != null)
            {
                var ordersToDelete = context.Orders.Where(o => o.CustomerID == customerId).ToList();

                foreach (var order in ordersToDelete)
                {
                    context.Order_Details.RemoveRange(context.Order_Details.Where(od => od.OrderID == order.OrderID));
                }

                context.Orders.RemoveRange(ordersToDelete);
                context.Customers.Remove(clienteAEliminar);

                result = context.SaveChanges() > 0;
            }

            return result;
        }
        public bool Update(CustomersDTO updCustomer, string id)
        {
            bool result = false;
            var clienteAActualizar = context.Customers.FirstOrDefault(c => c.CustomerID == id) ?? throw new IdNoEncontrado();

            clienteAActualizar.CompanyName = updCustomer.CompanyName;
            clienteAActualizar.ContactName = updCustomer.ContactName;
            clienteAActualizar.City = updCustomer.City;

            result = context.SaveChanges() > 0;

            return result;
        }
    }
}
