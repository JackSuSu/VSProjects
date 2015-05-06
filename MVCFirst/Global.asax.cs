using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCFirst
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["PageClick"] = 0;

            Application["UserVisit"] = 0;

        }

        protected void Session_Start(object sender, EventArgs e)
        {

            Application.Lock();

            Application["UserVisit"] = (int)Application["UserVisit"] + 1;

            Application.UnLock();

        }


        protected void Session_End(object sender, EventArgs e)
        {

            // 在会话结束时运行的代码

            // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为InProc 时，才会引发 Session_

            var ttt = 10;

            // 如果会话模式设置为 StateServer 或 SQLServer，则不会引发该事件

        }



    }
}