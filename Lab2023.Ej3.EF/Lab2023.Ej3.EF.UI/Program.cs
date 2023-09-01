using Lab2023.Ej3.EF.Entities;
using Lab2023.Ej3.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2023.Ej3.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Menu.MostrarMenu();

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida.");
                }
                else
                {
                    Opciones.SwitchOpciones(opcion);
                }
            } while (opcion != 6);

            Console.WriteLine("Hasta luego... presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
