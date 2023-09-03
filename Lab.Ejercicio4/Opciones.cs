using System;

namespace Lab.Ejercicio4.UI
{
    public class Opciones
    {
        public static void SwitchOpciones(int option)
        {
            try
            {
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Opción 1 seleccionada.");
                        Metodos.Ejercicio1();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Opción 2 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Opción 3 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Opción 4 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Opción 5 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Opción 6 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Opción 7 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Opción 8 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Opción 9 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Opción 10 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                        Console.WriteLine("Opción 11 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 12:
                        Console.Clear();
                        Console.WriteLine("Opción 12 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 13:
                        Console.Clear();
                        Console.WriteLine("Opción 13 seleccionada.");

                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 14:
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
