﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class FruitsController : Controller
    {
        // GET: Fruits
        public ActionResult Index()
        {
            return View("Fruits");
        }
    }
}