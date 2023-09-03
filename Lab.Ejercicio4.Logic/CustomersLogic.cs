using Lab.Ejercicio4.Entities;
using System.Linq;

namespace Lab.Ejercicio4.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public Customers Ejercicio1()
        {
            var customerEj1 = from customer in context.Customers
                                     select customer;

            return customerEj1.FirstOrDefault();
        }
    }
}
