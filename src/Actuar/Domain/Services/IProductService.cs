using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface IProductService
    {
        IList<Product> GetAll();
        Product GetById(string id);
        IList<Product> GetStockInDate(DateTime date);
        bool AddProducts(Product[] products);
        bool Remove(string[] ids);
    }
}
