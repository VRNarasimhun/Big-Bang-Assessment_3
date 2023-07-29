using KaniniTourismApplication.Interface;
using KaniniTourismApplication.Model;
using KaniniTourismApplication.Model.DTO;
using System.Security.Cryptography;
using System.Text;

namespace KaniniTourismApplication.Service
{

        public class UserService : IService
        {
            private readonly IRepo<TravelAgent, int> _travelAgentRepo;
            private readonly IRepo<Traveller, int> _travellerRepo;
            private readonly IRepo<User, int> _userRepo;
            private readonly ITokenGenerate _tokenGenerate;
            public UserService(IRepo<TravelAgent, int> travelAgentRepo, IRepo<Traveller, int> travellerRepo,
                               IRepo<User, int> userRepo, ITokenGenerate tokenGenerate)
            {
                _travelAgentRepo = travelAgentRepo;
                _travellerRepo = travellerRepo;
                _userRepo = userRepo;
                _tokenGenerate = tokenGenerate;
            }

            public async Task<UserDTO?> TravelAgentRegister(TravelAgentRegisterDTO travelAgentRegDTO)
            {
                UserDTO user = null;
                var hmac = new HMACSHA512();
                travelAgentRegDTO.Users = new User();
                travelAgentRegDTO.Users.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(travelAgentRegDTO.PasswordClear));
                travelAgentRegDTO.Users.PasswordKey = hmac.Key;
                travelAgentRegDTO.Users.EmailId = travelAgentRegDTO.Email;
                travelAgentRegDTO.IsApproved = "Not approved";
                var userResult = await _userRepo.Add(travelAgentRegDTO.Users);
                var travelAgentResult = await _travelAgentRepo.Add(travelAgentRegDTO);
                if (userResult != null && travelAgentResult != null)
                {
                    user = new UserDTO();
                    user.UserId = travelAgentResult.Users.UserId;
                    user.EmailId = userResult.EmailId;
                    user.Role = userResult.Role;
                    user.Token = _tokenGenerate.GenerateToken(user);
                }
                return user;
            }

            public async Task<UserDTO?> Login(UserDTO user)
            {
                var userData = await _userRepo.Get(user.UserId);
                if (userData != null)
                {
                    var hmac = new HMACSHA512(userData.PasswordKey);
                    var userPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                    for (int i = 0; i < userPass.Length; i++)
                    {
                        if (userPass[i] != userData.PasswordHash[i])
                            return null;
                    }
                    user = new UserDTO();
                    user.UserId = userData.UserId;
                    user.Role = userData.Role;
                    user.Token = _tokenGenerate.GenerateToken(user);
                    return user;
                }
                return null;

            }

            public async Task<UserDTO?> TravellerRegister(TravellerRegDTO travellerRegDTO)
            {
                UserDTO? user = null;
                var hmac = new HMACSHA512();
                travellerRegDTO.Users = new User();
                travellerRegDTO.Users.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(travellerRegDTO.PasswordClear));
                travellerRegDTO.Users.PasswordKey = hmac.Key;
                travellerRegDTO.Users.EmailId = travellerRegDTO.Email;
                var userResult = await _userRepo.Add(travellerRegDTO.Users);

                var travellerResult = await _travellerRepo.Add(travellerRegDTO);
                if (userResult != null && travellerResult != null)
                {
                    user = new UserDTO();
                    user.UserId = userResult.UserId;
                    user.Role = userResult.Role;
                    user.EmailId = travellerResult.Email;
                    user.Token = _tokenGenerate.GenerateToken(user);
                }
                return user;
            }
        }
}

