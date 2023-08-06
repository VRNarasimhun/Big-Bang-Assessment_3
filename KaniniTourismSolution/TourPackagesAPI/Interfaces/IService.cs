using TourPackagesAPI.Models.DTO;
using TourPackagesAPI.Models;

namespace TourPackagesAPI.Interfaces
{
    public interface IService
    {
        public Task<ICollection<Itenary>?> GetItenaryByPackage(int id);
        public Task<ICollection<Packages>?> GetPackageByDestination(string destination);
        public Task<Packages?> UpdateAvailable(UpdateAvailableDTO availableDTO);
    }
}
