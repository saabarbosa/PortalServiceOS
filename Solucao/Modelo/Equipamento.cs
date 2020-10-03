using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Equipamento
    {
        private int _cd_Equipamento;
        private string _nm_Equipamento;
        private string _ds_Equipamento;
        private int _cd_Cliente;
        private string _nm_Cliente;

        private string _nm_Serial;
        private string _nm_Localizador;
        private string _identificador;
 
        public Equipamento()
        {
        }
        public int Cd_Equipamento
        {
            get { return _cd_Equipamento; }
            set { _cd_Equipamento = value; }
        }
        public string Nm_Equipamento
        {
            get { return _nm_Equipamento; }
            set { _nm_Equipamento = value; }
        }
        public string Ds_Equipamento
        {
            get { return _ds_Equipamento; }
            set { _ds_Equipamento = value; }
        }

        public int Cd_Cliente
        {
            get { return _cd_Cliente; }
            set { _cd_Cliente = value; }
        }
        public string Nm_Cliente
        {
            get { return _nm_Cliente; }
            set { _nm_Cliente = value; }
        }

        public string Nm_Serial
        {
            get { return _nm_Serial; }
            set { _nm_Serial = value; }
        }

        public string Nm_Localizador
        {
            get { return _nm_Localizador; }
            set { _nm_Localizador = value; }
        }


        public string Identificador
        {
            get { return _identificador; }
            set { _identificador = value; }
        }
    }
}
