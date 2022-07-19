using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.CEP
{
    public class CepDtoUpdate
    {
        [Required(ErrorMessage = "Informe o Id")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Informe o CEP")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Informe o Logradouro")]
        public string Logradouro { get; set; }
        public string NumeroLogradouro { get; set; }
        [Required(ErrorMessage = "Informe o Id do Municipio")]
        public Guid MunicipioId { get; set; }
    }
}