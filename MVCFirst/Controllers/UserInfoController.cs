using MVCFirst.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class UserInfoController : Controller
    {
        //
        // GET: /UserInfo/

        public ActionResult Index()
        {

            //获取数据库中的用户信息

            //然后传递到前台展示


            DataTable dt = SqlHelper.ExecuteDataTable("select * from TbUser",null);

            ViewData["dt"] = dt;

            return View();
        }


        public ActionResult Add()
        {

            return View();
 
        }


        [HttpPost]
        public ActionResult Add(FormCollection form)
        {

            var useranme = form["username"];

            var pwd = form["pwd"];

            if (!string.IsNullOrEmpty(useranme)
                && !string.IsNullOrEmpty(pwd))
            {

                int result=Convert.ToInt32(SqlHelper.ExecuteNonQuery("Insert into tbuser(uname,upwd,UGid) values(@uname,@upwd,@ugid)", new SqlParameter("@uname", useranme), new SqlParameter("@upwd", pwd), new SqlParameter("@ugid", 1)));

                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

                
            }
            else
            {
                return View();
            }

           

        }



        
        public ActionResult Delete(int id)
        {
           
                int result= SqlHelper.ExecuteNonQuery("delete from Tbuser where Uid=@id", new SqlParameter("@id", id));

                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return Content("删除失败");
                }
          



        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            DataTable dt = SqlHelper.ExecuteDataTable("Select * from tbUser where Uid=@id", new SqlParameter("@id", id));

            UserInfo user = new UserInfo();

            if (dt != null)
            {
               

                user.UId =Convert.ToInt32(dt.Rows[0]["Uid"]);

                user.UName = dt.Rows[0]["Uname"].ToString();

                user.UPwd = dt.Rows[0]["Upwd"].ToString();

                user.UGid = Convert.ToInt32(dt.Rows[0]["UGid"]);
            }

            ViewData.Model = user;

            return View();

        }


        [HttpPost]
        public ActionResult Edit(int UId, string UName, string UPwd, int UGid, UserInfo userInfo)
        {

            string sql = "update tbuser set UName=@uname,Upwd=@upwd,Ugid=@ugid where Uid=@id";

            Convert.ToInt32(SqlHelper.ExecuteScalar(sql, new SqlParameter("@Uname", userInfo.UName), new SqlParameter("@id", userInfo.UId), new SqlParameter("@upwd", userInfo.UPwd), new SqlParameter("@ugid", userInfo.UGid)));



            return RedirectToAction("Index");



        }


    }
}
