using module4.Contracts.Commands;
using module4.Events;
using module4.Repositories.EventStore;
using module4.Repositories.Order;

namespace module4.Handlers
{
    /// <summary>
    /// Обработчик команды добавления блюда в заказ.
    /// </summary>
    public class AddDishToOrderCommandHandler
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderEventStore orderEventStore;

        public AddDishToOrderCommandHandler(IOrderRepository orderRepository, IOrderEventStore orderEventStore)
        {
            this.orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            this.orderEventStore = orderEventStore ?? throw new ArgumentNullException(nameof(orderEventStore));
        }

        public void Handle(AddDishToOrderCommand command)
        {
            orderRepository.AddDishToOrder(command.Id, new Entities.Dish.DishEntity
            {
                Title = command.Title,
                Price = command.Price,
            });
            var addEvent = new AddDishToOrderEvent(new Entities.Dish.DishEntity
            {
                Title = command.Title,
                Price = command.Price,
            });
            orderEventStore.SaveEvent(addEvent);
        }
    }
}
