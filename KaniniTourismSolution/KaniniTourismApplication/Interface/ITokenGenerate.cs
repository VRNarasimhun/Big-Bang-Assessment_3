using KaniniTourismApplication.Model.DTO;

namespace KaniniTourismApplication.Interface
{
    public interface ITokenGenerate
    {
        public string GenerateToken(UserDTO user);

    }
}
