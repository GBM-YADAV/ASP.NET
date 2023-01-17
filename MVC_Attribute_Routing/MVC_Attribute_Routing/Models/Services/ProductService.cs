using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Attribute_Routing.Models.Services
{
    public class ProductService
    {

        public static List<Product> productlist = new List<Product>();

        static ProductService()
        {
            productlist = new List<Product>();
            productlist.Add(new Product() { ProductId = 101, ProductName = "chair", ProductPrice = 1000, proCate = "wood" });
            productlist.Add(new Product() { ProductId = 102, ProductName = "stand", ProductPrice = 1000, proCate = " iron" });
            productlist.Add(new Product() { ProductId = 103, ProductName = "car", ProductPrice = 4000, proCate = "vehicle" });
            productlist.Add(new Product() { ProductId = 104, ProductName = "chair", ProductPrice = 1000, proCate = "wood " });
            productlist.Add(new Product() { ProductId = 105, ProductName = "stand", ProductPrice = 1000, proCate = "iron " });
            productlist.Add(new Product() { ProductId = 106, ProductName = "car", ProductPrice = 4000, proCate = "vehicle " });


        }

        public static List<Product> GetProducts()
        {
            return productlist;
        }
        public static Product GetProduct(int GivenId)
        {
            //select *from customer
            return productlist.FirstOrDefault(pro => pro.ProductId == GivenId);
        }
    }
}
