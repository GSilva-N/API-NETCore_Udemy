using Api.Domain.Entities;
using Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface ICepRepository: IRepository<CepEntity>
    {
        Task<CepEntity> SelectAsync(string cep);
    }
}
