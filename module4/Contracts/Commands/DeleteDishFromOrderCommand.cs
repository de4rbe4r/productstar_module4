namespace module4.Contracts.Commands
{
    /// <summary>
    /// Команда удаления блюда из заказ.
    /// </summary>
    public class DeleteDishFromOrderCommand
    {
        /// <summary>
        /// Id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Id блюда.
        /// </summary>
        public long DishId{ get; set; }
    }
}
