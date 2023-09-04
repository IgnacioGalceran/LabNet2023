using Lab.Ejercicio4.Logic;
using System;

namespace Lab.Ejercicio4.Ejercicios
{
    public class Ej10
    {
        public static void Resultado()
        {
            ProductsLogic productsLogic = new ProductsLogic();
            var products = productsLogic.Ejercicio10();

            if (products != null)
            {
                foreach (var p in products)
                {
                    Console.WriteLine($"Nombre producto: {p.ProductName} - " +
                       $"Precio por unidad: {p.UnitPrice} - Stock: {p.UnitsInStock}");
                }
            }
            else
            {
                Console.WriteLine("No existe ningun producto con estas caracteristicas en la base de datos");
            }
        }
    }
}
