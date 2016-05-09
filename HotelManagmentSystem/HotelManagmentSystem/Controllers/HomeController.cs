using HotelManagmentSystem.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HotelManagmentSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [CustomAuthorize(Roles = "Admin,TableManager")]
        public ActionResult Table()
        {
            return View();
        }

        [CustomAuthorize(Roles = "Admin,KitchenManager")]
        public ActionResult Kitchen()
        {
            return View();
        }

        [CustomAuthorize(Roles = "Admin,CashManager")]
        public ActionResult Cash()
        {
            return View();
        }

        [CustomAuthorize(Roles = "Admin,TableManager,KitchenManager,CashManager")]
        public ActionResult UnAuthorize()
        {
            return View();
        }

       


    }
}