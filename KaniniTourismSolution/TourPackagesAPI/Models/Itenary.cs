using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourPackagesAPI.Models
{
    public class Itenary
    {
        [Key]
        public int itenaryItemId { get; set; }
        
        public int packageId { get; set; }
        public string? day { get; set; }
        public string? activity { get; set; }
    }
}
