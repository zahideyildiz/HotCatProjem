using HotCat.BLL.Repositories.Abstracts;
using HotCat.BLL.Repositories.Abstracts.BaseAbstract;
using HotCat.Model.Entities;

namespace HotCat.BLL.Repositories.Concretes
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IRepository<OrderDetail> _orderDetailRepository;
        public OrderDetailService(IRepository<OrderDetail> orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }
        public async Task<string> CreateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                return await _orderDetailRepository.Create(orderDetail);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            return _orderDetailRepository.GetAll();
        }
    }
}
