using Microsoft.EntityFrameworkCore;
using TourPackagesAPI.Interfaces;
using TourPackagesAPI.Models;

namespace TourPackagesAPI.Services
{
    public class ItenaryRepo : IRepo<Itenary, int>
    {
        private readonly Context _context;
        public ItenaryRepo(Context context)
        {
            _context = context;
        }
        public async Task<Itenary?> Add(Itenary item)
        {
            var plan = _context.Itenaries.SingleOrDefault(i => i.itenaryItemId == item.itenaryItemId);
            if (plan == null)
            {
                try
                {
                    _context.Itenaries.Add(item);
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

        public async Task<Itenary?> Delete(int id)
        {
            try
            {
                var plan = await Get(id);
                if (plan != null)
                {
                    _context.Itenaries.Remove(plan);
                    await _context.SaveChangesAsync();
                    return plan;
                }
                return null;

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<Itenary?> Get(int id)
        {
            try
            {
                var plan = await _context.Itenaries.SingleOrDefaultAsync(i => i.itenaryItemId == id);
                if (plan == null)
                {
                    return null;
                }
                return plan;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<ICollection<Itenary>?> GetAll()
        {
            try
            {
                var plan = await _context.Itenaries.ToListAsync();
                if (plan != null)
                {
                    return plan;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<Itenary?> Update(Itenary item)
        {
            var plan = _context.Itenaries.SingleOrDefault(i => i.itenaryItemId == item.itenaryItemId);
            if (plan != null)
            {
                try
                {
                    plan.activity = item.activity;
                    plan.packageId = item.packageId;
                    plan.day = item.day;
                    await _context.SaveChangesAsync();
                    return plan;
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
