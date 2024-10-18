using HotCat.Model.Entities;
using HotCat.Model.Enums;

namespace HotCat.BLL.Repositories.Abstracts
{
    public interface IProductService
    {

        List<Product> GetAllProducts();
       
        List<Product> GetProductByCategoryId(int categoryId);

        Task<Product> GetProductByIdAsync(int productId);

        List<Product> GetProductsByStatus(DataStatus status);

        Task<string> CreateProductAsync(Product product);
        Task<string> UpdateProductAsync(Product product);
        Task<string> DeleteProductAsync(Product product);

        IEnumerable<Product> GetActiveProducts();

        IEnumerable<Product> GetPassiveProducts();


    }
}
