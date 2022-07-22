using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementations
{
    public class UFImplementation : BaseRepository<UFEntity>, IUFRepository
    {
        private DbSet<UFEntity> _dataSet;

        public UFImplementation(MyContext context) : base(context)
        {
            _dataSet = context.Set<UFEntity>();
        }

    }
}
