using System.Web;
using System.Web.Mvc;

namespace WebSiteBanHang_MVC_2120110131
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
