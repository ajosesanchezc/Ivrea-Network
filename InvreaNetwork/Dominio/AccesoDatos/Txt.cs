using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Dominio;

namespace AccesoDatos
{
    public class Txt
    {

        public Boolean guardarListaUsuario(List<Usuario> listaUsuario)
        {
            String path = @"C:\pruebas";
            System.IO.Directory.CreateDirectory(path); 
            String newFilName = "usuario.txt";
            path = System.IO.Path.Combine(path, newFilName);
            try
            {
                StreamWriter writer = File.CreateText(path);
                foreach (Usuario usuario in listaUsuario)
                {
                    String cadena = usuario.Nick + "_" + usuario.Clave + "_" + usuario.Departamento;
                    writer.WriteLine(cadena);
                }
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean guardarListaInventario(List<Activo> listaInventario)
        {
            //// crea una carpeta especifica
            string newPath = @"C:\pruebas";

            // Crea la Carpeta
            //System.IO.Directory.CreateDirectory(newPath);

            // crea un nuevo archivo 
            string newFileName = "ListaInventario.txt";

            // Combina el nuevo archivo con el path de la ruta
            newPath = System.IO.Path.Combine(newPath, newFileName);

            try
            {
                StreamWriter writer = File.CreateText(newPath);

                foreach (Activo activo in listaInventario)
                {
                    String cadena = activo.Codigo + " " + activo.Nombre + " " + activo.Cantidad + " " + activo.Precio;
                    writer.WriteLine(cadena);
                }
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        public List<Usuario> cargarListaUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            string path = @"C:\pruebas\usuario.txt";
            Usuario usuario;
            try
            {
                String[] readBuffer = System.IO.File.ReadAllLines(path);
                foreach (string b in readBuffer)
                {
                    String[] palabra = b.Split('_');
                    Console.Write("----");
                    Console.WriteLine(b);
                    Console.WriteLine("---");
                    usuario = new Usuario(palabra[0], palabra[1], palabra[2]);
                    listaUsuario.Add(usuario);
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return listaUsuario;
        }




        public List<Activo> cargarListaInventario()
        {
            List<Activo> listaInventario = new List<Activo>();
            string newPath = @"C:\pruebas\ListaInventario.txt";
            Activo activo;
            try
            {
                string[] readBuffer = System.IO.File.ReadAllLines(newPath);
                foreach (string b in readBuffer)
                {
                    String[] palabra = b.Split(' ');
                
                    activo = new Activo(palabra[0], palabra[1], int.Parse(palabra[2]), float.Parse(palabra[3]));
                    listaInventario.Add(activo); ;
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return listaInventario;
        }

    }
}
