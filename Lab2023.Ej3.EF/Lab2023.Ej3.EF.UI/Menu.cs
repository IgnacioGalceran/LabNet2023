using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2023.Ej3.EF.UI
{
    public class Menu
    {
        public static void MostrarMenu()
        {
            Console.Write(
                "1) Obtener lista de Clientes\n" +
                "2) Obtener lista de Proveedores\n" +
                "3) Insertar nuevo cliente\n" +
                "4) Actualizar un cliente\n" +
                "5) Borrar un cliente\n" +
                "6) Salir\n" +
                "Ingrese su opción: "
            );
        }
    }
}
