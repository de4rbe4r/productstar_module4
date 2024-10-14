namespace module4.Events
{
    /// <summary>
    /// Событие удаления блюда из заказа.
    /// </summary>
    public class RemoveDishFromOrderEvent : OrderEvent
    {
        /// <summary>
        /// Блюдо.
        /// </summary>
        public long DishId { get; set; }

        public RemoveDishFromOrderEvent(long dishId)
            : base()
        {
            DishId = dishId;
        }
    }
}
