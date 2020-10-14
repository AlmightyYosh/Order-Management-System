namespace EntityFramework.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        //Forigen key link
        public Order Order { get; set; }
        public Product Product { get; set; }


    }
}