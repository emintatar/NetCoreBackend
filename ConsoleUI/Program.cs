using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ProductTest();
            // CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            List<Category> categories = categoryManager.GetAll();

            foreach (Category category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            List<ProductDetailDto> products = productManager.GetProductDetails();

            foreach (ProductDetailDto product in products)
            {
                Console.WriteLine(product.ProductName + " - " + product.CategoryName);
            }
        }
    }
}