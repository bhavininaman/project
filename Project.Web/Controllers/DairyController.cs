﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class DairyController : Controller
    {
        // GET: Dairy
        public ActionResult Index()
        {
            return View("Dairy");
        }
    }
}