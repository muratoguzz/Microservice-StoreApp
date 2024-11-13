using StoreApp.Order.Application.Interfaces;
using StoreApp.Order.Domain.Entities;
using StoreApp.Order.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Order.Persistence.Repositories
{
    public class OrderingRepository : IOrderRepository
    {
        private readonly OrderContext _orderContext;
        public OrderingRepository(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }
        public List<Ordering> GetOrdersByUserId(string id)
        {
            var values = _orderContext.Orderings.Where(x => x.UserId == id).ToList();
            return values;
        }

        
    }
}
