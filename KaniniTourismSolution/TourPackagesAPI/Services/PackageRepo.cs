using Microsoft.EntityFrameworkCore;
using TourPackagesAPI.Interfaces;
using TourPackagesAPI.Models;

namespace TourPackagesAPI.Services
{
    public class PackageRepo : IRepo<Packages, int>
    {
        private readonly Context _context;
        public PackageRepo(Context context)
        {
            _context = context;
        }

        public async Task<Packages?> Add(Packages item)
        {
            var pack = _context.Tourpackages.SingleOrDefault(p => p.PackageId == item.PackageId);
            if (pack == null)
            {
                try
                {
                    _context.Tourpackages.Add(item);
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

        public async Task<Packages?> Delete(int id)
        {
            try
            {
                var pack = await Get(id);
                if (pack != null)
                {
                    _context.Tourpackages.Remove(pack);
                    await _context.SaveChangesAsync();
                    return pack;
                }
                return null;

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<Packages?> Get(int id)
        {
            try
            {
                var pack = await _context.Tourpackages.SingleOrDefaultAsync(p => p.PackageId == id);
                if (pack == null)
                {
                    return null;
                }
                return pack;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<ICollection<Packages>?> GetAll()
        {
            try
            {
                var pack = await _context.Tourpackages.ToListAsync();
                if (pack != null)
                {
                    return pack;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<Packages?> Update(Packages item)
        {
            var pack = _context.Tourpackages.SingleOrDefault(p => p.PackageId == item.PackageId);
            if (pack != null)
            {
                try
                {
                    pack.destination = item.destination;
                    pack.AgencyId = item.AgencyId;
                    pack.No_Days = item.No_Days;
                    pack.DepartureCity = item.DepartureCity;
                    pack.FromDate = item.FromDate;
                    pack.ToDate = item.ToDate;
                    pack.No_Nights = item.No_Nights;
                    pack.TourType = item.TourType;
                    pack.description = item.description;
                    pack.AccommodationIncluded = item.AccommodationIncluded;
                    pack.FoodIncluded = item.FoodIncluded;
                    pack.available = item.available;
                    await _context.SaveChangesAsync();
                    return pack;
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