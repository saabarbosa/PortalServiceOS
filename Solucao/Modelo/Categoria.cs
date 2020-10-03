using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Categoria
    {
        private int _id_Categoria;        
        private string _nm_Categoria;        

        public Categoria()
        {
        }
        public int Id_Categoria
        {
            get { return _id_Categoria; }
            set { _id_Categoria = value; }
        }
        public string Nm_Categoria
        {
            get { return _nm_Categoria; }
            set { _nm_Categoria = value; }
        }
    }
}
