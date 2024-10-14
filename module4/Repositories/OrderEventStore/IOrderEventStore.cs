using module4.Events;

namespace module4.Repositories.EventStore
{
    /// <summary>
    /// Предоставляет методы для работы с собятями заказа.
    /// </summary>
    public interface IOrderEventStore
    {
        /// <summary>
        /// Сохданить событие.
        /// </summary>
        /// <param name="orderEvent">Событие заказа.</param>
        void SaveEvent(OrderEvent orderEvent);
    }
}
