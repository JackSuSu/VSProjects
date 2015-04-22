using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace ASPNETWeb
{
    /// <summary>
    /// CookieTest 的摘要说明
    /// 
    /// Ashx 要操作 Session 必须实现接口IRequiresSessionState
    /// 
    /// </summary>
    public class CookieTest : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string read = context.Request["Read"];
            string write = context.Request["Write"];

            //string sessionvalue = context.Request["username"];





            if (!string.IsNullOrEmpty(read)&&read=="读")
            {

               HttpCookie readcookes= context.Request.Cookies["name"];

               string valuese = "没有找到Cookie值";

                if(readcookes!=null)
                {
                    valuese = readcookes.Value;
                    //readcookes.Expires = DateTime.Now.Add(new TimeSpan(0, 0, -20));

                    context.Response.SetCookie(readcookes);
                }

                string html = NVelcityHelper.GetHtml("CookieTest.html", valuese);

                if (context.Session["username"] != null)
                {
                    html += context.Session["username"];
                }
              
            

                context.Response.Write(html);            
                

            }
            else if (!string.IsNullOrEmpty(write)&&write=="写")
            {

                HttpCookie cookes = new HttpCookie("name", "sulongfeng");

                //cookes.Secure = true;

                //cookes.Path = "UserList";

                context.Session["username"] = cookes.Value + DateTime.Now.ToString();
               

                cookes.Expires = DateTime.Now.Add(new TimeSpan(0, 0,20));

                context.Response.SetCookie(cookes);

                string html = NVelcityHelper.GetHtml("CookieTest.html", cookes.Value);           

                

                context.Response.Write(html);

            }
            else
            {

                string valuese = "没有找到Cookie值";

                string html = NVelcityHelper.GetHtml("CookieTest.html", valuese);


             

                context.Response.Write(html);
 
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