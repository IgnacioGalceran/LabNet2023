using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

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
