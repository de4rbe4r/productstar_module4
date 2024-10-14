using module4.Events;
using module4.Repositories.EventStore;

namespace module4.Repositories.OrderEventStore
{
    /// <inheritdoc/>
    public class OrderEventMemoryStore : IOrderEventStore
    {
        private List<OrderEvent> _orderEvents;

        public OrderEventMemoryStore()
        {
            _orderEvents = new List<OrderEvent>();
        }

        public void SaveEvent(OrderEvent orderEvent)
        {
            _orderEvents.Add(orderEvent);
        }
    }
}
