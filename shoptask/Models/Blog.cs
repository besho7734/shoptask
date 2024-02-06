namespace shoptask.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public  Type type { get; set; }
    }
}
