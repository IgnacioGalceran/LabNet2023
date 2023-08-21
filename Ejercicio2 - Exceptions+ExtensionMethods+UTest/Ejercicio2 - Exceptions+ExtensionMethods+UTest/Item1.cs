using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2___Exceptions_ExtensionMethods_UTest
{
    public static class Item1
    {
        public static void ExcepcionItem1(this int valor)
        {
            try
            {
                Console.WriteLine(valor / 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
