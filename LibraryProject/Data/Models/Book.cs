using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Data.Models
{
    public class Book
    {
        public int id { get; set; }

        [Required]
        public string title { get; set; }
        public string description { get; set; }

        public string? coverImage { get; set; }

        [Required]
        public decimal price { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public string author { get; set; }
        public long ISBN { get; set; }

        public int publishingYear { get; set; }

        public string genre { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
