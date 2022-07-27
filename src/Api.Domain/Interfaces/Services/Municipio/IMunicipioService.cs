using Api.Domain.Dtos.Municipio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Municipio
{
    public interface IMunicipioService
    {
        Task<MunicipioDto> Get(Guid id);
        Task<List<MunicipioDto>> GetAll();
        Task<MunicipioDtoCompleto> GetCompleteByIBGE(int codigoIBGE);
        Task<MunicipioDtoCompleto> GetCompleteById(Guid id);
        Task<MunicipioDtoCreateResult> Post(MunicipioDtoCreate municipio);
        Task<MunicipioDtoUpdateResult>Put(MunicipioDtoUpdate municipio);
        Task <bool> DeleteById(Guid id);
    }
}
