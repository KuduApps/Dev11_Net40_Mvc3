﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dev11_Net40_Mvc3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Dev11 Mvc3 application targetting Fx4.0";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
