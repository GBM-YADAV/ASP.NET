using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MVC_In_Memory_crud_Operations.Models.Services
{
    static public class ProductService
    {
        public static List<Product> productlist = new List<Product>();

        static ProductService()
        {
            productlist = new List<Product>();
            productlist.Add(new Product() { ProductId = 101, ProductName = "chair", ProductPrice = 1000, proCate = "wood" });
            productlist.Add(new Product() { ProductId = 102, ProductName = "stand", ProductPrice = 1000, proCate = " iron" });
            productlist.Add(new Product() { ProductId = 103, ProductName = "car", ProductPrice = 4000, proCate = "vehicle" });
            productlist.Add(new Product() { ProductId = 104, ProductName = "chair", ProductPrice = 1000, proCate = "wood "});
            productlist.Add(new Product() { ProductId = 105, ProductName = "stand", ProductPrice = 1000, proCate = "iron "});
            productlist.Add(new Product() { ProductId = 106, ProductName = "car", ProductPrice = 4000, proCate = "vehicle "});

        
        }

        public static List<Product> GetProducts()
        {
            return productlist;
        }
        //get single customer
        public static Product GetProduct(int GivenId)
        {
            //select *from customer
            return productlist.FirstOrDefault(pro => pro.ProductId == GivenId);
        }

       
        public static void UpdateProduct(Product product)
        {
           int indexOfProduct= productlist.FindIndex(p => p.ProductId == product.ProductId);
            productlist[indexOfProduct] = product;

        }
        public
        static int nextid = 107;
        public static void AddProduct(Product NewProduct)
        {
            NewProduct.ProductId = nextid;
            productlist.Add(NewProduct);
            nextid++;
        }
        [HttpGet]
        public static void DeleteProduct(int id)
        {
            Product product = GetProduct(id);   
            if (product != null)
            {
                productlist.Remove(product);
            }
           

        }

        internal static void UpdateProduct(int id,Product modifiedProduct)
        {
            throw new NotImplementedException();
        }
    }
}
