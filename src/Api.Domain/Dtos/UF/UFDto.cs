using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.UF
{
    public class UFDto
    {
        public Guid Id { get; set; }
        public string SiglaUF { get; set; }
        public string NomeUF { get; set; }
    }
}