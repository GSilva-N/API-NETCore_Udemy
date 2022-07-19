using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class CepModel
    {
        private string _cep;

        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private string _logradouro;

        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        private string _numeroLogradouro;

        public string NumeroLogradouro
        {
            get { return _numeroLogradouro; }
            set { _numeroLogradouro = string.IsNullOrEmpty(value) ? "S/N" : value; }
        }

        private Guid _municipioId;

        public Guid MunicipioId
        {
            get { return _municipioId; }
            set { _municipioId = value; }
        }
    }
}
