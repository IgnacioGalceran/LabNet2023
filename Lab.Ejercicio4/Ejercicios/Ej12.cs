using Lab.Ejercicio4.Logic;
using System;

namespace Lab.Ejercicio4.Ejercicios
{
    public class Ej12
    {
        public static void Resultado()
        {
            ProductsLogic productsLogic = new ProductsLogic();
            var product = productsLogic.Ejercicio12();

            if (product != null)
            {
                Console.WriteLine($"Nombre producto: {product.ProductName} - " +
                $"Precio por unidad: ${((double?)product.UnitPrice)} - " +
                $"Stock: {product.UnitsInStock} unidades");
            }
            else
            {
                Console.WriteLine("No existe ningun producto con estas caracteristicas en la base de datos");
            }
        }
    }
}

