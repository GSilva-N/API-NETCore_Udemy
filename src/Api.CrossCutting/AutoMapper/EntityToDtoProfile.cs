using Api.Domain.Dtos.CEP;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Dtos.UF;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.AutoMapper
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {   //User
            CreateMap<UserDto, UserEntity>()
                .ReverseMap();
            CreateMap<UserDtoCreateResult, UserEntity>()
                .ReverseMap();
            CreateMap<UserDtoUpdateResult, UserEntity>()
                .ReverseMap();

            //UF
            CreateMap<UFDto, UFEntity>()
                .ReverseMap();

            //Municipio
            CreateMap<MunicipioDto, MunicipioEntity>()
                .ReverseMap();
            CreateMap<MunicipioDtoCompleto, MunicipioEntity>()
                .ReverseMap();
            CreateMap<MunicipioDtoCreateResult, MunicipioEntity>()
                .ReverseMap();
            CreateMap<MunicipioDtoUpdateResult, MunicipioEntity>()
                .ReverseMap();

            //CEP
            CreateMap<CepDto, CepEntity>()
                .ReverseMap();
            CreateMap<CepDtoCreateResult, CepEntity>()
                .ReverseMap();
            CreateMap<CepDtoUpdateResult, CepEntity>()
                .ReverseMap();

        }
    }
}