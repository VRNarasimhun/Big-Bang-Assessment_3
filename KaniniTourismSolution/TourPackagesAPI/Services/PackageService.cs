using TourPackagesAPI.Models.DTO;
using TourPackagesAPI.Models;
using TourPackagesAPI.Interfaces;

namespace TourPackagesAPI.Services
{
    public class PackageService : IService
    {
        private readonly IRepo<Itenary, int> _ItenaryRepo;
        private readonly IRepo<Packages, int> _packagesRepo;
        public PackageService(IRepo<Itenary, int> ItenaryRepo, IRepo<Packages, int> packagesRepo)
        {
            _ItenaryRepo = ItenaryRepo;
            _packagesRepo = packagesRepo;
        }
        public async Task<ICollection<Itenary>?> GetItenaryByPackage(int id)
        {
            try
            {
                var itenaryItems = await _ItenaryRepo.GetAll();
                if (itenaryItems == null)
                {
                    return null;
                }

                return itenaryItems.Where(item => item.packageId == id).ToList();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<ICollection<Packages>?> GetPackageByDestination(string destination)
        {
            try
            {
                var packagesByDestination = await _packagesRepo.GetAll();
                if (packagesByDestination == null)
                {
                    return null;
                }

                // Convert both the search term and stored destinations to lowercase for comparison
                var lowercaseDestination = destination.ToLower();

                // Use StringComparison.OrdinalIgnoreCase for case-insensitive comparison
                return packagesByDestination
                    .Where(package => package.destination?.ToLower().Trim() == lowercaseDestination)
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<Packages?> UpdateAvailable(UpdateAvailableDTO availableDTO)
        {
            try
            {
                var pack = await _packagesRepo.Get(availableDTO.PackageId);
                if (pack == null) { return null; }
                pack.available = availableDTO.Available;
                var updatedPack = await _packagesRepo.Update(pack);
                if (updatedPack == null) { return null; }
                return updatedPack;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}