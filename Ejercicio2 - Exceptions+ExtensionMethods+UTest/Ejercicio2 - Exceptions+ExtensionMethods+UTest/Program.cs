using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2___Exceptions_ExtensionMethods_UTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Item 1 de Excepciones");
            try
            {
                Console.Write("Ingresar un valor numérico: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                valor.ExcepcionItem1();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalizó el item 1");
            }
            Console.WriteLine("Item 2 de Excepciones");
            try
            {
                Item2.ExceptionItem2();
            }
            catch
            {

            }
            finally
            {
                Console.WriteLine("Finalizó el item 2");
            }
            Console.ReadKey();
        }
    }
}
