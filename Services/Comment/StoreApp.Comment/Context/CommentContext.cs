using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StoreApp.Comment.Entities;

namespace StoreApp.Comment.Context
{
    public class CommentContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public CommentContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("sqlConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }      
        public DbSet<UserComment> UserComments { get; set; }
    }

}
