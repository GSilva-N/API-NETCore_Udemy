using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.AutoMapper
{
    public class DtoModelProfile : Profile
    {
        public DtoModelProfile()
        {
            CreateMap<UserModel, UserDto>()
                .ReverseMap();

        }
    }
}