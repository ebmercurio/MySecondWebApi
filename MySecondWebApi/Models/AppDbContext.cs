using Microsoft.EntityFrameworkCore;
using MySecondWebApi.Models;

namespace MyFirstWebApi.Models {
    public class AppDbContext : DbContext {

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Orderline> Orderlines { get; set; } = null!;
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
            //this is where any fluid API code would go
    }
}
