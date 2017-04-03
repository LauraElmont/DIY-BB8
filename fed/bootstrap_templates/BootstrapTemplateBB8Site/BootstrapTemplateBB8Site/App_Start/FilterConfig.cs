using System.Web;
using System.Web.Mvc;

namespace BootstrapTemplateBB8Site
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
