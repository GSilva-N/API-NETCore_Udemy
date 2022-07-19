using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDto
    {
        public Guid Id { get; set; }
        public string NomeMunicipio { get; set; }
        public int CodigoIBGE { get; set; }
        public Guid UFId { get; set; }
    }
}