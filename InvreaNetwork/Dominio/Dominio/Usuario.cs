using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
 public class Usuario
    {
        private String nick;
        private String clave;
        private String departamento;

        public Usuario()
        {}

        public Usuario(String nick, String clave, String departamento)
        {
            this.nick = nick;
            this.clave = clave;
            this.departamento = departamento;
        }


        public override string ToString()
        {
            String cadena = "Nick: " + nick + " clave " + clave + "departamento " + departamento;
            return cadena;
        }


     public String Nick
        {
            get { return nick; }
            set { nick = value; }
        }
     public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }
     public String Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }





    }
}
 