using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web.Models
{
    public class ProductModel
    {
        public int productId { get; set; }
        public string product { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public int categoryId { get; set; }
        public string imageName { get; set; }
    }
}