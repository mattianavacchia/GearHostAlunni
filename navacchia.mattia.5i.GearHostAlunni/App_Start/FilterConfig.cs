using System.Web;
using System.Web.Mvc;

namespace navacchia.mattia._5i.GearHostAlunni
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
