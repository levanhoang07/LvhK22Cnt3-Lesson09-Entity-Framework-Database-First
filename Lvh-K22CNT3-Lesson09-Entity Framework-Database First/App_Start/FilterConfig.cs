using System.Web;
using System.Web.Mvc;

namespace Lvh_K22CNT3_Lesson09_Entity_Framework_Database_First
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
