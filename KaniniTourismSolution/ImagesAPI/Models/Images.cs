using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ImagesAPI.Models
{
    public class Images
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? packageId { get; set; }
        public string? ImagePath { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
