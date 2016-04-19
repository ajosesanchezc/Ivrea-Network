using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using AccesoDatos;

namespace Logica
{
    public class AC
    {
        private List<Usuario> listaUsuario = new List<Usuario>();

        private List<Usuario> ListaUsuario
        {
            get { return listaUsuario; }
            set { listaUsuario = value; }
        }


        public AC()
        {
            Txt txt = new Txt();
            listaUsuario = txt.cargarListaUsuario();
        }


        //<summary>
        //Sirve para obtener un Usuario con todos sus datos con solo proporcionar su nick
        //</summary>
        private Usuario obtenerUsuario(String nick)
        {
            foreach (Usuario usuario in listaUsuario)
            {
                if (usuario.Nick == nick)
                    return (usuario);
            }
            return (null);
        }

        public String obtenerDepartamentoUsuario(String nick, String clave)
        {
            Usuario usuario = obtenerUsuario(nick);
            if (usuario != null)
            {
                if (usuario.Clave == clave)
                    return usuario.Departamento;
                else
                    return ("Error, no coincide el Nick y Clave");
            }
          return("Error, el nick "+ nick + " no existe");

        }

        public String insertarUsuario(String nick, String clave, String departamento)
        {
            Usuario usuarioExist = obtenerUsuario(nick);

            if (usuarioExist == null)
            {
                Usuario usuario = new Usuario(nick,clave,departamento);
                listaUsuario.Add(usuario);
                Txt txt = new Txt();

                if(txt.guardarListaUsuario(listaUsuario))
                    return "";
                else
                    return "Error al modificar información en disco";
            }
            return "Error, el Nick " + nick + " ya existe";
        }

        
        //    <summary>
        //    Elimina un usuario con solo proporcionar su Codigo, se basa en el metodo "obtenerUsuario" para 
        //    obtener el objeto de tipo Usuario
        //    </summary>
        public String eliminarUsuario(String nick, String clave)
        {
            int error = 0;
            Usuario usuario = obtenerUsuario(nick);
            if (usuario != null)
            {
                if (usuario.Clave == clave)
                    listaUsuario.Remove(usuario);
                else
                    error = 1;
                
                Txt txt = new Txt();
                if (txt.guardarListaUsuario(listaUsuario) == false)
                    error = 2;

                switch (error)
                {
                    case 0: return "";
                    case 1: return "Error, el Nick y la Clave no coinciden ";
                    case 2: return "Error al modificar informacion en disco";
                }
                   
            }
            return "Error, el Nick " + nick + " no existe";

        }

    }
}