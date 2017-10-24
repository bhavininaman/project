using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Web.Models;
using System.Data.SqlClient;
using System.Configuration;


namespace Project.Web.DAL
{
    public class ProductDAL 
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["onlineStore"].ConnectionString;
        private string SQL_GetId = "Select * from product where products.category_id = @id";
        private string SQL_GetAllProducts = "select * from products;";
       

        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> output = new List<ProductModel>();
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetAllProducts, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ProductModel p = new ProductModel();
                        p.productId = Convert.ToInt32(reader["id"]);
                        p.product = Convert.ToString(reader["product"]);
                        p.price = Convert.ToDouble(reader["price"]);
                        p.description = Convert.ToString(reader["description"]);
                        p.categoryId = Convert.ToInt32(reader["category_id"]);
                        p.imageName = Convert.ToString(reader["image"]);

                        output.Add(p);


                    }
                }
            }
            catch(SqlException)
            {
                throw;
            }

            return output;
        }
    }
}

