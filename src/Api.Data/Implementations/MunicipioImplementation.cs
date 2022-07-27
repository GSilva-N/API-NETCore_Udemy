using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class MunicipioImplementation : BaseRepository<MunicipioEntity>, IMunicipioRepository
    {
        private DbSet<MunicipioEntity> _dataSet;

        public MunicipioImplementation(MyContext context) : base(context)
        {
            _dataSet = context.Set<MunicipioEntity>();
        }

        public async Task<MunicipioEntity> GetCompleteByCodigoIBGE(int codIBGE)
        {
            return await _dataSet.Include(m => m.UF)
                .FirstOrDefaultAsync(m => m.CodigoIBGE.Equals(codIBGE));
        }

        public async Task<MunicipioEntity> GetCompleteById(Guid id)
        {
            return await _dataSet.Include(m => m.UF)
                .FirstOrDefaultAsync(m => m.Id.Equals(id));
        }
    }
}
