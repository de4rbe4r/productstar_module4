using module4.Handlers;
using module4.Repositories.Dish;
using module4.Repositories.EventStore;
using module4.Repositories.Order;
using module4.Repositories.OrderEventStore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IOrderRepository, OrderMemoryRepository>();
builder.Services.AddSingleton<IOrderEventStore, OrderEventMemoryStore>();
builder.Services.AddSingleton<IDishRepository, DishMemoryRepository>();
builder.Services.AddSingleton<AddDishToOrderCommandHandler>();
builder.Services.AddSingleton<DeleteDishFromOrderCommandHandler>();
builder.Services.AddSingleton<GetOrdersQueryHandler>();
builder.Services.AddSingleton<GetOrderStatusQueryHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
