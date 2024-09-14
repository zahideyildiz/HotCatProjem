using HotCat.Model.Entities;

namespace HotCat.BLL.Repositories.Abstracts
{
    public interface IProductService
    {
        Task<string> CreateProductAsync(Product product);

        List<Product> GetProductByCategoryId(int categoryId);

        List<Product> GetAllProducts();

        IEnumerable<Product> GetActiveProducts();
    }
}
