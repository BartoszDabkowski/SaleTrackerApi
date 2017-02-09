using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SaleTrackerApi.Data
{
    public class TemporaryDbContextFactory : IDbContextFactory<SaleTrackerContext>
    {
        public SaleTrackerContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<SaleTrackerContext>();
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=SaleTrackerDb;Trusted_Connection=true;MultipleActiveResultSets=true;");
            return new SaleTrackerContext(builder.Options);
        }
    }
}
