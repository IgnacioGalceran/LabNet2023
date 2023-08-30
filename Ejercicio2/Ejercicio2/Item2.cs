using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Item2
    {
        public static void ExceptionItem2()
        {
            try
            {
                Console.Write("Ingresar un valor numérico para el dividendo: ");
                int dividendo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingresar un valor numérico para el divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"El resultado de la división es: {dividendo / divisor}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("¡Solo Chuck Norris divide por cero!");
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception)
            {
                Console.WriteLine("¡Seguro ingresó un caracter o no ingresó nada!");
            }
            finally
            {
                Console.WriteLine("Finalizó el item 2");
            }
        }
    }
}
