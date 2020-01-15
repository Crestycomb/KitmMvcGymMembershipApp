using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymMembership.Controllers
{
    [AllowAnonymous]
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Naujienų puslapis.";

            return View();
        }
    }
}