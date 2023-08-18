using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Transportes
{
    public abstract class TransportePublico
    {
        public int ObtenerPasajeros { get; }
        public TransportePublico (int cantPasajeros)
        {
            ObtenerPasajeros = cantPasajeros;
        }
        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
