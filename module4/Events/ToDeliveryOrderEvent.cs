namespace module4.Events
{
    /// <summary>
    /// Событие передачи заказа в доставку.
    /// </summary>
    public class ToDeliveryOrderEvent : OrderEvent
    {
        public ToDeliveryOrderEvent() : base() { }
    }
}
