using Domain.Entities;
using Domain.Repositories;
using Domain.Services;
using System;
using System.Collections.Generic;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool AddProducts(Product[] products)
        {
            foreach (var product in products)
            {
                if (product.Invalid || ExistsInDatabase(product)) return false;
            }

            return _productRepository.Insert(products);
        }

        public IList<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(string id)
        {
            var guid = new Guid(id);

            return _productRepository.Get(guid);
        }

        public IList<Product> GetStockInDate(DateTime date)
        {
            return _productRepository.GetInDate(date);
        }

        public bool Remove(string[] ids)
        {
            var guids = new List<Guid>();

            foreach (var id in ids)
            {
                guids.Add(new Guid(id));
            }

            var products = _productRepository.Get(guids);

            foreach (var product in products)
            {
                product.Remove();
            }

            return _productRepository.Update(products);
        }

        private bool ExistsInDatabase(Product product)
        {
            return _productRepository.Exists(product.Id);
        }
    }
}
