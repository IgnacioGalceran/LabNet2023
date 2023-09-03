using System;

namespace Lab.Ejercicio4.UI
{
    public class Menu
    {
        public static void MostrarMenu()
        {
            Console.Write(
                "1) Query para devolver objeto customer\n" +
                "2) Query para devolver todos los productos sin stock\n" +
                "3) Query para devolver todos los productos que tienen stock y que" +
                " cuestan más de 3 por unidad\n" +
                "4) Query para devolver todos los customers de la Región WA\n" +
                "5) Query para devolver el primer elemento o nulo de una" +
                " lista de productos donde el ID del producto sea igual a 789\n" +
                "6) Query para devolver los nombres de los Customers." +
                "Mostrarlos en Mayúscula y en Minúscula\n" +
                "7) Query para devolver Join entre Customers y Orders donde" +
                " los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997. \n" +
                "8) Query para devolver los primeros 3 Customers de la  Región WA \n" +
                "9) Query para devolver lista de productos ordenados por nombre \n" +
                "10) Query para devolver lista de productos ordenados por unit in stock de mayor a menor \n" +
                "11) Query para devolver las distintas categorías asociadas a los productos \n" +
                "12) Query para devolver el primer elemento de una lista de productos \n" +
                "13) Query para devolver los customer con la cantidad de ordenes asociadas \n" +
                "14) Salir de la aplicación \n" +
                "Ingrese su opción: "
            );
        }
    }
}
