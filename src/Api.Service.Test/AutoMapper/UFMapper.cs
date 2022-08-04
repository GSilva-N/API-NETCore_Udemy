using Api.Domain.Dtos.UF;
using Api.Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Api.Service.Test.AutoMapper
{
    public class UFMapper : BaseTestService
    {
        [Fact(DisplayName = "É Possivel mapear os Modelos de UFs")]
        public void E_Possivel_Mapear_Modelos_UFs()
        {
            var model = new UFModel
            {
                Id = Guid.NewGuid(),
                NomeUF = Faker.Address.UsState(),
                SiglaUF = Faker.Address.UsState().Substring(1, 3),
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };

            var listaEntity = new List<UFEntity>();

            for (int i = 0; i < 5; i++)
            {
                var item = new UFEntity
                {
                    Id = Guid.NewGuid(),
                    NomeUF = Faker.Address.UsState(),
                    SiglaUF = Faker.Address.UsState().Substring(1, 3),
                    CreateAt = DateTime.UtcNow,
                    UpdateAt = DateTime.UtcNow
                };

                listaEntity.Add(item);
            }
            //Model para Entity
            var entity = Mapper.Map<UFEntity>(model);

            Assert.Equal(entity.Id, model.Id);
            Assert.Equal(entity.NomeUF, model.NomeUF);
            Assert.Equal(entity.SiglaUF, model.SiglaUF);
            Assert.Equal(entity.CreateAt, model.CreateAt);
            Assert.Equal(entity.UpdateAt, model.UpdateAt);

            var listaDto = Mapper.Map<List<UFDto>>(listaEntity);

            Assert.True(listaDto.Count == listaEntity.Count);

            for (int i = 0; i < listaDto.Count; i++)
            {
                Assert.Equal(listaDto[i].Id, listaEntity[i].Id);
                Assert.Equal(listaDto[i].NomeUF, listaEntity[i].NomeUF);
            }
        }
        
    }
}
