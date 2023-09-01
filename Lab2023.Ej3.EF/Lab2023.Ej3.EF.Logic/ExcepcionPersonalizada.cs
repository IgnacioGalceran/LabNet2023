using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2023.Ej3.EF.Logic
{
    public class IdNoEncontrado : Exception
    {
        public IdNoEncontrado() : base("El id ingresado no se encuentra en la base de datos")
        {

        }
    }
}
