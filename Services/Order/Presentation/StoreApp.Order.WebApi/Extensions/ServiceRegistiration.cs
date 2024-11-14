using StoreApp.Order.Application.Features.CQRS.Handlers.AddressHandlers;
using StoreApp.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;
using StoreApp.Order.Application.Features.Mediator.Handlers;

namespace StoreApp.Order.WebApi.Extensions
{
    public static class ServiceRegistiration
    {
        public static void AddApplicationService(this IServiceCollection services, IConfiguration configuration)
        {
            
            //region Address Handlers
            services.AddScoped<GetAddressQueryHandler>();
            services.AddScoped<GetAddressByIdQueryHandler>();
            services.AddScoped<CreateAddressCommandHandler>();
            services.AddScoped<UpdateAddressCommandHandler>();
            services.AddScoped<RemoveAddressCommandHandler>();
            //endregion

            //region OrderDetail Handlers
            services.AddScoped<GetOrderDetailQueryHandler>();
            services.AddScoped<GetOrderDetailByIdQueryHandler>();
            services.AddScoped<CreateOrderDetailCommandHandler>();
            services.AddScoped<UpdateOrderDetailCommandHandler>();
            services.AddScoped<RemoveOrderDetailCommandHandler>();
            //endregion
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateOrderingCommandHandler>());
        }
    }
}
