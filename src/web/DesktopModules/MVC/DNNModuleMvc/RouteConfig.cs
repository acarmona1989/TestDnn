using DotNetNuke.Web.Mvc.Routing;

namespace Planeta.Modules.DNNModuleMvc
{
    public class RouteConfig : IMvcRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapRoute("DnnModule1", "DnnModule1", "{controller}/{action}", new[]
            {"Planeta.Modules.DNNModule1.Controllers"});
        }
    }
}