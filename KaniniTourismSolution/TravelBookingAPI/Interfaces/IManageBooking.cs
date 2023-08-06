using TravelBookingAPI.Models;

namespace TravelBookingAPI.Interfaces
{
    public interface IManageBooking
    {
        public Task<ICollection<Reservation>> GetReservationByPackageId(int id);
        public Task<ICollection<Reservation>> GetReservationByTravellerEmail(string id);
        public Task<ICollection<OTravellers>> GetGuestsByTravellerEmail(string id);
        public Task<Reservation> AddReseration(Reservation reservation);
    }
}
