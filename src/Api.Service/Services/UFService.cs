using Api.Domain.Dtos.UF;
using AutoMapper;
using Domain.Interfaces.Services.UF;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UFService : IUFService
    {
        private readonly IUFRepository _uFRepository;
        private readonly IMapper _mapper;

        public UFService(IUFRepository uFRepository, IMapper mapper)
        {
            _uFRepository = uFRepository;
            _mapper = mapper;
        }

        public async Task<UFDto> GetUF(Guid id)
        {
            var ufEntity =  await _uFRepository.SelectAsync(id);
            return _mapper.Map<UFDto>(ufEntity); 
        }

        public async Task<List<UFDto>> GetUFAll()
        {
            var listaUf = await _uFRepository.SelectAsync();
            return _mapper.Map<List<UFDto>>(listaUf);
        }
    }
}
