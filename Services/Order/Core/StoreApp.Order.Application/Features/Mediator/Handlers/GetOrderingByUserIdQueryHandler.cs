using MediatR;
using StoreApp.Order.Application.Features.Mediator.Queries;
using StoreApp.Order.Application.Features.Mediator.Results;
using StoreApp.Order.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Order.Application.Features.Mediator.Handlers
{
    public class GetOrderingByUserIdQueryHandler : IRequestHandler<GetOrderingByUserIdQuery, List<GetOrderingByUserIdQueryResult>>
    {
        private readonly IOrderRepository _orderingRepository;
        public GetOrderingByUserIdQueryHandler(IOrderRepository orderingRepository)
        {
            _orderingRepository = orderingRepository;
        }
        public async Task<List<GetOrderingByUserIdQueryResult>> Handle(GetOrderingByUserIdQuery request, CancellationToken cancellationToken)
        {
            var values = _orderingRepository.GetOrdersByUserId(request.Id);
            return values.Select(x => new GetOrderingByUserIdQueryResult
            {
                OrderDate = x.OrderDate,
                OrderingId = x.OrderingId,
                TotalPrice = x.TotalPrice,
                UserId = x.UserId
            }).ToList();
        }
    }
}
