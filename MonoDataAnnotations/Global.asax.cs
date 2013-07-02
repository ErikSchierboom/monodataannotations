namespace MonoDataAnnotations
{
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    using MonoDataAnnotations.App_Start;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}