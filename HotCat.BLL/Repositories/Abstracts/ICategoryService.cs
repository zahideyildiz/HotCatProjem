using HotCat.Model.Entities;

namespace HotCat.BLL.Repositories.Abstracts
{
    public interface ICategoryService
    {
        //Category ile ilgili işlemler bu interface'te tanımlanacak
        IEnumerable<Category> GetAllCategories();

        Category GetCategoryById(int id); //id ile kategori çağırmamızı sağlayacaktır

        Task<string> CreateCategory(Category category); //kullanıcı istekleri async olarak tanımlandı

        Task<string> DeleteCategory(Category category);

        Task<string> UpdateCategory(Category category);

        IEnumerable<Category> GetActiveCategories();

        IEnumerable<Category> GetPassiveCategories();

        Task<string> DestroyCategory(Category category);
    }
}
