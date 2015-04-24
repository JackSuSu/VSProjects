using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class RazorController : Controller
    {
        //
        // GET: /Razor/

        public ActionResult Index()
        {

            ViewData["date"] = DateTime.Now.ToString();

            return View();
        }

    }
}
