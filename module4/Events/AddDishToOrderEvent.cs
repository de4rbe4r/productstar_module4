using module4.Entities.Dish;

namespace module4.Events
{
    /// <summary>
    /// Событие добавления блюда в заказ.
    /// </summary>
    public class AddDishToOrderEvent: OrderEvent
    {
        /// <summary>
        /// Блюдо.
        /// </summary>
        public DishEntity Dish { get; set; }

        public AddDishToOrderEvent(DishEntity dish)
            : base()
        {
            Dish = dish;
        }
    }
}
