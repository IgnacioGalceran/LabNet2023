using System;

namespace Lab2023.Ej3.EF.UI
{
    public class FuncionesSuppliers
    {
        public static void MostrarProveedores()
        {
            SuppliersLogic suppliersLogic = new SuppliersLogic();

            foreach (var supplier in suppliersLogic.GetAll())
            {
                Console.WriteLine($"ID: {supplier.SupplierID} - Nombre: {supplier.ContactName} - Compañía: {supplier.CompanyName}");
            }
        }
    }
}
