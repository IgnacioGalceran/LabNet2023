using System;

namespace Lab2023.Ej3.EF.UI
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
                        Console.WriteLine("Opción 1 seleccionada. Mostrando todos los clientes...");
                        FuncionesCustomer.MostrarClientes();
                        break;
                    case 2:
                        Console.WriteLine("Opción 2 seleccionada. Mostrando todos los proveedores...");
                        FuncionesSuppliers.MostrarProveedores();
                        break;
                    case 3:
                        Console.WriteLine("Opción 3 seleccionada. Insertar nuevo cliente");
                        FuncionesCustomer.InsertarCliente();
                        break;
                    case 4:
                        Console.WriteLine("Opción 4 seleccionada. Actualizar cliente");
                        FuncionesCustomer.ActualizarCliente();
                        break;
                    case 5:
                        Console.WriteLine("Opción 5 seleccionada. Borrar cliente");
                        FuncionesCustomer.BorrarCliente();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
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
