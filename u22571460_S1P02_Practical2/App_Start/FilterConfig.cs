using System.Web;
using System.Web.Mvc;

namespace u22571460_S1P02_Practical2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
