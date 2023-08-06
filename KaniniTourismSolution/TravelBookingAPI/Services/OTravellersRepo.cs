using Microsoft.EntityFrameworkCore;
using TravelBookingAPI.Interfaces;
using TravelBookingAPI.Models;

namespace TravelBookingAPI.Services
{
    public class OTravellersRepo : IRepo<OTravellers, int>
    {
        private readonly Context _context;
        public OTravellersRepo(Context context)
        {
            _context = context;
        }
        public async Task<OTravellers?> Add(OTravellers item)
        {
            var user = _context.Tour_Travellers.SingleOrDefault(u => u.OtherTravellerId == item.OtherTravellerId);
            if (user == null)
            {
                try
                {
                    _context.Tour_Travellers.Add(item);
                    await _context.SaveChangesAsync();
                    return item;
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
            return null;
        }

        public async Task<OTravellers?> Delete(int id)
        {
            try
            {
                var user = await Get(id);
                if (user != null)
                {
                    _context.Tour_Travellers.Remove(user);
                    await _context.SaveChangesAsync();
                    return user;
                }
                return null;

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<OTravellers?> Get(int id)
        {
            try
            {
                var user = await _context.Tour_Travellers.SingleOrDefaultAsync(u => u.OtherTravellerId == id);
                if (user == null)
                {
                    return null;
                }
                return user;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<ICollection<OTravellers>?> GetAll()
        {
            try
            {
                var users = await _context.Tour_Travellers.ToListAsync();
                if (users != null)
                {
                    return users;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<OTravellers?> Update(OTravellers item)
        {
            var user = _context.Tour_Travellers.SingleOrDefault(u => u.OtherTravellerId == item.OtherTravellerId);
            if (user != null)
            {
                try
                {
                    user.Name = item.Name;
                    user.age = item.age;
                    user.packageId = item.packageId;
                    user.travellerEmail = item.travellerEmail;
                    await _context.SaveChangesAsync();
                    return user;
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
            return null;
        }
    }


}
