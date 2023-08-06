using Microsoft.AspNetCore.Mvc;
using TravelBookingAPI.Interfaces;
using TravelBookingAPI.Models;

namespace TravelBookingAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OTravellersController : ControllerBase
    {
        private readonly IRepo<OTravellers, int> _travellerRepo;
        private readonly IManageBooking _manageService;

        public OTravellersController(IRepo<OTravellers, int> travellerRepo, IManageBooking manageService)
        {
            _travellerRepo = travellerRepo;
            _manageService = manageService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(OTravellers), StatusCodes.Status201Created)]//Success Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]//Failure Response
        public async Task<ActionResult<OTravellers?>> Addpassenger(OTravellers item)
        {
            try
            {
                var passenger = await _travellerRepo.Add(item);
                if (passenger != null)
                {
                    return Created("Added!", passenger);
                }
                return BadRequest("Unable to add");
            }
            catch (Exception)
            {
                return BadRequest("Backend error :(");
            }
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<OTravellers>), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ICollection<OTravellers>>> GetAllPassengers()
        {
            try
            {
                var passenger = await _travellerRepo.GetAll();
                if (passenger != null)
                {
                    return Ok(passenger);
                }
                return BadRequest("No extra travellers available :(");
            }
            catch (Exception)
            {
                return BadRequest("Database error");
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(OTravellers), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<OTravellers>> GetPassenger(int id)
        {
            try
            {
                var passenger = await _travellerRepo.Get(id);
                if (passenger != null)
                {
                    return Ok(passenger);
                }
                return BadRequest("No passenger found :(");
            }
            catch (Exception)
            {
                return BadRequest("Database error");
            }
        }

        [HttpDelete]
        [ProducesResponseType(typeof(OTravellers), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<OTravellers>> DeletePassenger(int id)
        {
            try
            {
                var passenger = await _travellerRepo.Delete(id);
                if (passenger != null)
                {
                    return Ok(passenger);
                }
                return BadRequest("Not deleted");
            }
            catch (Exception)
            {
                return BadRequest("Backend error");
            }
        }
        [HttpPut]
        [ProducesResponseType(typeof(OTravellers), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<OTravellers>> UpdatePassengers(OTravellers item)
        {
            try
            {
                var passenger = await _travellerRepo.Update(item);
                if (passenger != null)
                {
                    return Ok(passenger);
                }
                return BadRequest("Not updated");
            }
            catch (Exception)
            {
                return BadRequest("Backend error");
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<OTravellers>), StatusCodes.Status200OK)]//Success Response
        [ProducesResponseType(StatusCodes.Status404NotFound)]//Failure Response
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ICollection<OTravellers>>> GetGuestsbyTraveller(string id)
        {
            try
            {
                var passenger = await _manageService.GetGuestsByTravellerEmail(id);
                if (passenger != null)
                {
                    return Ok(passenger);
                }
                return BadRequest("No passengers available :(");
            }
            catch (Exception)
            {
                return BadRequest("Database error");
            }
        }

    }
}
