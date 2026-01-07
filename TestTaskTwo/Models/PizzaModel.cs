namespace TestTaskTwo.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Image { get; set; }
        public string? Ingredients { get; set; }
        public string? Price { get; set; }
    }
}
