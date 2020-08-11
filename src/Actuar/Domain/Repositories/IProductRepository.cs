using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IProductRepository
    {
        bool Insert(Product[] products);
        bool Exists(Guid id);
        IList<Product> GetAll();
        Product Get(Guid guid);
        List<Product> Get(List<Guid> guids);
        bool Update(List<Product> Products);
        IList<Product> GetInDate(DateTime date);
    }
}
