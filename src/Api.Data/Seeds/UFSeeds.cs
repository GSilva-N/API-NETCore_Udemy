using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Seeds
{
    public static class UFSeeds
    {
        public static void Ufs(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UFEntity>().HasData(
                new UFEntity()
                {
                    Id = new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                    SiglaUF = "AC",
                    NomeUF = "Acre",
                    CreateAt = DateTime.UtcNow
                },
                new UFEntity()
                {
                    Id = new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                    SiglaUF = "AL",
                    NomeUF = "Alagoas",
                    CreateAt = DateTime.UtcNow
                },
                new UFEntity()
                {
                    Id = new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                    SiglaUF = "AM",
                    NomeUF = "Amazonas",
                    CreateAt = DateTime.UtcNow
                },
                 new UFEntity()
                 {
                     Id = new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                     SiglaUF = "AP",
                     NomeUF = "Amapá",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                     SiglaUF = "BA",
                     NomeUF = "Bahia",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                     SiglaUF = "CE",
                     NomeUF = "Ceará",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                     SiglaUF = "DF",
                     NomeUF = "Distrito Federal",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                     SiglaUF = "ES",
                     NomeUF = "Espírito Santo",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                     SiglaUF = "GO",
                     NomeUF = "Goiás",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                     SiglaUF = "MA",
                     NomeUF = "Maranhão",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                     SiglaUF = "MG",
                     NomeUF = "Minas Gerais",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                     SiglaUF = "MS",
                     NomeUF = "Mato Grosso do Sul",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                     SiglaUF = "MT",
                     NomeUF = "Mato Grosso",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                     SiglaUF = "PA",
                     NomeUF = "Pará",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                     SiglaUF = "PB",
                     NomeUF = "Paraíba",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                     SiglaUF = "PE",
                     NomeUF = "Pernambuco",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                     SiglaUF = "PI",
                     NomeUF = "Piauí",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                     SiglaUF = "PR",
                     NomeUF = "Paraná",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                     SiglaUF = "RJ",
                     NomeUF = "Rio de Janeiro",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                     SiglaUF = "RN",
                     NomeUF = "Rio Grande do Norte",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                     SiglaUF = "RO",
                     NomeUF = "Rondônia",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                     SiglaUF = "RR",
                     NomeUF = "Roraima",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                     SiglaUF = "RS",
                     NomeUF = "Rio Grande do Sul",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                     SiglaUF = "SC",
                     NomeUF = "Santa Catarina",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                     SiglaUF = "SE",
                     NomeUF = "Sergipe",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                     SiglaUF = "SP",
                     NomeUF = "São Paulo",
                     CreateAt = DateTime.UtcNow
                 },
                 new UFEntity()
                 {
                     Id = new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                     SiglaUF = "TO",
                     NomeUF = "Tocantins",
                     CreateAt = DateTime.UtcNow
                 }
            );
        }
    }
}
