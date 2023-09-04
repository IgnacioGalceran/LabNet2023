using Lab.Ejercicio4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Ejercicio4.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public Customers Ejercicio1()
        {
            var customerEj1 = from customer in context.Customers
                                     select customer;

            return customerEj1.FirstOrDefault();
        }
        public IEnumerable<Customers> Ejercicio4()
        {
            string region = "WA";
            var customersEj4 = context.Customers.Where(c => c.Region == region);
            return customersEj4;
        }
        public IEnumerable<Customers> Ejercicio6()
        {
            var customerEj6 = from customer in context.Customers
                              select customer;

            return customerEj6.ToList();
        }
        public IEnumerable<Customers> Ejercicio7()
        {
            string region = "WA";
            var customersEj7 = from customer in context.Customers
                               where customer.Region == region
                               join order in context.Orders on customer.CustomerID equals order.CustomerID
                               where order.OrderDate > new DateTime(1997, 1, 1)
                               select customer;

            return customersEj7.ToList();
        }
        public IEnumerable<Customers> Ejercicio8()
        {
            string region = "WA";
            var customersEj8 = context.Customers
                .Where(c => c.Region == region)
                .Take(3);

            return customersEj8.ToList();
        }
        public void Ejercicio13()
        {
            var customersEj13 = from customer in context.Customers
                                join order in context.Orders on 
                                customer.CustomerID equals order.CustomerID into customerOrders
                                select customer;

            foreach (var c in customersEj13)
            {
                var contOrdenes = context.Orders.Count(o => o.CustomerID == c.CustomerID);
                Console.WriteLine($"Nombre: {c.ContactName}, Cantidad de órdenes: {contOrdenes}");
            }
        }
    }
}
