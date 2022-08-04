using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class UFModel : BaseModel
    {
        private string _siglaUF;
        public string SiglaUF 
        { 
          get { return _siglaUF; }
          set { _siglaUF = value; } 
        }

        private string _nomeUF;
        public string NomeUF
        {
            get { return _nomeUF; }
            set { _nomeUF = value; }
        }

    }
}
