using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookPortal.Web.Models
{
    public class AddBookViewModel
    {
        
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Category { get; set; }
    }
}
