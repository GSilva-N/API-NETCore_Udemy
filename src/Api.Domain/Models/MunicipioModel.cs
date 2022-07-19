using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class MunicipioModel: BaseModel
    {
        private string _nomeMunicipio;

        public string NomeMunicipio
        {
            get { return _nomeMunicipio; }
            set { _nomeMunicipio = value; }
        }

        private int _codigoIBGE;

        public int CodigoIBGE
        {
            get { return _codigoIBGE; }
            set { _codigoIBGE = value; }
        }

        private Guid _ufId;

        public Guid UfId
        {
            get { return _ufId; }
            set { _ufId = value; }
        }

    }
}
