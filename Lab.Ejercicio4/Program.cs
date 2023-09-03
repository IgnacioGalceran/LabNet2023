using System;

namespace Lab.Ejercicio4.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {

                Console.Clear();
                Menu.MostrarMenu();

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    Opciones.SwitchOpciones(opcion);
                }
                else
                {
                    Console.WriteLine("Opción inválida. Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                }
            } while (opcion != 14);

            Console.WriteLine("Hasta luego... presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
