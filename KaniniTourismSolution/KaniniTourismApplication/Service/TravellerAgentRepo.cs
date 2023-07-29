using KaniniTourismApplication.Interface;
using KaniniTourismApplication.Model;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace KaniniTourismApplication.Service
{
    public class TravelAgentRepo : IRepo<TravelAgent , int>
    {
        private readonly Context _context;

        public TravelAgentRepo(Context context)
        {
            _context = context;
        }
        public async Task<TravelAgent?> Add(TravelAgent item)
        {
            var travelAgent_id = _context.TravelAgents.SingleOrDefault(d => d.TravelAgentId == item.TravelAgentId);
            if (travelAgent_id == null)
            {
                try
                {
                    _context.TravelAgents.Add(item);
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

        public async Task<TravelAgent?> Delete(int id)
        {
            try
            {
                var travelAgent = await Get(id);
                if (travelAgent != null)
                {
                    _context.TravelAgents.Remove(travelAgent);
                    await _context.SaveChangesAsync();

                    return travelAgent;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<TravelAgent?> Get(int id)
        {
            try
            {
                var doctor = await _context.TravelAgents.SingleOrDefaultAsync(i => i.Users.UserId == id);
                if (doctor == null)
                {
                    return null;
                }
                return doctor;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<ICollection<TravelAgent>?> GetAll()
        {
            try
            {
                var travelAgents = await _context.TravelAgents.ToListAsync();
                if (travelAgents != null)
                {
                    return travelAgents;
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<TravelAgent?> Update(TravelAgent item)
        {
            var travelAgent = _context.TravelAgents.SingleOrDefault(d => d.TravelAgentId == item.TravelAgentId);
            if (travelAgent != null)
            {
                try
                {
                    travelAgent.Name = item.Name;
                    travelAgent.DateOfBirth = item.DateOfBirth;
                    travelAgent.Address = item.Address;
                    travelAgent.Email = item.Email;
                    travelAgent.Phone = item.Phone;
                    await _context.SaveChangesAsync();
                    return travelAgent;
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

