using HotCat.Model.Entities;

namespace HotCat.BLL.Repositories.Abstracts
{
    public interface IOrderDetailService
    {
        //List

        IEnumerable<OrderDetail> GetOrderDetails();

        //Create

        Task<string> CreateOrderDetail(OrderDetail orderDetail);
    }
}
