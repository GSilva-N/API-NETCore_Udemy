using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class UFModel : BaseModel
    {
        private string _siglaUf;
        public string SiglaUf 
        { 
          get { return _siglaUf; }
          set { _siglaUf = value; } 
        }

        private string _nomeUf;
        public string NomeUf
        {
            get { return _nomeUf; }
            set { _nomeUf = value; }
        }

    }
}
