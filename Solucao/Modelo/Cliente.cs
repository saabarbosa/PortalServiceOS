using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Cliente
    {
        private int _cd_Cliente;
        private string _id_Login;
        private string _senha;
        private string _nm_Cliente;
        private string _nr_Cpf;        
        private string _nr_Cnpj;        
        private string _ds_Endereco;       
        private string _ds_Telefone;        
        private Object _UserId;
        private string _username;
        private string _nm_Base;   

        public Cliente()
        {
        }
        public int Cd_Cliente
        {
            get { return _cd_Cliente; }
            set { _cd_Cliente = value; }
        }
        public string Id_Login
        {
            get { return _id_Login; }
            set { _id_Login = value; }
        }
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        public string Nm_Cliente
        {
            get { return _nm_Cliente; }
            set { _nm_Cliente = value; }
        }
        public string Nr_Cpf
        {
            get { return _nr_Cpf; }
            set { _nr_Cpf = value; }
        }
        public string Nr_Cnpj
        {
            get { return _nr_Cnpj; }
            set { _nr_Cnpj = value; }
        }
        public string Ds_Endereco
        {
            get { return _ds_Endereco; }
            set { _ds_Endereco = value; }
        }
        public string Ds_Telefone
        {
            get { return _ds_Telefone; }
            set { _ds_Telefone = value; }
        }
        public Object UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Nm_Base
        {
            get { return _nm_Base; }
            set { _nm_Base = value; }
        }
    }
}
