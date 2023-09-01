using Lab2023.Ej3.EF.Entities;
using Lab2023.Ej3.EF.Logic;
using System;

namespace Lab2023.Ej3.EF.UI
{
    public class FuncionesCustomer
    {
        public static void MostrarClientes()
        {
            CustomersLogic customersLogic = new CustomersLogic();

            foreach (var customer in customersLogic.GetAll())
            {
                Console.WriteLine($"ID: {customer.CustomerID} - Nombre: {customer.ContactName} - Compañía: {customer.CompanyName}");
            }
        }
        public static void InsertarCliente()
        {
            CustomersLogic customersLogic = new CustomersLogic();

            string companyName = Validaciones.ValidarCompanyName();
            if (companyName == null) return;

            string contactName = Validaciones.ValidarContactName();
            if (contactName == null) return;

            string city = Validaciones.ValidarCity();
            if (city == null) return;

            Customers nuevoCliente = new Customers
            {
                CompanyName = companyName,
                ContactName = contactName,
                City = city
            };

            customersLogic.Add(nuevoCliente);

            Console.WriteLine("\nCliente agregado con éxito.");
        }
        public static void BorrarCliente()
        {
            CustomersLogic customersLogic = new CustomersLogic();
            string customerID = Validaciones.ValidarId();

            if (customerID == null) return;

            customersLogic.Delete(customerID);
        }
        public static void ActualizarCliente()
        {
            CustomersLogic customersLogic = new CustomersLogic();

            string customerID = Validaciones.ValidarId();
            if (customerID == null) return;

            string companyName = Validaciones.ValidarCompanyName();
            if (companyName == null) return;

            string contactName = Validaciones.ValidarContactName();
            if (contactName == null) return;

            string city = Validaciones.ValidarCity();
            if (city == null) return;

            Customers actualizarCliente = new Customers
            {
                CompanyName = companyName,
                ContactName = contactName,
                City = city
            };

            customersLogic.Update(actualizarCliente, customerID);
        }
    }
}
