using Microsoft.AspNetCore.Identity;

namespace Core.Entitites.UserEntity
{
    public class User : IdentityUser
    {
        public string? Name { get; set; }
        public string? SurName { get; set; }
    }
}
