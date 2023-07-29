using KaniniTourismApplication.Interface;
using KaniniTourismApplication.Model;
using Microsoft.EntityFrameworkCore;

namespace KaniniTourismApplication.Service
{
    public class TravellerRepo : IRepo<Traveller, int>
    {
        private readonly Context _context;
        public TravellerRepo(Context context)
        {

            _context = context;

        }
        public async Task<Traveller?> Add(Traveller item)
        {
            var traveller_id = _context.Travellers.SingleOrDefault(p => p.TravellerId == item.TravellerId);
            if (traveller_id == null)
            {
                try
                {
                    _context.Travellers.Add(item);
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

        public async Task<Traveller?> Delete(int id)
        {
            try
            {
                var traveller = await Get(id);
                if (traveller != null)
                {
                    _context.Travellers.Remove(traveller);
                    await _context.SaveChangesAsync();
                    return traveller;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }

        }


        public async Task<Traveller?> Get(int id)
        {
            try
            {
                var patient = await _context.Travellers.SingleOrDefaultAsync(i => i.TravellerId == id);
                if (patient == null)
                {
                    return null;
                }
                return patient;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<ICollection<Traveller>?> GetAll()
        {
            try
            {
                var travellers = await _context.Travellers.ToListAsync();
                if (travellers != null)
                {
                    return travellers;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }


        public async Task<Traveller?> Update(Traveller item)
        {
            var traveller = _context.Travellers.SingleOrDefault(p => p.TravellerId == item.TravellerId);
            if (traveller != null)
            {
                try
                {
                    traveller.Name = item.Name;
                    traveller.Address = item.Address;
                    traveller.Email = item.Email;
                    traveller.Phone = item.Phone;
                    traveller.Gender = item.Gender;
                    await _context.SaveChangesAsync();
                    return traveller;
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
