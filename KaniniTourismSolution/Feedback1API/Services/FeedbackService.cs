using Feedback1API.Interfaces;
using Feedback1API.Models;
using Microsoft.EntityFrameworkCore;

namespace Feedback1API.Services
{
    public class FeedbackService : IRepo<Feedback>
    {
        private readonly FeedbackContext _context;
        private readonly ILogger<FeedbackService> _logger;

        public FeedbackService(FeedbackContext context, ILogger<FeedbackService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Feedback?> Add(Feedback item)
        {
            try
            {
                var addedItem = await _context.FeedBacks.AddAsync(item);
                await _context.SaveChangesAsync();
                return addedItem.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding feedback.");
                return null;
            }
        }

        public async Task<ICollection<Feedback>?> GetAll()
        {
            try
            {
                return await _context.FeedBacks.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving feedbacks.");
                return null;
            }
        }
    }
}
