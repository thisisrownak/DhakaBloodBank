using System.Web;
using System.Web.Mvc;

namespace MDRownakJahanTanjil_296627
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
