﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var x = Request.Url.Query;

            if (Request.Files.Count >= 1)
            {
                HttpPostedFileBase f = Request.Files[0];
            }
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page no branch ecrv.";

            return View();
        } 

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}