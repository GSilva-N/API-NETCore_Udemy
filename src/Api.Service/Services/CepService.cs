using Api.Domain.Dtos.CEP;
using Api.Domain.Entities;
using AutoMapper;
using Domain.Interfaces.Services.CEP;
using Domain.Models;
using Domain.Repository;
using System;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CepService : ICepService
    {
        private readonly ICepRepository _cepRepository;
        private readonly IMapper _mapper;

        public CepService(ICepRepository cepRepository, IMapper mapper)
        {
            _cepRepository = cepRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _cepRepository.DeleteAsync(id);
        }

        public async Task<CepDto> GetByCep(string cep)
        {
            var cepEntity = await _cepRepository.SelectAsync(cep);
            return _mapper.Map<CepDto>(cepEntity);
        }

        public async Task<CepDto> GetById(Guid id)
        {
            var cepEntity = await _cepRepository.SelectAsync(id);
            return _mapper.Map<CepDto>(cepEntity);
        }

        public async Task<CepDtoCreateResult> Post(CepDtoCreate cep)
        {
            var model = _mapper.Map<CepModel>(cep);
            var cepEntity = _mapper.Map<CepEntity>(model);
            var result = await _cepRepository.InsertAsync(cepEntity);

            return _mapper.Map<CepDtoCreateResult>(result);
        }

        public async Task<CepDtoUpdateResult> Put(CepDtoUpdate cep)
        {
            var model = _mapper.Map<CepModel>(cep);
            var cepEntity = _mapper.Map<CepEntity>(model);
            var result = await _cepRepository.UpdateAsync(cepEntity);

            return _mapper.Map<CepDtoUpdateResult>(result);
        }
    }
}
