using System.ComponentModel.DataAnnotations;

namespace BookPortal.Web.Models.Entities
{
    public class Book
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Category { get; set; }
    }
}
