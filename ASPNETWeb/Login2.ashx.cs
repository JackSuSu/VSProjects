using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ASPNETWeb
{
    /// <summary>
    /// Login2 的摘要说明
    /// </summary>
    public class Login2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //context.Response.Write("Hello World");


            string username = context.Request["username"];

            if (string.IsNullOrEmpty(username))
            {
              
                var data=new  {username="zhangsan",password="123456"};

                //string html = NVelcityHelper.GetHtml("login.html", data);

                //context.Response.Write(html);
          
            }

            var users = SQLHelp.ExcuteDataTable("select * from TbUser", null);

            var groups = SQLHelp.ExcuteDataTable("select * from TbGroup",null);

            var datas = new { persons = users.Rows, classes = groups.Rows };

            string html = NVelcityHelper.GetHtml("ShowUsers.html", datas);

            context.Response.Write(html);

            

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

    public class Person
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Dictionary<string,string> dict;

        public Dictionary<string,string> Dict
        {
            get { return dict; }
            set { dict = value; }
        }


        private List<string> listdata;

        public List<string> ListData
        {
            get { return listdata; }
            set { listdata = value; }
        }
        
        
            
    }


}