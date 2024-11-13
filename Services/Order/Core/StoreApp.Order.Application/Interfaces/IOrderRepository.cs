using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Order.Domain.Entities;

namespace StoreApp.Order.Application.Interfaces
{
    public interface IOrderRepository
    {
        public List<Ordering> GetOrdersByUserId(string Id);
    }
}
