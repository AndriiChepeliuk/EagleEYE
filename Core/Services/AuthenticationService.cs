using Core.DTO.UserDTO;
using Core.Entitites.UserEntity;
using Core.Interfaces.CustomServices;
using Microsoft.AspNetCore.Identity;

namespace Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;

        public AuthenticationService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task RegisterAsync(UserRegistrationDTO userData)
        {
            User user = new User { Name = userData.Name, SurName = userData.SurName, Email = userData.Email};
            await _userManager.CreateAsync(user, userData.Password);
        }
    }
}
