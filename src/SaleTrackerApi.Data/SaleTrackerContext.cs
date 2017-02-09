using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SaleTrackerApi.Data.Entities;

namespace SaleTrackerApi.Data
{
    public class SaleTrackerContext : DbContext
    {
        //private readonly IConfigurationRoot _config;

        public SaleTrackerContext(/*IConfigurationRoot config,*/ DbContextOptions options)
            :base(options)
        {
            //_config = config;
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesLineItem> SalesLineItems { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Store>()
              .Property(c => c.Name)
              .IsRequired();

            builder.Entity<Sale>()
              .Property(c => c.DateTime)
              .IsRequired();

            builder.Entity<SalesLineItem>()
              .Property(c => c.Quantity)
              .IsRequired();

            builder.Entity<Item>()
              .Property(c => c.Name)
              .IsRequired();
            builder.Entity<Item>()
              .Property(c => c.Description)
              .IsRequired();
            builder.Entity<Item>()
              .Property(c => c.Price)
              .IsRequired();
            builder.Entity<Item>()
              .Property(c => c.Weight)
              .IsRequired();
        }
    }
}
