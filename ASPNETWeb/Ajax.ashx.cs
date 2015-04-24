using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETWeb
{
    /// <summary>
    /// Ajax 的摘要说明
    /// </summary>
    public class Ajax : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
            string zan = context.Request["Action"];

            if (!string.IsNullOrEmpty(zan))
            {
                context.Response.Write("给你一个信息！");
            }
            else
            {
                context.Response.Write("你不赞怎么给你信息");
            }

            //string html = NVelcityHelper.GetHtml("ajax.html", null);

            //context.Response.Write(html);

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