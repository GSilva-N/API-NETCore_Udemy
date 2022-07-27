using Api.Domain.Dtos.CEP;
using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.CEP
{
    public interface ICepService
    {
        Task<CepDto> GetById(Guid id);
        Task<CepDto> GetByCep(string cep);
        Task<CepDtoCreateResult> Post(CepDtoCreate cep);
        Task<CepDtoUpdateResult> Put(CepDtoUpdate cep);
        Task<bool> Delete(Guid id);
    }
}
