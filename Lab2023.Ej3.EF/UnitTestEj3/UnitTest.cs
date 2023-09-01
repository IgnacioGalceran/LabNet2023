using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2023.Ej3.EF.Logic;
using Lab2023.Ej3.EF.Entities;
using System.Linq;

namespace Lab2023.Ej3.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void VerificacionInsertarCustomer()
        {
            var customersLogic = new CustomersLogic();
            var contadorInicial = customersLogic.GetAll().Count;

            var newCustomer = new Customers
            {
                CompanyName = "Compañía",
                ContactName = "Nombre y apellido",
                City = "ciudad"
            };

            var customers = customersLogic.GetAll();
            var nuevoCustomer = customers.FirstOrDefault(c => c.CompanyName == newCustomer.CompanyName && c.ContactName == newCustomer.ContactName && c.City == newCustomer.City);

            Assert.IsNotNull(nuevoCustomer, "Se espera que el cliente se agregue correctamente");
            Assert.AreEqual(contadorInicial + 1, customers.Count, "El número de clientes se incrementó correctamente");
        }
    }
}
