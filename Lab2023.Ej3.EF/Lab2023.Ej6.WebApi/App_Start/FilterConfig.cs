using System.Web;
using System.Web.Mvc;

namespace Lab2023.Ej6.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
