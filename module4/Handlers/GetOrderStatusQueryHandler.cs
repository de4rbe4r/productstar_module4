using module4.Contracts.Enums;
using module4.Contracts.Queries;
using module4.Repositories.Order;

namespace module4.Handlers
{
    /// <summary>
    /// Обработчик запрос получения статуса заказа.
    /// </summary>
    public class GetOrderStatusQueryHandler
    {
        private readonly IOrderRepository orderRepository;

        public GetOrderStatusQueryHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        }

        public OrderStatus Handle(GetOrderStatusQuery query)
        {
            return orderRepository.GetOrderStatus(query.Id);
        }
    }
}
