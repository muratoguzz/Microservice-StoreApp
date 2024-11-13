using MediatR;
using StoreApp.Order.Application.Features.Mediator.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Order.Application.Features.Mediator.Queries
{
    public class GetOrderingByUserIdQuery : IRequest<List<GetOrderingByUserIdQueryResult>>
    {
        public string Id { get; set; }
        public GetOrderingByUserIdQuery(string id)
        {
            Id = id;
        }
    }
}
