using System.Web;
using System.Web.Mvc;

namespace V5_Test_Project_VSTS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
