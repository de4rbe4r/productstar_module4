namespace module4.Contracts.Commands
{
    /// <summary>
    /// Команда добавления блюда в заказ.
    /// </summary>
    public class AddDishToOrderCommand
    {
        /// <summary>
        /// Id заказа.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Стоимость блюда
        /// </summary>
        public decimal Price { get; set; }
    }
}
