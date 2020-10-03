using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class TipoSolicitacao
    {
        private int _cd_TpSolicitacao;
        private string _tp_Solicitacao;
        
        public TipoSolicitacao()
        {
        }
        public int Cd_TpSolicitacao
        {
            get { return _cd_TpSolicitacao; }
            set { _cd_TpSolicitacao = value; }
        }
        public string Tp_Solicitacao
        {
            get { return _tp_Solicitacao; }
            set { _tp_Solicitacao = value; }
        }
    }
}
