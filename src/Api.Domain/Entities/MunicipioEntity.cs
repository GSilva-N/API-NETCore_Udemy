using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class MunicipioEntity : BaseEntity
    {
        [Required]
        [MaxLength(45)]
        public string NomeMunicipio { get; set; }
        public int CodigoIBGE { get; set; }
        [Required]
        public Guid UFId { get; set; }
        public UFEntity UF { get; set; }

        public List<CepEntity> Ceps { get; set; }
    }
}