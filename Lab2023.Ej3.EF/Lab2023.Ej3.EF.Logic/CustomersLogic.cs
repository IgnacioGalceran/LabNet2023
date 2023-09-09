using Lab2023.Ej3.EF.Entities;
using Lab2023.Ej3.EF.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2023.Ej3.EF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<CustomersDTO, string>
    {
        public List<CustomersDTO> GetAll()
        {
            IEnumerable<Customers> customers = context.Customers.AsEnumerable();
            List<CustomersDTO> result = customers.Select(x => new CustomersDTO
            {
                CustomerID = x.CustomerID,
                ContactName = x.ContactName,
                CompanyName = x.CompanyName,
                City = x.City,
            }).ToList();

            return result;
        }

        public void Add(CustomersDTO newCustomer)
        {
            string customerId = GenerarID.Generador(newCustomer.CompanyName);

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
            context.SaveChanges();
        }
        public void Delete(string id)
        {
            var clienteAEliminar = context.Customers.FirstOrDefault(c => c.CustomerID == id) ?? throw new IdNoEncontrado();
            context.Customers.Remove(clienteAEliminar);
            context.SaveChanges();
        }
        public void Update(CustomersDTO updCustomer, string id)
        {
            var clienteAActualizar = context.Customers.FirstOrDefault(c => c.CustomerID == id) ?? throw new IdNoEncontrado();
            clienteAActualizar.CompanyName = updCustomer.CompanyName;
            clienteAActualizar.ContactName = updCustomer.ContactName;
            clienteAActualizar.City = updCustomer.City;
            context.SaveChanges();
        }
    }
}
