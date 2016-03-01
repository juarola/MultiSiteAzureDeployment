using System.Web;
using System.Web.Mvc;

namespace MultiSiteAzureDeployment.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
