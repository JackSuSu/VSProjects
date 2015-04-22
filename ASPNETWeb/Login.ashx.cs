using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETWeb
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";

            string username = context.Request["username"];

            string pwd = context.Request["pwd"];

            if (!string.IsNullOrEmpty(username)
                && !string.IsNullOrEmpty(pwd))
            {
                if (username == "admin" && pwd == "123")
                {
                    context.Response.Write("<p>登录成功</p>");
                }
                else
                {
                    context.Response.Write("<html>");

                    context.Response.Write("<head></head>");

                    context.Response.Write("<body>");

                    context.Response.Write("<form action='login.ashx' method='post'>用户名:<input type='text'  name='username'/><br />密码：<input type='password'  name='pwd'/><br /><input type='submit' /> </form>");

                    context.Response.Write("</body>");

                    context.Response.Write("</html>");
                }
            

            }
            else
            {
                context.Response.Write("<html>");

                context.Response.Write("<head></head>");

                context.Response.Write("<body>");

                context.Response.Write("<form action='login.ashx' method='post'>用户名:<input type='text'  name='username'/><br />密码：<input type='password'  name='pwd'/><br /><input type='submit' /> </form>");

                context.Response.Write("</body>");

                context.Response.Write("</html>");
 
            }

       
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