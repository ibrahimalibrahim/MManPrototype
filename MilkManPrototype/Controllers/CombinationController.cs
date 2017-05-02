using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilkManPrototype.Controllers
{
    public class CombinationController : Controller
    {
        // GET: Combination
        public ActionResult Index()
        {
            if(Request.QueryString["a"] != null)
            {
                ViewBag.Message = "تمت إضافة المادة بنجاح";
            }
            return View();
        }

        public ActionResult AddItem()
        {
            return View();
        }
    }
}