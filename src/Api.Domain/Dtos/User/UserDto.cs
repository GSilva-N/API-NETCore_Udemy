using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.User
{
    public class UserDto
    {
        [Required(ErrorMessage = "Nome é um Campo Obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Email é um campo obrigatório")]
        [EmailAddress]
        public string Email { get; set; }
    }
}