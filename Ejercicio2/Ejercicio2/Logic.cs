using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Logic
    {
        public static void ExcepcionItem3()
        {
            throw new InvalidOperationException();
        }
        public static void ExceptionItem4()
        {
            throw new CustomException();
        }
    }
}
