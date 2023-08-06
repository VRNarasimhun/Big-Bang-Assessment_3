using TravelBookingAPI.Interfaces;
using TravelBookingAPI.Models;

namespace TravelBookingAPI.Services
{
    public class ManageReservationService : IManageBooking
    {
        private readonly IRepo<OTravellers, int> _otherTravellersRepo;
        private readonly IRepo<Reservation, int> _reservationRepo;
        public ManageReservationService(IRepo<OTravellers, int> otherTravellerRepo, IRepo<Reservation, int> reservationRepo)
        {
            _reservationRepo = reservationRepo;
            _otherTravellersRepo = otherTravellerRepo;
        }

        public async Task<Reservation> AddReseration(Reservation reservation)
        {
            try
            {
                if (reservation.Type == "Public" || reservation.Type == "public")
                {

                    if (reservation.availableCount > 0 && reservation.availableCount >= reservation.TravellerCount)
                    {
                        var res = await _reservationRepo.Add(reservation);
                        if (res != null)
                            return res;
                        return null;
                    }
                    return null;
                }
                var res1 = await _reservationRepo.Add(reservation);
                if (res1 != null) return res1;
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<ICollection<OTravellers>> GetGuestsByTravellerEmail(string id)
        {
            try
            {
                var guests = await _otherTravellersRepo.GetAll();
                if (guests == null)
                {
                    return new List<OTravellers>();
                }

                return guests.Where(g => g.travellerEmail == id).ToList();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<ICollection<Reservation>> GetReservationByPackageId(int id)
        {
            try
            {
                var reservations = await _reservationRepo.GetAll();
                if (reservations == null)
                {
                    return new List<Reservation>();
                }

                return reservations.Where(r => r.packageId == id).ToList();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<ICollection<Reservation>> GetReservationByTravellerEmail(string id)
        {
            try
            {
                var reservations = await _reservationRepo.GetAll();
                if (reservations == null)
                {
                    return new List<Reservation>();
                }

                return reservations.Where(r => r.travellerEmail == id).ToList();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }




    }
}