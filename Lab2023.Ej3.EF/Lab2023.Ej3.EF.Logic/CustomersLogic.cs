using Lab2023.Ej3.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2023.Ej3.EF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers, string>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Add(Customers newCustomer)
        {
            string customerId = GenerarID.Generador(newCustomer.CompanyName);

            int count = context.Customers.Count(c => c.CustomerID == customerId);

            if (count > 0)
            {
                Random random = new Random();
                string uniqueId = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 5).Select(s => s[random.Next(s.Length)]).ToArray());
                customerId = uniqueId;
            }

            newCustomer.CustomerID = customerId;

            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }
        public void Delete(string id)
        {
            var clienteAEliminar = context.Customers.FirstOrDefault(c => c.CustomerID == id) ?? throw new IdNoEncontrado();
            context.Customers.Remove(clienteAEliminar);
            context.SaveChanges();
        }
        public void Update(Customers updCustomer, string id)
        {
            var clienteAActualizar = context.Customers.FirstOrDefault(c => c.CustomerID == id) ?? throw new IdNoEncontrado();
            clienteAActualizar.CompanyName = updCustomer.CompanyName;
            clienteAActualizar.ContactName = updCustomer.ContactName;
            clienteAActualizar.City = updCustomer.City;
            context.SaveChanges();
        }
    }
}
