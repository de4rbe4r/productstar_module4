using module4.Contracts.Enums;
using module4.Entities.Dish;
using module4.Events;

namespace module4.Entities.Order
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class OrderEntity
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Блюда.
        /// </summary>
        public List<DishEntity> Dishes { get; set; }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Итоговая сумма заказа.
        /// </summary>
        public decimal TotalPrice { get; set; }

        public OrderEntity(List<OrderEvent> events)
        {
            foreach (var orderEvent in events)
            {
                Apply(orderEvent);
            }
        }

        private void Apply(OrderEvent orderEvent)
        {
            switch (orderEvent)
            {
                case AddDishToOrderEvent addDishToOrderEvent:
                    Dishes.Add(addDishToOrderEvent.Dish);
                    break;
                case RemoveDishFromOrderEvent removeDishFromOrderEvent:
                    var removedItem = Dishes.FirstOrDefault(d => d.Id == removeDishFromOrderEvent.DishId);
                    if (removedItem == null)
                    {
                        break;
                    }

                    Dishes.Remove(removedItem);
                    break;
            }
        }
    }
}
