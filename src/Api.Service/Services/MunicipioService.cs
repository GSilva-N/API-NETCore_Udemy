using Api.Domain.Dtos.Municipio;
using Api.Domain.Entities;
using AutoMapper;
using Domain.Interfaces.Services.Municipio;
using Domain.Models;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class MunicipioService : IMunicipioService
    {
        private readonly IMunicipioRepository _municipioRepository;
        private readonly IMapper _mapper;

        public MunicipioService(IMunicipioRepository municipioRepository, IMapper mapper)
        {
            _municipioRepository = municipioRepository;
            _mapper = mapper;
        }

        public async Task<bool> DeleteById(Guid id)
        {
            return await _municipioRepository.DeleteAsync(id);
        }

        public async Task<MunicipioDto> Get(Guid id)
        {
            var municipioEntity = await _municipioRepository.SelectAsync(id);
            return _mapper.Map<MunicipioDto>(municipioEntity);
        }

        public async Task<List<MunicipioDto>> GetAll()
        {
            var listaMunicipio = await _municipioRepository.SelectAsync();
            return _mapper.Map<List<MunicipioDto>>(listaMunicipio);
        }

        public async Task<MunicipioDtoCompleto> GetCompleteByIBGE(int codigoIBGE)
        {
            var municipioEntity = await _municipioRepository.GetCompleteByCodigoIBGE(codigoIBGE);
            return _mapper.Map<MunicipioDtoCompleto>(municipioEntity);
        }

        public async Task<MunicipioDtoCompleto> GetCompleteById(Guid id)
        {
            var municipioEntity = await _municipioRepository.GetCompleteById(id);
            return _mapper.Map<MunicipioDtoCompleto>(municipioEntity);
        }

        public async Task<MunicipioDtoCreateResult> Post(MunicipioDtoCreate municipio)
        {
            var model = _mapper.Map<MunicipioModel>(municipio);
            var municipioEntity = _mapper.Map<MunicipioEntity>(model);
            var result = await _municipioRepository.InsertAsync(municipioEntity);

            return _mapper.Map<MunicipioDtoCreateResult>(result);
        }

        public async Task<MunicipioDtoUpdateResult> Put(MunicipioDtoUpdate municipio)
        {
            var model = _mapper.Map<MunicipioModel>(municipio);
            var municipioEntity = _mapper.Map<MunicipioEntity>(model);
            var result = await _municipioRepository.UpdateAsync(municipioEntity);

            return _mapper.Map<MunicipioDtoUpdateResult>(result);
        }
    }
}
