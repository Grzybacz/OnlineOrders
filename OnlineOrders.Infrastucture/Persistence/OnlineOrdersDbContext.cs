using Microsoft.EntityFrameworkCore;
using OnlineOrders.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrders.Infrastucture.Persistence
{
    public class OnlineOrdersDbContext: DbContext
    {
        public OnlineOrdersDbContext(DbContextOptions<OnlineOrdersDbContext> options) : base(options)
        {

        }

        public DbSet<Domain.Entities.Shop> Shops { get; set; }

        public DbSet<Domain.Entities.Address> Adresses { get; set; }

        public DbSet<Domain.Entities.Category> Categories { get; set; }

        public DbSet<Domain.Entities.Outerwear> Outerwears { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>()
                .HasOne(u => u.Address)
                .WithOne(a => a.Shop)
                .HasForeignKey<Address>(u => u.ShopId);
        }

    }
}
