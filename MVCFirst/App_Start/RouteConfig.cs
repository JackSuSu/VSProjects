using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFirst
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //注册一条规则



            routes.MapRoute(
                name: "Default",//路由名字
                url: "{controller}-{action}/{id}",//路由格式
                defaults: new { controller = "Home", action = "HtmlHelper", id = UrlParameter.Optional }
            );

         



        }
    }
}