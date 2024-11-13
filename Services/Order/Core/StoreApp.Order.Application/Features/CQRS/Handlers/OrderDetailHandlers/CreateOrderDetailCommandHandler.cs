using StoreApp.Order.Application.Features.CQRS.Commands.OrderDEtailCommands;
using StoreApp.Order.Application.Interfaces;
using StoreApp.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateOrderDetailCommand command)
        {
            await _repository.CreateAsync(new OrderDetail
            {
                ProductAmount = command.ProductAmount,
                OrderId = command.OrderingId,
                ProductId = command.ProductId,
                ProductName = command.ProductName,
                ProductPrice = command.ProductPrice,
                ProductTotalPrice = command.ProductTotalPrice
            });
        }
    }
}
