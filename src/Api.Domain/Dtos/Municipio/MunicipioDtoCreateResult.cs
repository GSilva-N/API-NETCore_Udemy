using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.UF;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoCreateResult
    {
        public Guid Id { get; set; }
        public string NomeMunicipio { get; set; }
        public int CodigoIBGE { get; set; }
        public Guid UFId { get; set; }
        public UFDto UF { get; set; }
        public DateTime CreateAt { get; set; }
    }
}