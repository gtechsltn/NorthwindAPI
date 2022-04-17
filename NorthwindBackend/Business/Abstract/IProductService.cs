﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetAllByCategoryId(int categoryId);
        List<Product> GetByUnitPrice(decimal min, decimal max);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
