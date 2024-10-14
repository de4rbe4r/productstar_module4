namespace module4.Contracts.Enums
{
    /// <summary>
    /// Статус заказа.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Не определен.
        /// </summary>
        None = 0,

        /// <summary>
        /// Создан.
        /// </summary>
        Created = 1,

        /// <summary>
        /// В обработке.
        /// </summary>
        InProcess = 2,

        /// <summary>
        /// В доставке.
        /// </summary>
        InDelivery = 3,

        /// <summary>
        /// Доставлен.
        /// </summary>
        Delivered = 4,
    }
}
