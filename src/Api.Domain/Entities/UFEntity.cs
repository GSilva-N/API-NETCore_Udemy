using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class UFEntity : BaseEntity
    {
        [Required]
        [MaxLength(2)]
        public string SiglaUF { get; set; }
        [Required]
        [MaxLength(45)]
        public string NomeUF { get; set; }
        public List<MunicipioEntity> Municipios { get; set; }
    }
}