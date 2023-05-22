﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            // Business check
            // Authorization check

            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _productDal.GetAllByCategory(categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}