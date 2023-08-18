using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Transportes
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int cantPasajeros) : base(cantPasajeros)
        {

        }
        public override string Avanzar()
        {
            return $"El omnibus está avanzando";
        }

        public override string Detenerse()
        {
            return $"El omnibus se detuvo";
        }
    }
}
