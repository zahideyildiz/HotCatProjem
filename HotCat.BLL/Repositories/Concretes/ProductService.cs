using HotCat.BLL.Repositories.Abstracts;
using HotCat.BLL.Repositories.Abstracts.BaseAbstract;
using HotCat.Model.Entities;

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

        public IEnumerable<Product> GetActiveProducts()
        {
            return _productRepository.GetAll().Where(x => x.IsActive == true).ToList();
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll().ToList();
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return _productRepository.GetAll().Where(x => x.CategoryId == categoryId).ToList();
        }
    }
}
