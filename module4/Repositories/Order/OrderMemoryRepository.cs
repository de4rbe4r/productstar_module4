using module4.Contracts.Enums;
using module4.Entities.Dish;
using module4.Entities.Order;

namespace module4.Repositories.Order
{
    public class OrderMemoryRepository : IOrderRepository
    {
        private List<OrderEntity> orders;

        public OrderMemoryRepository()
        {
            orders = new List<OrderEntity>
            {
                new OrderEntity(new List<Events.OrderEvent>())
                {
                    Id = 1,
                    OrderStatus = OrderStatus.Created,
                    TotalPrice = (decimal)356.55,
                    Dishes = new List<DishEntity>
                    {
                        new DishEntity
                          {
                            Id = 1,
                            Title = "Блюдо 1",
                            Price = (decimal)100.25,
                        },
                        new DishEntity
                        {
                            Id = 2,
                            Title = "Блюдо 2",
                            Price = (decimal)200.55,
                        },
                        new DishEntity
                        {
                            Id = 3,
                            Title = "Блюдо 3",
                            Price = (decimal)55.75,
                        },
                    }, 
                },
                new OrderEntity(new List<Events.OrderEvent>())
                {
                    Id = 2,
                    OrderStatus = OrderStatus.Created,
                    TotalPrice = (decimal)356.55,
                    Dishes = new List<DishEntity>
                    {
                        new DishEntity
                          {
                            Id = 1,
                            Title = "Блюдо 1",
                            Price = (decimal)100.25,
                        },
                        new DishEntity
                        {
                            Id = 2,
                            Title = "Блюдо 2",
                            Price = (decimal)200.55,
                        },
                        new DishEntity
                        {
                            Id = 3,
                            Title = "Блюдо 3",
                            Price = (decimal)55.75,
                        },
                    },

                }
            };
        }

        public void AddDishToOrder(long id,DishEntity dish)
        {
            var editedOrder = orders.FirstOrDefault(o => o.Id == id);

            if (editedOrder != null)
            {
                editedOrder.Dishes.Add(dish);
                editedOrder.TotalPrice += dish.Price;
            }
        }

        public void DeleteDishFromOrder(long id, long dishId)
        {
            var editedOrder = orders.FirstOrDefault(o => o.Id == id);

            if (editedOrder != null)
            {
                var deletedDish = editedOrder.Dishes.FirstOrDefault(d => d.Id == dishId);
                if (deletedDish != null)
                {
                    editedOrder.Dishes.Remove(deletedDish);
                    editedOrder.TotalPrice -= deletedDish.Price;
                }
            }
        }

        public List<OrderEntity> GetOrders()
        {
            return orders;
        }

        public OrderStatus GetOrderStatus(long id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);

            if (order == null)
            {
                return OrderStatus.None;
            }

            return order.OrderStatus;
        }

        public decimal GetTotalPriceOrder(long id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);

            if (order == null)
            {
                return 0;
            }

            return order.TotalPrice;
        }
    }
}
