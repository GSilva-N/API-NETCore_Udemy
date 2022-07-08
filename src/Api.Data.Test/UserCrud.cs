using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Api.Data.Test
{
    public class UserCrud : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _seviceProvider;

        public UserCrud(DbTeste dbTeste)
        {
            _seviceProvider = dbTeste.ServiceProvider;
        }
        [Fact]
        public async Task Realizar_CRUD_Com_Sucesso()
        {
            using (var context = _seviceProvider.GetService<MyContext>())
            {
                UserImplementation _repository = new UserImplementation(context);
                UserEntity _entity = new UserEntity
                {
                    Email = Faker.Internet.Email(),
                    Name = Faker.Name.FullName()
                };

                var result = await _repository.InsertAsync(_entity);

                Assert.NotNull(result);
                Assert.Equal(_entity.Email, result.Email);

                _entity.Name = Faker.Name.First();

                var resultUpdated = await _repository.UpdateAsync(_entity);

                Assert.NotNull(resultUpdated);
                Assert.Equal(_entity.Name, resultUpdated.Name);
            }
        }
    }
}