namespace PokemanReviewApp.Models
{
    public class Pokeman
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public ICollection<Review> Reviews { get; set;}
        public ICollection<PokemanOwner> PokemanOwners { get; set;}
        public ICollection<PokemanCategory> PokemanCategories { get; set; }
    }
}
