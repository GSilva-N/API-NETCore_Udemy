using Api.Domain.Dtos.CEP;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Dtos.UF;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;
using Domain.Models;

namespace Api.CrossCutting.AutoMapper
{
    public class DtoModelProfile : Profile
    {
        public DtoModelProfile()
        {   
            //User
            CreateMap<UserModel, UserDto>()
                .ReverseMap();
            //UF
            CreateMap<UFModel, UFDto>()
                .ReverseMap();

            #region Municipio
            CreateMap<MunicipioModel, MunicipioDto>()
                .ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoCreate>()
                .ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoUpdate>()
                .ReverseMap();
            #endregion

            #region Cep
            CreateMap<CepModel, CepDto>()
                .ReverseMap();
            CreateMap<CepModel, CepDtoCreate>()
                .ReverseMap();
            CreateMap<CepModel, CepDtoUpdate>()
                .ReverseMap();
            #endregion
        }
    }
}