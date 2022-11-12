using AutoMapper;
using Core.DTO.UserDTO;
using Core.Entitites.UserEntity;
using Core.Interfaces.CustomServices;
using Microsoft.AspNetCore.Identity;

namespace Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public AuthenticationService(
            UserManager<User> userManager,
            IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task RegisterAsync(UserRegistrationDTO userData)
        {
            var user = _mapper.Map<User>(userData);

            IdentityResult result = await _userManager.CreateAsync(user, userData.Password);
            if (!result.Succeeded)
                foreach (IdentityError error in result.Errors)
                    Console.WriteLine($"Oops! {error.Description} ({error.Code})");
        }
    }
}
