namespace module4.Events
{
    /// <summary>
    /// Событие для заказа.
    /// </summary>
    public abstract class OrderEvent
    {
        /// <summary>
        /// Id.
        /// </summary>
        public Guid OrderId { get; }

        /// <summary>
        /// Дата события.
        /// </summary>
        public DateTime Date { get; }

        protected OrderEvent()
        {
            OrderId = Guid.NewGuid();
            Date = DateTime.Now;
        }
    }
}
