using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StoreApp.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Order.Persistence.Context
{
    public class OrderContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public OrderContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("sqlConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
    }
}

