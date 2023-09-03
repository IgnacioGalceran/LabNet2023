using Lab.Ejercicio4.Entities;
using Lab.Ejercicio4.Logic;
using System;

namespace Lab.Ejercicio4.UI
{
    public class Metodos
    {
        public static void Ejercicio1()
        {
            CustomersLogic customersLogic = new CustomersLogic();
            Customers customer = customersLogic.Ejercicio1();

            if (customer != null)
            {
                Console.WriteLine($"Nombre: {customer.ContactName} - Compañía: {customer.CompanyName} - Ciudad: {customer.City} ");
            }
        }
    }
}
