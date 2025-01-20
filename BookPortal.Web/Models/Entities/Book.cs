using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookPortal.Web.Models.Entities
{
    public class Book
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Category { get; set; }
    }
}
