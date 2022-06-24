using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Insira um email para realizar o Login")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }
    }
}