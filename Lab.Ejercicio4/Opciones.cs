using Lab.Ejercicio4.Ejercicios;
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
                        Console.WriteLine("Opción 1 seleccionada.  Query para devolver objeto customer");
                        Ej1.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Opción 2 seleccionada. Query para devolver todos los productos sin stock");
                        Ej2.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar..");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Opción 3 seleccionada. Query para devolver todos los" +
                            " productos que tienen stock y que cuestan más de 3 por unidad ");
                        Ej3.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Opción 4 seleccionada. Query para devolver todos los customers de la Región WA");
                        Ej4.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Opción 5 seleccionada. Query para devolver el primer elemento" +
                            " no nulo de una lista de productos donde el ID de producto sea igual a 789");
                        Ej5.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Opción 6 seleccionada. Query para devolver los nombre de los Customers." +
                            " Mostrarlos en Mayúscula y en Minúscula");
                        Ej6.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Opción 7 seleccionada. Query para devolver Join entre Customers y Orders" +
                            " donde los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997");
                        Ej7.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Opción 8 seleccionada. " +
                            "Query para devolver los primeros 3 Customers de la  Región WA");
                        Ej8.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Opción 9 seleccionada. Query para devolver lista de" +
                            " productos ordenados por nombre");
                        Ej9.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Opción 10 seleccionada. Query para devolver lista de productos ordenados" +
                            " por unit in stock de mayor a menor");
                        Ej10.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                        Console.WriteLine("Opción 11 seleccionada. Query para devolver las distintas" +
                            " categorías asociadas a los productos");
                        Ej11.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 12:
                        Console.Clear();
                        Console.WriteLine("Opción 12 seleccionada. Query para devolver el primer elemento de una lista de productos");
                        Ej12.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 13:
                        Console.Clear();
                        Console.WriteLine("Opción 13 seleccionada. Query para devolver los customer" +
                            " con la cantidad de ordenes asociadas");
                        Ej13.Resultado();
                        Console.WriteLine("Presiona una tecla para continuar...");
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
