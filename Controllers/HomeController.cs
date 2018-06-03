using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;

using Digital8.Models;



namespace Digital8.Controllers
{
    [System.Web.Http.Authorize]
    public class HomeController : Controller
    {
        //Load main Index page for UI
        public ActionResult Index()
        {
            ViewBag.Title = "Index";

            return View();
        }

    }
}
