﻿using HotCat.BLL.Repositories.Abstracts;
using HotCat.BLL.Repositories.Abstracts.BaseAbstract;
using HotCat.Model.Entities;
using HotCat.Model.Enums;

namespace HotCat.BLL.Repositories.Concretes
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<string> CreateProductAsync(Product product)
        {
            return await _productRepository.Create(product);
        }

        public async Task<string> DeleteProductAsync(Product product)
        {
            return await _productRepository.Delete(product);
        }

        public IEnumerable<Product> GetActiveProducts()
        {
            return _productRepository.GetAll().Where(x => x.IsActive == true).ToList();
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll().ToList();
        }

        public IEnumerable<Product> GetPassiveProducts()
        {
            return _productRepository.GetAll().Where(x => !x.IsActive).ToList();
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return _productRepository.GetAll().Where(x => x.CategoryId == categoryId).ToList();
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var product =  _productRepository.GetById(productId);
            return product;
        }

        public List<Product> GetProductsByStatus(DataStatus status)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateProductAsync(Product product)
        {
            return _productRepository.Update(product);
        }
    }
}
