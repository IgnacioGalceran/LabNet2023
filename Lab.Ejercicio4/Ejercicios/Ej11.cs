using Lab.Ejercicio4.Logic;
using System;

namespace Lab.Ejercicio4.Ejercicios
{
    public class Ej11
    {
        public static void Resultado()
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            var categories = categoriesLogic.Ejercicio11();

            if (categories != null)
            {
                foreach (var c in categories)
                {
                    Console.WriteLine($"Nombre categoria: {c.CategoryName} - " +
                       $"Descripción: {c.Description}");
                }
            }
            else
            {
                Console.WriteLine("No existe ninguna categoria con estas caracteristicas en la base de datos");
            }
        }
    }
}
