using System;

namespace Lab2023.Ej3.EF.Logic
{
    public static class GenerarID
    {
        public static string Generador(string companyName)
        {
            string customerId = companyName.Substring(0, 5).ToUpper();
            return customerId;
        }
    }
}
