namespace PokemanReviewApp.Models
{
    public class PokemanCategory
    {
        public int PokemanId { get; set; }
        public int CategoryId { get; set; }
        public Pokeman Pokeman { get; set; }
        public Category category { get; set; }
        public ICollection<PokemanCategory> PokemanCategories { get; set; }
    }
}
