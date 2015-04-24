using MVCFirst.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            ViewData["Key1"] = DateTime.Now.ToString();          

            return View("Index2");
        }

        public ActionResult HtmlHelper()
        {
            return View();
        }

        public ActionResult DorpBox()
        {
            ViewData["city"] = new List<SelectListItem>() { new SelectListItem() { Selected = false, Text = "上海",Value= "1" } ,
            
                new SelectListItem() { Selected = true, Text = "北京",Value= "1" } ,
                new SelectListItem() { Selected = false, Text = "广州",Value= "1" } 
            };

            ViewData["Demo"] = "123456";

            return View();
        }


        public ActionResult Show()
        {

            UserInfo userinfo = new UserInfo();

            userinfo.UId = 1;

            userinfo.UName = "zhangsan";

            userinfo.UPwd = "123456";

            userinfo.UGid = 3;

            //System.Web.Mvc.ViewPage

            ViewData["userinfo"] = userinfo;

            ViewData.Model = userinfo;

            return View();
        }


        public ActionResult HtmlEncodeDemos()
        {

            ViewData["StrScript"] = "<Script>alert('nijiao')</Script>";

            return View();
            
        }


    }
}
