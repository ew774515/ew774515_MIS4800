using System.Web;
using System.Web.Mvc;

namespace ew774515_MIS4800
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
