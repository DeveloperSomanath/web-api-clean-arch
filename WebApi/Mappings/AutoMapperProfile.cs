using static System.Runtime.InteropServices.JavaScript.JSType;
using WebApi.Entities;
using AutoMapper;
using DTOs.Login;

namespace WebApi.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto, User>();
        }
    }

}
