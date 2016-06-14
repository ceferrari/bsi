using System.Web.Mvc;
using TrabalhoPO.Shared;

namespace TrabalhoPO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleExceptionAttribute());
            filters.Add(new AuthorizeAttribute());
        }
    }
}
