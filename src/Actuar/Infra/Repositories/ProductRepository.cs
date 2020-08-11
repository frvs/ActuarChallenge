using Domain.Entities;
using Domain.Repositories;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private DataContext _dataContext;

        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool Exists(Guid id)
        {
            return _dataContext.Product.Find(id) != null;
        }

        public Product Get(Guid guid)
        {
            return _dataContext.Product.Find(guid);
        }

        public List<Product> Get(List<Guid> guids)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            return _dataContext.Product.ToList();
        }

        public IList<Product> GetInDate(DateTime date)
        {
            var products = _dataContext.Product.Where(product => product.RegisterDate > date && product.ExitDate < date).ToList();

            return products;
        }

        public bool Insert(Product[] products)
        {
            _dataContext.AddRange(products);
            return _dataContext.SaveChanges() == products.Length;
        }

        public bool Update(List<Product> products)
        {
            _dataContext.Product.UpdateRange(products);
            return _dataContext.SaveChanges() == products.Count;
        }
    }
}
