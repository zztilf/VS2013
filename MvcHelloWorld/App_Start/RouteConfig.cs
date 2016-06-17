using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcHelloWorld
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",  //路由名称，Default 为默认路由，适用于所有未明示的路由规则
                url: "{controller}/{action}/{id}", //URL 路由模式
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } //默认路由参数
            );
        }
    }
}