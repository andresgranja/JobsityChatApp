using AutoMapper;
using JobsityChatApp.DTO;
using JobsityChatApp.DTO.Users;
using JobsityChatApp.Models;

namespace JobsityChatApp
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, GetUserDto>();
            CreateMap<GetUserDto, User>();
            CreateMap<AddUserDto, User>();
        }
    }
}
