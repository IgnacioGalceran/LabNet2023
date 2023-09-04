using Lab.Ejercicio4.Logic;
using System;

namespace Lab.Ejercicio4.Ejercicios
{
    public class Ej5
    {
        public static void Resultado()
        {
            ProductsLogic productsLogic = new ProductsLogic();
            var product = productsLogic.Ejercicio5();

            if (product != null)
            {
                Console.WriteLine($"Nombre producto: {product.ProductName} - " +
                    $"Precio por unidad: {product.UnitPrice} ");
            }
            else
            {
                Console.WriteLine("No existe ningun producto con estas caracteristicas en la base de datos");
            }
        }
    }
}
