namespace module4.Entities.Dish
{
    /// <summary>
    /// Блюдо.
    /// <remarks> Для хранения в БД.</remarks>
    /// </summary>
    public class DishEntity
    {
        /// <summary>
        /// Id.
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
