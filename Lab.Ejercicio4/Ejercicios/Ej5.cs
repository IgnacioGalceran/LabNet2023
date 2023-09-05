using Lab.Ejercicio4.Logic;
using System;

namespace Lab.Ejercicio4.Ejercicios
{
    public class Ej5
    {
        public static void Resultado()
        {
            ProductsLogic productsLogic = new ProductsLogic();

            try
            {
                var product = productsLogic.Ejercicio5();
                Console.WriteLine($"Nombre producto: {product.ProductName} - " +
                    $"Precio por unidad: {product.UnitPrice} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                Console.WriteLine("Presiona una tecla para continuar...");
            }

            Console.ReadKey();
        }
    }
}
