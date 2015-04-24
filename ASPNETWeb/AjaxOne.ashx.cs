using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETWeb
{
    /// <summary>
    /// AjaxOne 的摘要说明
    /// </summary>
    public class AjaxOne : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";


            string html = NVelcityHelper.GetHtml("Ajax.html", null);

            context.Response.Write(html);

            //context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}