using module4.Entities.Order;
using module4.Repositories.Order;

namespace module4.Handlers
{
    /// <summary>
    /// Обработчик получения списка заказов.
    /// </summary>
    public class GetOrdersQueryHandler
    {
        private readonly IOrderRepository orderRepository;

        public GetOrdersQueryHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        }

        public List<OrderEntity> Handle()
        {
            return orderRepository.GetOrders();
        }
    }
}
