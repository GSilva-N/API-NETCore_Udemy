using Api.Domain.Dtos.UF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.UF
{
    public interface IUFService
    {
        Task<UFDto> GetUF(Guid id);
        Task<List<UFDto>> GetUFAll(Guid id);

    }
}
