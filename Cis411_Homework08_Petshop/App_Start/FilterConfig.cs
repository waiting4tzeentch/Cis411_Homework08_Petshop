using System.Web;
using System.Web.Mvc;

namespace Cis411_Homework08_Petshop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
