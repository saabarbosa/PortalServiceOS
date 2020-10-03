using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Status
    {
        private int _cd_Status;
        private string _nm_Status;
               
        public Status()
        {
        }
        public int Cd_Status
        {
            get { return _cd_Status; }
            set { _cd_Status = value; }
        }
        public string Nm_Status
        {
            get { return _nm_Status; }
            set { _nm_Status = value; }
        }
    }
}
