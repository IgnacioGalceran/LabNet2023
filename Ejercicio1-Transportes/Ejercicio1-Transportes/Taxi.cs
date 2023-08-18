using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Transportes
{
    public class Taxi : TransportePublico
    {
        public Taxi(int cantPasajeros) : base(cantPasajeros)
        {

        }
        public override string Avanzar()
        {
            return $"El taxi está avanzando";
        }

        public override string Detenerse()
        {
            return $"El taxi se detuvo";
        }
    }
}
