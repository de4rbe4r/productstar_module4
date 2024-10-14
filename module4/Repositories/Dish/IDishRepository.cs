using module4.Entities.Dish;

namespace module4.Repositories.Dish
{
    /// <summary>
    /// Предоставляет методы работы с БД для сущности блюдо.
    /// </summary>
    internal interface IDishRepository
    {
        /// <summary>
        /// Добавить блюдо.
        /// </summary>
        /// <param name="dish">Блюдо.</param>
        /// <returns>Id созданной сущности</returns>
        long Add(DishEntity dish);

        /// <summary>
        /// Удаление блюда.
        /// </summary>
        /// <param name="id">Id блюда.</param>
        /// <returns>Признак удаления.</returns>
        bool Delete(long id);
    }
}
