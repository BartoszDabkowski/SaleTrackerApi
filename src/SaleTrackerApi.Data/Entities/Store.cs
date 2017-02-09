using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SaleTrackerApi.Data.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
