namespace bookpage.webui.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Pages { get; set; }
        public string Description { get; set; }
        public string Door { get; set; }
        public string Moduls1 { get; set; }
        public string Moduls2 { get; set; }
        public string Moduls3 { get; set; }
        public string ImageUrl { get; set; }
        public bool  IsApproved { get; set; }
        public int CategoryId { get; set; }
    }
}