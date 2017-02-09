using System;
using System.Collections.Generic;

namespace SaleTrackerApi.Data.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<SalesLineItem> Items { get; set; }
    }
}