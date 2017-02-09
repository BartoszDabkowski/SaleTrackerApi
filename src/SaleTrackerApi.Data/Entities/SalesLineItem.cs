namespace SaleTrackerApi.Data.Entities
{
    public class SalesLineItem
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}