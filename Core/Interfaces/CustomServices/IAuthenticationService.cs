using Core.DTO.UserDTO;

namespace Core.Interfaces.CustomServices
{
    public interface IAuthenticationService
    {
        Task RegisterAsync(UserRegistrationDTO data);
    }
}
