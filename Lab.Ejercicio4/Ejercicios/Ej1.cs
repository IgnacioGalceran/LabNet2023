using Lab.Ejercicio4.Entities;
using Lab.Ejercicio4.Logic;
using System;

namespace Lab.Ejercicio4.Ejercicios
{
    public class Ej1
    {
        public static void Resultado()
        {
            CustomersLogic customersLogic = new CustomersLogic();
            Customers customer = customersLogic.Ejercicio1();

            if (customer != null)
            {
                Console.WriteLine($"Nombre: {customer.ContactName} " +
                    $"- Compañía: {customer.CompanyName} " +
                    $"- Ciudad: {customer.City}");
            }
            else
            {
                Console.WriteLine("No existe ningun customer en la base de datos");
            }
        }
    }
}
