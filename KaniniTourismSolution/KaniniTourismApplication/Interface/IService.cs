using KaniniTourismApplication.Model.DTO;

namespace KaniniTourismApplication.Interface
{
    public interface IService
    {
        public Task<UserDTO?> TravelAgentRegister(TravelAgentRegisterDTO travelAgentRegisterDTO);
        public Task<UserDTO?> TravellerRegister(TravellerRegDTO travellerRegDTO);
        public Task<UserDTO?> Login(UserDTO userDTO);
    }
}
