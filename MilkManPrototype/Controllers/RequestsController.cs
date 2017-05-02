using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilkManPrototype.Controllers
{
    public class RequestsController : Controller
    {
        // GET: Requests
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            if (Request.QueryString["a"] != null)
            {
                ViewBag.Message = "تمت إضافة الطلبية بنجاح";
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Details2()
        {
            return View();
        }

        public ActionResult Plan()
        {
            return View();
        }

        public ActionResult PlanDetails()
        {
            return View();
        }

        public ActionResult Close()
        {
            return View();
        }
    }
}