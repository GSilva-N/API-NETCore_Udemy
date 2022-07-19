using System;
using Api.Domain.Dtos.UF;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoCompleto
    {
        public Guid Id { get; set; }
        public string NomeMunicipio { get; set; }
        public int CodigoIBGE { get; set; }
        public Guid UFId { get; set; }

        public UFDto UF { get; set; }
    }
}