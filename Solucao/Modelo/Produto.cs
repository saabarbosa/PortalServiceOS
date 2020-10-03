using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Produto
    {
        private int _id_Produto;
        private int _id_Categoria;

        private string _nm_Produto;
        private string _ds_Produto;        
        private byte[] _img_Produto;
        private string _tam_Produto;
        private string _url_Produto;
        private string _nm_Categoria;

        private string _nr_Ordem;

        private string _orca_tp_impressao;
        private string _orca_vl_impressao;
        private string _orca_conexao;
        private string _orca_frente_verso;
        private string _orca_scanner;
        private string _orca_fax;
        private string _orca_alimentador;

        public Produto()
        {
        }
        public int Id_Produto
        {
            get { return _id_Produto; }
            set { _id_Produto = value; }
        }
        public int Id_Categoria
        {
            get { return _id_Categoria; }
            set { _id_Categoria = value; }
        }

        public string Nm_Produto
        {
            get { return _nm_Produto; }
            set { _nm_Produto = value; }
        }
        public string Ds_Produto
        {
            get { return _ds_Produto; }
            set { _ds_Produto = value; }
        }
        public byte[] Img_Produto
        {
            get { return _img_Produto; }
            set { _img_Produto = value; }
        }
        public string Tam_Produto
        {
            get { return _tam_Produto; }
            set { _tam_Produto = value; }
        }
        public string Url_Produto
        {
            get { return _url_Produto; }
            set { _url_Produto = value; }
        }
        public string Nm_Categoria
        {
            get { return _nm_Categoria; }
            set { _nm_Categoria = value; }
        }

        public string Nr_Ordem
        {
            get { return _nr_Ordem; }
            set { _nr_Ordem = value; }
        }

        public string Orca_Tp_Impressao
        {
            get { return _orca_tp_impressao; }
            set { _orca_tp_impressao = value; }
        }

        public string Orca_Vl_Impressao
        {
            get { return _orca_vl_impressao; }
            set { _orca_vl_impressao = value; }
        }

        public string Orca_Conexao
        {
            get { return _orca_conexao; }
            set { _orca_conexao = value; }
        }

        public string Orca_Frente_Verso
        {
            get { return _orca_frente_verso; }
            set { _orca_frente_verso = value; }
        }

        public string Orca_Scanner
        {
            get { return _orca_scanner; }
            set { _orca_scanner = value; }
        }

        public string Orca_Fax
        {
            get { return _orca_fax; }
            set { _orca_fax = value; }
        }

        public string Orca_Alimentador
        {
            get { return _orca_alimentador; }
            set { _orca_alimentador = value; }
        }

    }
}
