﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Team_CodeProjectV1.Controllers
	{
	public class HomeController : Controller
		{
		public ActionResult Index ()
			{
			return View();
			}

		public ActionResult About ()
			{
			ViewBag.Message = "Your application description page.";

			return View();
			}

		public ActionResult Contact ()
			{
			ViewBag.Message = "Your contact page.";

			return View();
			}
        public ActionResult Customer()
        {
            ViewBag.Message = "Your customer page.";

            return View();
        }

		public ActionResult Restaurant ()
			{
			ViewBag.Message = "Your Restaurant Page";
			return View();
			}
    }
	}