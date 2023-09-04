using Lab.Ejercicio4.Logic;
using System;

namespace Lab.Ejercicio4.Ejercicios
{
    public class Ej8
    {
        public static void Resultado()
        {
            CustomersLogic customersLogic = new CustomersLogic();
            var customers = customersLogic.Ejercicio8();

            if (customers != null)
            {
                foreach (var c in customers)
                {
                    Console.WriteLine($"Nombre: {c.ContactName} - " +
                        $"Compañía: {c.CompanyName} - Ciudad: {c.City} - Región: {c.Region}");
                }
            }
            else
            {
                Console.WriteLine("No existe ningun customer en la base de datos");
            }
        }
    }
}
