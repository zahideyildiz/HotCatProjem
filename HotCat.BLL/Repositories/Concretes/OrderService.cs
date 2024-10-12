using HotCat.BLL.Repositories.Abstracts;
using HotCat.BLL.Repositories.Abstracts.BaseAbstract;
using HotCat.Model.Entities;

namespace HotCat.BLL.Repositories.Concretes
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<string> CreateOrder(Order order)
        {
            try
            {
                return await _orderRepository.Create(order);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }
    }
}
