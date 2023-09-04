using Lab.Ejercicio4.Logic;
using System;

namespace Lab.Ejercicio4.Ejercicios
{
    public class Ej6
    {
        public static void Resultado()
        {
            CustomersLogic customersLogic = new CustomersLogic();
            var customers = customersLogic.Ejercicio6();

            if (customers != null)
            {
                foreach (var c in customers)
                {
                    Console.WriteLine($"Nombre en mayúsculas: {c.ContactName.ToUpper()}" +
                        $" - Nombre en minúsculas: {c.ContactName.ToLower()}");
                }
            }
            else
            {
                Console.WriteLine("No existe ningun customer en la base de datos");
            }
        }
    }
}
