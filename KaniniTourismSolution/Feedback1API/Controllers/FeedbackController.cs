using Feedback1API.Interfaces;
using Feedback1API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Feedback1API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly IRepo<Feedback> _feedbackRepo;
        private readonly ILogger<FeedbackController> _logger;

        public FeedbackController(IRepo<Feedback> feedbackRepo, ILogger<FeedbackController> logger)
        {
            _feedbackRepo = feedbackRepo;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<Feedback>> AddFeedback(Feedback feedback)
        {
            try
            {
                var addedFeedback = await _feedbackRepo.Add(feedback);
                if (addedFeedback != null)
                {
                    return Ok(addedFeedback);
                }
                else
                {
                    return BadRequest("Failed to add feedback.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding feedback.");
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Feedback>>> GetAllFeedbacks()
        {
            try
            {
                var feedbacks = await _feedbackRepo.GetAll();
                if (feedbacks != null)
                {
                    return Ok(feedbacks);
                }
                else
                {
                    return NotFound("No feedbacks found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving feedbacks.");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
