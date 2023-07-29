using KaniniTourismApplication.Model;
using KaniniTourismApplication.Model.DTO;
using System.Numerics;

namespace KaniniTourismApplication.Interface
{
    public interface IAdminService
    {
        public Task<TravelAgent?> UpdateStatus(StatusDTO status);


    }
}
