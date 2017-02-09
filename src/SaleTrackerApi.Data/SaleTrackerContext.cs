using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleTrackerApi.Data.Entities;

namespace SaleTrackerApi.Data
{
    public class SaleTrackerContext : DbContext
    {
        public SaleTrackerContext()
        {
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesLineItem> SalesLineItems { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
