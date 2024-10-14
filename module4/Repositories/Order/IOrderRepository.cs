using module4.Contracts.Enums;
using module4.Entities.Dish;
using module4.Entities.Order;

namespace module4.Repositories.Order
{
    /// <summary>
    /// Предоставляет методы для работы с заказом.
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Добавление блюда в заказ.
        /// </summary>
        /// <param name="id">Id заказа.</param>
        /// <param name="dish">Блюдо.</param>
        void AddDishToOrder(long id, DishEntity dish);

        /// <summary>
        /// Удаление блюда из заказа.
        /// </summary>
        /// /// <param name="id">Id заказа.</param>
        /// <param name="dishId">Id блюда</param>
        void DeleteDishFromOrder(long id, long dishId);

        /// <summary>
        /// Получение стоимости заказа.
        /// </summary>
        /// <param name="id">Id заказа.</param>
        /// <returns>Полная стоимость заказа.</returns>
        decimal GetTotalPriceOrder(long id);

        /// <summary>
        /// Получение статуса заказа.
        /// </summary>
        /// <param name="id">Id заказа.</param>
        /// <returns>Статус заказа.</returns>
        OrderStatus GetOrderStatus(long id);

        /// <summary>
        /// Получение списка заказов.
        /// </summary>
        /// <returns>Список заказов.</returns>
        List<OrderEntity> GetOrders();
    }
}
