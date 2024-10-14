using module4.Contracts.Commands;
using module4.Events;
using module4.Repositories.EventStore;
using module4.Repositories.Order;

namespace module4.Handlers
{
    /// <summary>
    /// Обработчик команды удаления блюда из заказа.
    /// </summary>
    public class DeleteDishFromOrderCommandHandler
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderEventStore orderEventStore;


        public DeleteDishFromOrderCommandHandler(IOrderRepository orderRepository, IOrderEventStore orderEventStore)
        {
            this.orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            this.orderEventStore = orderEventStore ?? throw new ArgumentNullException(nameof(orderEventStore));
        }

        public void Handle(DeleteDishFromOrderCommand command)
        {
            orderRepository.DeleteDishFromOrder(command.Id, command.DishId);
            var removeEvent = new RemoveDishFromOrderEvent(command.Id);
            orderEventStore.SaveEvent(removeEvent);
        }
    }
}
