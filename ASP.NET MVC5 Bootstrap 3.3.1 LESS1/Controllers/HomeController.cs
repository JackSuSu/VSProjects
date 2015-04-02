using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC5_Bootstrap3_3_1_LESS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "首页";

            return View();
        }

        public ActionResult About()
        {

            ViewBag.Message = "网站描述页面";

            return View();

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "网站关于页面";

            return View();
        }
    }
}