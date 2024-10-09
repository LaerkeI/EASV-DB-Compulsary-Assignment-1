namespace ECommerceApp.Entities
{
    public class ProductRating
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Rating { get; set; }
        public Product Product { get; set; }
    }
}
