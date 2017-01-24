using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class ProductDB
    {
        public static List<Product> GetAllProducts()
        {
            ProductDatabase PdDb = new ProductDatabase();
            List<Product> allProds = (from p in PdDb.Products
                                      select p).ToList();
            return allProds;
        }
        public static void AddProduct(Product product)
        {
            ProductDatabase PdDb = new ProductDatabase();
            PdDb.Products.Add(product);
            PdDb.SaveChanges();
           
        }
    }
}