namespace module4.Contracts.Queries
{
    /// <summary>
    /// Запрос получения статуса заказа.
    /// </summary>
    public class GetOrderStatusQuery
    {
        /// <summary>
        /// Id заказа.
        /// </summary>
        public int Id { get; set; }
    }
}
