namespace PokemanReviewApp.Models
{
    public class Owner
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gym { get; set; }
        public Country Country { get; set; }
        public ICollection<PokemanOwner> PokemanOwners { get; set; }

    }
}
