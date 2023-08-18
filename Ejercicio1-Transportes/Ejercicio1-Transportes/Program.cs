using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Transportes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> transportes = new List<TransportePublico>();

            for (int i = 1; i < 11; i++)
            {
                int cantPasajeros;

                if (i < 6)
                {
                    do
                    {
                        Console.Write($"Ingrese la cantidad de pasajeros para el omnibus número {i}: ");
                        if (!int.TryParse(Console.ReadLine(), out cantPasajeros))
                        {
                            Console.WriteLine("Número de pasajeros invalido.");
                        }
                        if (cantPasajeros <= 0 | cantPasajeros >= 100)
                        {
                            Console.WriteLine("El Número de pasajeros debe ser mayor a 0 y menor a 100");
                        }
                    } while (cantPasajeros <= 0 | cantPasajeros >= 100);
                    transportes.Add(new Omnibus(cantPasajeros));
                }
                else
                {
                    do
                    {
                        Console.Write($"Ingrese la cantidad de pasajeros para el taxi número {i-5}: ");
                        if (!int.TryParse(Console.ReadLine(), out cantPasajeros))
                        {
                            Console.WriteLine("Número de pasajeros invalido.");
                        }
                        if (cantPasajeros <= 0 | cantPasajeros > 4)
                        {
                            Console.WriteLine("El Número de pasajeros para el taxi debe ser mayor a 0 y menor a 5");
                        }
                    } while (cantPasajeros <= 0 | cantPasajeros > 4);
                    transportes.Add(new Taxi(cantPasajeros));
                }
            }

            int iteracion = 1;

            foreach (var item in transportes)
            {
                string transporteTipo = item is Omnibus ? "Omnibus" : "Taxi";
                int transporteNumero = item is Omnibus ? iteracion : iteracion - 5;
                Console.WriteLine($"El {transporteTipo} número {transporteNumero} tiene {item.ObtenerPasajeros} pasajeros");
                iteracion++;
            }

            Console.ReadKey();

        }
    }
}
