using HotCat.Model.Entities;

namespace HotCat.BLL.Repositories.Abstracts
{
    public interface IOrderService
    {

        //List
        IEnumerable<Order> GetAllOrders();

        //Create
        Task<string> CreateOrder (Order order);

        //Get
        Order GetOrderById(int id);


    }
}
