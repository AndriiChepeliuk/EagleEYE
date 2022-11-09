using Core.DTO.UserDTO;
using Core.Entitites.UserEntity;
using Core.Interfaces.CustomServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
            User user = new User();
            user.Name = userData.Name;
            user.SurName = userData.SurName;
            user.Email = userData.Email;
            user.UserName = userData.Email;

            await _userManager.AddPasswordAsync(user, userData.Password);
            IdentityResult result = await _userManager.CreateAsync(user);
            if (!result.Succeeded)
                foreach (IdentityError error in result.Errors)
                    Console.WriteLine($"Oops! {error.Description} ({error.Code})");
        }
    }
}
