using Microsoft.AspNetCore.Mvc;
using module4.Contracts.Commands;
using module4.Contracts.Enums;
using module4.Contracts.Queries;
using module4.Entities.Order;
using module4.Handlers;

namespace module4.Controllers
{
    [ApiController]
    public class OrderController : Controller
    {
        private readonly AddDishToOrderCommandHandler addDishToOrderCommandHandler;
        private readonly DeleteDishFromOrderCommandHandler deleteDishFromOrderCommandHandler;
        private readonly GetOrdersQueryHandler getOrdersQueryHandler;
        private readonly GetOrderStatusQueryHandler getOrderStatusQueryHandler;

        public OrderController(AddDishToOrderCommandHandler addDishToOrderCommandHandler, DeleteDishFromOrderCommandHandler deleteDishFromOrderCommandHandler, GetOrdersQueryHandler getOrdersQueryHandler, GetOrderStatusQueryHandler getOrderStatusQueryHandler)
        {
            this.addDishToOrderCommandHandler = addDishToOrderCommandHandler;
            this.deleteDishFromOrderCommandHandler = deleteDishFromOrderCommandHandler;
            this.getOrdersQueryHandler = getOrdersQueryHandler;
            this.getOrderStatusQueryHandler = getOrderStatusQueryHandler;
        }

        [HttpPost("add-dish")]
        public void AddDish(AddDishToOrderCommand command)
        {
            addDishToOrderCommandHandler.Handle(command);
        }

        [HttpPost("remove-dish")]
        public void RemoveDish(DeleteDishFromOrderCommand command)
        {
            deleteDishFromOrderCommandHandler.Handle(command);
        }

        [HttpPost("get-order-status")]
        public OrderStatus GetOrderStatus(GetOrderStatusQuery query)
        {
            return getOrderStatusQueryHandler.Handle(query);
        }

        [HttpGet("get-all")]
        public List<OrderEntity> RemoveDish()
        {
            return getOrdersQueryHandler.Handle();
        }
    }
}
