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
        private string SQL_GetId = "Select * from products where products.id = @id";
        private string SQL_GetAllProducts = "select * from products;";
        private string SQL_GetCategory = "select * from products where products.category_id = @categoryID";


        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> output = new List<ProductModel>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
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
            catch (SqlException)
            {
                throw;
            }

            return output;
        }
        public ProductModel GetProduct(int id)
        {
            ProductModel product = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetId, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    ProductModel p = new ProductModel();
                    p.productId = Convert.ToInt32(reader["id"]);
                    p.product = Convert.ToString(reader["product"]);
                    p.price = Convert.ToDouble(reader["price"]);
                    p.description = Convert.ToString(reader["description"]);
                    p.categoryId = Convert.ToInt32(reader["category_id"]);
                    p.imageName = Convert.ToString(reader["image"]);

                    product = p;

                    return product;

                }
            }
            catch (SqlException)
            {
                throw;
            }
         

        }

        public List<ProductModel> GetCategory(int id)
        {
            List<ProductModel> product = new List<ProductModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_GetCategory, conn);
                    cmd.Parameters.AddWithValue("categoryID", id);
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
                        product.Add(p);
                    }
                }
            }
            catch
            {
                throw;
            }
            return product;
        }

    }
}

