using MediatR;
using StoreApp.Order.Application.Features.Mediator.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Order.Application.Features.Mediator.Queries
{
    public class GetOrderingByIdQuery : IRequest<GetOrderingByIdQueryResult>
    {
        public int Id { get; set; }
        public GetOrderingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
