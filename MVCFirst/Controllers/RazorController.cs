using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class RazorController : Controller
    {
        //
        // GET: /Razor/

        
        /// <summary>
        /// 
        /// ViewResult 找到视图页面返回
        /// 
        /// </summary>
        /// <returns></returns>

        public ActionResult Index()
        {

            ViewData["date"] = DateTime.Now.ToString();

            HttpContext.Application["all"] = DateTime.Now.ToString();

            ViewData["allvist"] = HttpContext.Application["UserVisit"].ToString();

            if (Session["User"] != null)
            {
                ViewData["userid"] = Session["user"];

                if (Request.Cookies["userid"] != null)
                {
                    ViewData["Cookie"] = Request.Cookies["Cookie"];
                }

               
              
            }
            else
            {
                Session["User"] = 123;

                HttpCookie htp = new HttpCookie("Cookie");

                htp.Expires=DateTime.Now.Add(new TimeSpan(50000));

              

                //ViewData["1"]=HttpContext.Application.GetKey(0)
             

                Response.SetCookie(htp);

            }

            

            return View();
        }


        public ActionResult Demo()
        {
            return View();
        }



        /// <summary>
        /// 
        /// 创建一个字符串使用
        /// 
        /// 返回：ContentResult
        /// 
        /// </summary>
        /// <returns></returns>

        public ActionResult ContentResultDemo()
        {
            return Content("ConentResult");
        }


        /// <summary>
        /// 
        /// 返回空的Result
        /// 
        /// EmptyResult
        /// 
        /// </summary>
        /// <returns></returns>

        public ActionResult EmptyResultDemo()
        {
            return new EmptyResult();
        }



        /// <summary>
        /// 
        /// 返回一个文件流对象
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult FileContentResultDemo()
        {
            FileStream fs = new FileStream(Server.MapPath(@"/Images/1.jpg"), FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[Convert.ToInt32(fs.Length)];
            fs.Read(buffer, 0, Convert.ToInt32(fs.Length));
            return File(buffer, @"image/gif");
          
        }


        /// <summary>
        /// 
        /// 返回一个文件使用 文件路径显示
        /// 
        /// File的各种重载
        /// 
        /// </summary>
        /// <returns></returns>
        
        public ActionResult FilePathResultDemo()
        {
            //可以将一个jpg格式的图像输出为gif格式

            return File(Server.MapPath(@"/resource/Images/2.jpg"), @"image/gif");
        }

        /// <summary>
        /// 
        /// FileStreamContent的重载
        /// 
        /// </summary>
        /// <returns></returns>
        
        public ActionResult FileStreamResultDemo()
        {
            FileStream fs = new FileStream(Server.MapPath(@"/Images/1.jpg"), FileMode.Open, FileAccess.Read);
            return File(fs, @"image/jpeg");
        }

        /// <summary>
        /// 
        /// 为验证的处理
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult HttpUnauthorizedResultDemo()
        {

            //返回一个未验证的提示 401 验证不同

            return new HttpUnauthorizedResult();
        }

        /// <summary>
        /// 
        ///  返回一个客户端脚本
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult JavaScriptResultDemo()
        {

            //只有在异步的情况下使用

            //异步的情况下使用

            return JavaScript(@"alert(""Test JavaScriptResultDemo!"")");
        }




        /// <summary>
        /// 
        /// 返回Jason数据
        /// 
        /// </summary>
        /// <returns></returns>
       
        public ActionResult JsonResultDemo()
        {

            var tempObj = new { Controller = "DemoController", Action = "JsonResultDemo" };

            return Json(tempObj,JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 
        /// 重置Action
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult RedirectResultDemo()
        {

            return Redirect("Index");

        }

        /// <summary>
        /// 
        /// 其他控制器下的Action
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult RedirectToRouteResultDemo()
        {

            return RedirectToAction(@"FileStreamResultDemo");

        }

        /// <summary>
        /// 
        /// 返回一个部分视图
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult PartialViewResultDemo()
        {
            return PartialView();
        }

      

    }
}
