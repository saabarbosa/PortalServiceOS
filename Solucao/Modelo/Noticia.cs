using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Noticia
    {
        private int _id_Noticia;

        private string _ds_Manchete;
        private string _ds_Chamada;        
        private string _ds_Conteudo;
        private DateTime _dt_Criacao;

        public Noticia()
        {
        }
        public int Id_Noticia
        {
            get { return _id_Noticia; }
            set { _id_Noticia = value; }
        }
        public string Ds_Manchete
        {
            get { return _ds_Manchete; }
            set { _ds_Manchete = value; }
        }
        public string Ds_Chamada
        {
            get { return _ds_Chamada; }
            set { _ds_Chamada = value; }
        }
        public string Ds_Conteudo
        {
            get { return _ds_Conteudo; }
            set { _ds_Conteudo = value; }
        }

        public DateTime Dt_Criacao
        {
            get { return _dt_Criacao; }
            set { _dt_Criacao = value; }
        }


    }
}
