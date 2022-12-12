using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProiectWAD.Models;

namespace ProiectWAD.Repository
{
    public class ProiectWADDBContext : IdentityDbContext<User>
    {

        public ProiectWADDBContext(DbContextOptions<ProiectWADDBContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ShoppingOrder> ShoppingOrders { get; set; }

    }
}

