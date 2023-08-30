using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class CustomException : Exception
    {
        public CustomException() : base("Ocurrió un error inesperado (se sospecha de Chuck Norris)")
        {

        }
    }
}
