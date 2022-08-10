using BreakpointApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BreakpointApp.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("BreakpointApp"));
        }

        public DbSet<User> User { get; set; }
    }
}