using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Data.Models
{
    public class CD
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string singer { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public decimal price { get; set; }

        public string? coverImage { get; set; }

        [Required]
        public string album { get; set; }

        public int releaseYear { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
