using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Solicitacao
    {
        private int _cd_Solicitacao;
        private int _cd_TpSolicitacao;
        private int _cd_Status;
        private int _cd_Equipamento;
        private DateTime _dt_Solicitacao;
        private int _cd_cliente;
        private string _nm_Cliente;
        private string _ds_Solicitacao;
        private string _nm_Equipamento;
        private string _nm_Localizador;
        private string _nm_Status;
        private string _tp_Solicitacao;
        private string _nm_Medidor;
        private string _ds_defeito;

        public Solicitacao()
        {
        }
        public int Cd_Solicitacao
        {
            get { return _cd_Solicitacao; }
            set { _cd_Solicitacao = value; }
        }
        public int Cd_TpSolicitacao
        {
            get { return _cd_TpSolicitacao; }
            set { _cd_TpSolicitacao = value; }
        }
        public int Cd_Status
        {
            get { return _cd_Status; }
            set { _cd_Status = value; }
        }
        public int Cd_Equipamento
        {
            get { return _cd_Equipamento; }
            set { _cd_Equipamento = value; }
        }
        public DateTime Dt_Solicitacao
        {
            get { return _dt_Solicitacao; }
            set { _dt_Solicitacao = value; }
        }
        public string Ds_Solicitacao
        {
            get { return _ds_Solicitacao; }
            set { _ds_Solicitacao = value; }
        }
        public int Cd_Cliente
        {
            get { return _cd_cliente; }
            set { _cd_cliente = value; }
        }
        public string Nm_Cliente
        {
            get { return _nm_Cliente; }
            set { _nm_Cliente = value; }
        }
        public string Nm_Equipamento
        {
            get { return _nm_Equipamento; }
            set { _nm_Equipamento = value; }
        }
        public string Nm_Localizador
        {
            get { return _nm_Localizador; }
            set { _nm_Localizador = value; }
        }
        public string Nm_Status
        {
            get { return _nm_Status; }
            set { _nm_Status = value; }
        }
        public string Tp_Solicitacao
        {
            get { return _tp_Solicitacao; }
            set { _tp_Solicitacao = value; }
        }
        public string Nm_Medidor
        {
            get { return _nm_Medidor; }
            set { _nm_Medidor = value; }
        }
        public string Ds_Defeito
        {
            get { return _ds_defeito; }
            set { _ds_defeito = value; }
        }
        
    }
}
