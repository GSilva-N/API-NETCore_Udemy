using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.CrossCutting.AutoMapper;
using AutoMapper;

namespace Api.Service.Test
{
    public class AutoMapperFixture : IDisposable
    {

        public IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ModelToEntityProfile());
                cfg.AddProfile(new DtoModelProfile());
                cfg.AddProfile(new EntityToDtoProfile());
            });

            return config.CreateMapper();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}