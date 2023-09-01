using System;
using System.Text.RegularExpressions;

namespace Lab2023.Ej3.EF.UI
{
    public static class Validaciones
    {
        public static string ValidarCompanyName()
        {
            string companyName;
            do
            {
                Console.Write("Nombre de la compañía (debe tener más de 5 y menos de 25 letras), 0 fin de datos: ");
                companyName = Console.ReadLine();

                if (companyName == "0")
                {
                    Console.WriteLine("Saliendo...");
                    return null;
                }

                if (companyName.Length <= 5 || !Regex.IsMatch(companyName, "^[a-zA-Z ]+$") || companyName.Length > 25)
                {
                    Console.WriteLine("El nombre de la compañía debe tener más de 3 y menos de 25 letras.");
                }
            } while (companyName.Length <= 5 || !Regex.IsMatch(companyName, "^[a-zA-Z ]+$") || companyName.Length > 25);

            return companyName;
        }

        public static string ValidarContactName()
        {
            string contactName;
            do
            {
                Console.Write("Nombre del cliente (debe tener más de 3 y menos de 25 letras), 0 fin de datos: ");
                contactName = Console.ReadLine();

                if (contactName == "0")
                {
                    Console.WriteLine("Saliendo...");
                    return null;
                }

                if (contactName.Length < 3 || !Regex.IsMatch(contactName, "^[a-zA-Z ]+$") || contactName.Length > 25)
                {
                    Console.WriteLine("El nombre del cliente debe tener más de 3 y menos de 25 letras.");
                }
            } while (contactName.Length < 3 || !Regex.IsMatch(contactName, "^[a-zA-Z ]+$") || contactName.Length > 25);

            return contactName;
        }

        public static string ValidarCity()
        {
            string city;
            do
            {
                Console.Write("Ciudad (debe tener más de 3 y menos de 25 letras), 0 fin de datos: ");
                city = Console.ReadLine();

                if (city == "0")
                {
                    Console.WriteLine("Saliendo...");
                    return null;
                }

                if (city.Length < 3 || !Regex.IsMatch(city, "^[a-zA-Z ]+$") || city.Length > 25)
                {
                    Console.WriteLine("El nombre de la ciudad debe tener más de 3 y menos de 25 letras.");
                }
            } while (city.Length < 3 || !Regex.IsMatch(city, "^[a-zA-Z ]+$") || city.Length > 25);

            return city;
        }
        public static string ValidarId()
        {
            string customerID;

            do
            {
                Console.Write("Ingresa el ID del cliente (5 letras de la A a la Z). 0 para fin de datos: ");
                customerID = Console.ReadLine();

                if (customerID == "0")
                {
                    Console.WriteLine("Saliendo...");
                    return null;
                }

                if (!Regex.IsMatch(customerID, "^[a-zA-Z]{5}$"))
                {
                    Console.WriteLine("El ID del cliente debe contener exactamente 5 letras de la A a la Z. Inténtalo de nuevo.");
                }
            } while (!Regex.IsMatch(customerID, "^[a-zA-Z]{5}$"));

            return customerID;
        }
    }
}
