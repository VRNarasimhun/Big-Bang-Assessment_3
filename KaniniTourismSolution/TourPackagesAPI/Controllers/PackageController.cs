using Microsoft.AspNetCore.Mvc;
using TourPackagesAPI.Interfaces;
using TourPackagesAPI.Models;
using TourPackagesAPI.Models.DTO;

namespace TourPackagesAPI.Controllers
{
   
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly IRepo<Packages, int> _packageRepo;
        private readonly IService _service;
        public PackageController(IRepo<Packages, int> packageRepo, IService service)
        {
            _packageRepo = packageRepo;
            _service = service;

        }

        [HttpPost]
        [ProducesResponseType(typeof(Packages), StatusCodes.Status201Created)]//Success Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]//Failure Response
        public async Task<ActionResult<Packages?>> AddPackage(Packages pack)
        {
            try
            {
                var tourpackage = await _packageRepo.Add(pack);
                if (tourpackage != null)
                {
                    return Created("Added!", tourpackage);
                }
                return BadRequest("Unable to add");
            }
            catch (Exception)
            {
                return BadRequest("Backend error :(");
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Packages>), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ICollection<Packages>>> GetAllPakages()
        {
            try
            {
                var tourPackages = await _packageRepo.GetAll();
                if (tourPackages != null)
                {
                    return Ok(tourPackages);
                }
                return BadRequest("No packages available :(");
            }
            catch (Exception)
            {
                return BadRequest("Database error");
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(Packages), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Packages>> GetPackage(int id)
        {
            try
            {
                var tourpackage = await _packageRepo.Get(id);
                if (tourpackage != null)
                {
                    return Ok(tourpackage);
                }
                return BadRequest("No package found :(");
            }
            catch (Exception)
            {
                return BadRequest("Database error");
            }
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Packages), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Packages>> DeletePackage(int id)
        {
            try
            {
                var tourpackage = await _packageRepo.Delete(id);
                if (tourpackage != null)
                {
                    return Ok(tourpackage);
                }
                return BadRequest("Not deleted");
            }
            catch (Exception)
            {
                return BadRequest("Backend error");
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(Packages), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Packages>> UpdatePackage(Packages item)
        {
            try
            {
                var tourpackage = await _packageRepo.Update(item);
                if (tourpackage != null)
                {
                    return Ok(tourpackage);
                }
                return BadRequest("Not updated");
            }
            catch (Exception)
            {
                return BadRequest("Backend error");
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Packages>), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ICollection<Packages>>> GetPackageByDestination(string dest)
        {
            try
            {
                var tourPackages = await _service.GetPackageByDestination(dest);
                if (tourPackages != null)
                {
                    return Ok(tourPackages);
                }
                return BadRequest("No tours available :(");
            }
            catch (Exception)
            {
                return BadRequest("Database error");
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(Packages), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Packages>> UpdateAvailableCount(UpdateAvailableDTO availableDTO)
        {
            try
            {
                var tourpackage = await _service.UpdateAvailable(availableDTO);
                if (tourpackage != null)
                {
                    return Ok(tourpackage);
                }
                return BadRequest("Not updated");
            }
            catch (Exception)
            {
                return BadRequest("Backend error");
            }
        }
    }
}
