namespace damacana.Models
{
    //definition
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }


        public int PurchaseId { get; set; }
        public virtual Purchase purchase { get; set; }


        public int CartId { get; set; }
        public virtual Cart cart { get; set; }
    }
}