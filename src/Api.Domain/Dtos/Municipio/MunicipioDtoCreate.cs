using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.UF;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoCreate
    {
        [Required(ErrorMessage = "Informe o nome do Município")]
        public string NomeMunicipio { get; set; }
        [Range(0, int.MaxValue)]
        public int CodigoIBGE { get; set; }
        public Guid UFId { get; set; }
    }
}