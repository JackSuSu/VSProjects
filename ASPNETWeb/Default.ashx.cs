using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETWeb
{
    /// <summary>
    /// Default 的摘要说明
    /// </summary>
    public class Default : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";

            //HttpContext.Current.Server.ScriptTimeout = 1;
         

            context.Response.ContentType = "text/html";

            context.Response.Write("<h3>Hello World</h3>");

            context.Response.Write("<p>" + context.Server.MachineName + "</p>");

            //context.Response.Redirect("http://www.baidu.com");
            

            string action = HttpContext.Current.Request["name"];

            int age = Convert.ToInt32(HttpContext.Current.Request["age"]);

            string vip = HttpContext.Current.Request["vip"];

            string msg = HttpContext.Current.Request["msg"];

            string shengfen = HttpContext.Current.Request["province"];

            string gender = HttpContext.Current.Request["sex"];

            //匿名类

            var NimingClass = new { Id = 100, Age = 250, Name = "sulongfeng" };

            context.Response.Write("Hi 我叫" + action + "年龄：" + age + "是否VIP：" + vip + "省份:" + shengfen + "性别：" + gender + "描述：" + msg);

            context.Response.Write("<br/>" + NimingClass.Id + "|" + NimingClass.Age + "|" + NimingClass.Name);

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