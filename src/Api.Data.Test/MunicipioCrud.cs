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
    public class MunicipioCrud: BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _service;

        public MunicipioCrud(DbTeste dbTeste)
        {
            _service = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName = "Crud de Municipio")]
        [Trait("Crud", "MinicipioEntity")]
        public async Task E_Possivel_Realizar_Crud_Municipio()
        {
            using(var context = _service.GetService<MyContext>())
            {
                MunicipioImplementation _repositorio = new MunicipioImplementation(context);
                MunicipioEntity _entity = new MunicipioEntity
                {
                    NomeMunicipio = Faker.Address.City(),
                    CodigoIBGE = Faker.RandomNumber.Next(1000000, 9999999),
                    UFId = new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a")
                };
                
                //Teste POST
                var _registroCriado = await _repositorio.InsertAsync(_entity);

                Assert.NotNull(_registroCriado);

                //Teste PUT
                _entity.NomeMunicipio = Faker.Address.City();
                _entity.Id = _registroCriado.Id;

                var _registroAtualizado = await _repositorio.UpdateAsync(_entity);
                Assert.NotNull(_registroAtualizado);
                Assert.Equal(_entity.NomeMunicipio, _registroAtualizado.NomeMunicipio);

                //Teste GET BY ID
                var _registroSelecionado = await _repositorio.SelectAsync(_registroAtualizado.Id);

                Assert.NotNull(_registroSelecionado);
                Assert.Equal(_registroAtualizado.NomeMunicipio, _registroSelecionado.NomeMunicipio);
                
                //Teste GET BY CODIGO IBGE
                _registroSelecionado = await _repositorio.GetCompleteByCodigoIBGE(_registroAtualizado.CodigoIBGE);

                Assert.NotNull(_registroSelecionado.UF);

                //Teste GET ALL
                var _listaRegistro = await _repositorio.SelectAsync();

                Assert.NotNull(_listaRegistro);
                Assert.True(_listaRegistro.Count>0);

                //Teste DELETE

                var _delete = await _repositorio.DeleteAsync(_registroAtualizado.Id);

                Assert.True(_delete);
            }
         
        }
    }
}
