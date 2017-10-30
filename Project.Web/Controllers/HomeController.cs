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

        public ActionResult Dairy(int id)
        {
            ProductDAL dal = new ProductDAL();
            List<ProductModel> dairy = dal.GetCategory(id);
            return View("Dairy", dairy);
        }
        public ActionResult Bread(int id)
        {
            ProductDAL dal = new ProductDAL();
            List<ProductModel> model = dal.GetCategory(id);
            return View("Bread", model);
        }
        public ActionResult Fruits(int id)
        {
            ProductDAL dal = new ProductDAL();
            List<ProductModel> model = dal.GetCategory(id);
            return View("Fruits", model);
        }
        public ActionResult Vegetables(int id)
        {
            ProductDAL dal = new ProductDAL();
            List<ProductModel> model = dal.GetCategory(id);
            return View("Vegetables", model);
        }
        public ActionResult PicSupplies(int id)
        {
            ProductDAL dal = new ProductDAL();
            List<ProductModel> model = dal.GetCategory(id);
            return View("PicSupplies", model);
        }

        public ActionResult Detail(int id)
        {
            ProductDAL dal = new ProductDAL();
            ProductModel item = dal.GetProduct(id);
            return View("Detail", item);

        }
    }
}