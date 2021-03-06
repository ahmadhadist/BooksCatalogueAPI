using System.Collections.Generic;

namespace BooksCatalogueAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Synopsis { get; set; }
        public int ReleaseYear { get; set; }
        public string CoverURL { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}