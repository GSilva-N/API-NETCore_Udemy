using Api.Data.Context;
using Api.Domain.Entities;
using Data.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Data.Test
{
    public class UFGets : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvider;

        public UFGets(DbTeste dbTeste)
        {
            _serviceProvider = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName ="Gets de UFs")]
        [Trait("Gets", "UFEntity")]
        public async Task E_Possivel_Gets_UF()
        {
            using (var context = _serviceProvider.GetService<MyContext>())
            {
                UFImplementation _repositorio = new UFImplementation(context);
                
                UFEntity _ufEntity = new UFEntity
                {
                    Id = new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                    NomeUF = "Acre",
                    SiglaUF = "AC"
                };

                var _registroSelecionado = await _repositorio.SelectAsync(_ufEntity.Id);
                
                Assert.NotNull(_registroSelecionado);
                Assert.True(_ufEntity.NomeUF.Equals(_registroSelecionado.NomeUF));
            }
        }
    }
}
