using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;
using Domain.Models;

namespace Api.CrossCutting.AutoMapper
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {   //User
            CreateMap<UserModel, UserEntity>()
                .ReverseMap();
            CreateMap<UFModel, UFEntity>()
                .ReverseMap();
            CreateMap<MunicipioModel, MunicipioEntity>()
                .ReverseMap();
            CreateMap<CepModel, CepEntity>()
                .ReverseMap();

        }
    }
}