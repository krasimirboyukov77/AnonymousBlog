using AnonymousBlog.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AnonymousBlog.Data
{
    public class ANONYMOUSBLOGDbContext : DbContext
    {
        public static string ConnectionString = @"Server=.;Database=ANONYMOUSBLOG;Integrated Security=True;Encrypt=False";

        public ANONYMOUSBLOGDbContext()
        {
            
        }

        public ANONYMOUSBLOGDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }
    }
}
