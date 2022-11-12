using AutoMapper;
using Core.DTO.UserDTO;
using Core.Entitites.UserEntity;

namespace Core.Helpers.ApplicationProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserRegistrationDTO, User>()
                .ForMember(desc => desc.UserName,
                    act => act.MapFrom(src => src.Email));
        }
    }
}
