using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
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
            // ProductTest();
            // CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            var dataResult = categoryManager.GetAll();
            var categories = dataResult.Data;

            foreach (Category category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var dataResult = productManager.GetProductDetails();
            var productsData = dataResult.Data;

            if (dataResult.Success)
            {
                foreach (var product in productsData)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }

            else
            {
                Console.WriteLine(dataResult.Message);
            }
        }
    }
}