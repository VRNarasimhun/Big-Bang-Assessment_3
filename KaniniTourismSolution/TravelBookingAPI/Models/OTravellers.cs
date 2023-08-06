using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBookingAPI.Models
{
    public class OTravellers
    {
        [Key]
        public int OtherTravellerId { get; set; }
        public int? packageId { get; set; }
        [ForeignKey("id")]
        public string? travellerEmail { get; set; }
        public Reservation? reservation { get; set; }
        public string? Name { get; set; }
        public int? age { get; set; }
    }
}
