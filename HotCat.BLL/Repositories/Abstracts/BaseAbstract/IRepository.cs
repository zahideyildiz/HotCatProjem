using HotCat.Model.Base;

namespace HotCat.BLL.Repositories.Abstracts.BaseAbstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        //IEnumerable: İçerisinde barındırılan listeyi ve istenildiği zaman o liste içerisinde de ayrı bir listeyi barındıran özelleştirilmiş bir interface. Yani iç içe geçmiş birden fazla listenin barındırılmasına olanak sağlayan bir interfacetir. İçerisinde barındırmış olduğu liste elemanını döngüye ihtiyaç duymadana geriye döndürülmesini sağlar.

        //List: İçerisinde tekil değerler barındırır. Döngüye ihtiyaç duyar.
        IEnumerable<T> GetAll(); 

        //Get

        T GetById(int id);

        //Active

        IEnumerable<T> GetActives();

        //Passive

        IEnumerable<T> GetPassives();

        //kullanıcı tarafından değer istenmeyenler senkron, değer istenilenler async

        //Destroy

        Task<string> DestroyData(T entity);

        //Create

        Task<string> Create(T entity);

        //Update

        Task<string> Update(T entity);

        //Delete

        Task<string> Delete(T entity);

        
    }
}
