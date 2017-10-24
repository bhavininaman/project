using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Web.Models;
using Project.Web.DAL;


namespace Project.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            ProductDAL dal = new ProductDAL();
            List<ProductModel> model = dal.GetAllProducts();
            return View("Home", model);
        }
    }
}