using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using AccesoDatos;


namespace Logica
{
    public class ADI
    {
        private List<Activo> listaInventario = new List<Activo>();
        Txt txt;


        public List<Activo> ListaInventario
        {
            get { return listaInventario; }
            set { listaInventario = value; }
        }

        public ADI()
        {
            txt = new Txt();
            listaInventario = txt.cargarListaInventario();
        }

        //<summary>
        //Sirve para obtener un Activo con todos sus datos con solo proporcionar su codigo, si no existe retorna null
        //</summary>
        public Activo obtenerActivo(String codigo)
        {
            foreach (Activo activo in listaInventario)
            {
                if (activo.Codigo == codigo)
                    return (activo);
            }
            return (null);
        }

        //    <summary>
        //    Inserta un nuevo Activo en la lista de Inventario de GP
        //    </summary>
        public String insertarActivo(String codigo, String nombre, int cantidad, float precio)
        {
            Activo activoExist = obtenerActivo(codigo);
            if (activoExist == null)
            {
                Activo activo = new Activo(codigo, nombre, cantidad, precio);
                listaInventario.Add(activo);
                if (txt.guardarListaInventario(listaInventario))
                    return "";
                else
                    return "Error al almacenar información en disco";

            }
            return "Error, el codigo " + codigo + " no existe"; 
        }

        //    <summary>
        //    Elimina el activo indicado con solo proporcionar su Codigo, se basa en el metodo "obtenerCodigo" para 
        //    obtener el objeto de tipo Activo a eliminar
        //    </summary>
        public String eliminarActivo(String codigo)
        {
            Activo activo = obtenerActivo(codigo);
            if (activo != null)
            {
                listaInventario.Remove(activo);
                 if(txt.guardarListaInventario(listaInventario))
                    return "";
                 else
                     return "Error al modificar información en disco";
            }
            return "Error, el codigo " + codigo + " no existe"; 
        }


        //    <summary>
        //    Dado un String con la fecha, es transformado en un objeto de tipo DateTime
        //    </summary>
        private DateTime obtenerFecha(String cadena)
        {
            String[] vector = cadena.Split('/');
            DateTime fecha = new DateTime(int.Parse(vector[2]), int.Parse(vector[1]), int.Parse(vector[0]));
            return (fecha);

        }

        //    <summary>
        //    modifica el valor del campo indicado en el Inventario, manejado por su identificador (Codigo). Se asegura que el codigo 
        //    exista para luego realizar el recorrido de modificaciones
        //    </summary>
        public String modificarActivo(String[] vector)
        {
            int modificados = 0;
            String codigo = vector[1];
            if (obtenerActivo(codigo) != null)
            {
                int limite = vector.Length - 2;
                for (int i = 2; i <= limite; i++)
                {
                    if (modActivo(codigo, vector[i], vector[i + 1]))
                    {
                        if (txt.guardarListaInventario(listaInventario))
                            modificados = modificados + 2;
                    }
                    i++;
                }
                int totalModificados = vector.Length - 3;
                if (modificados == totalModificados)
                    return "";
                else
                    return "Error al modificar información en disco";
            }
            return "Error, el codigo " + codigo + " no existe";
        }


        //    <summary>
        //    modifica el valor del campo indicado en el Inventario, manejado por su identificador (Codigo). Se asegura que el codigo 
        //    exista para luego realizar el recorrido
        //    </summary>
        private Boolean modActivo(String codigo, String campo, String valor)
        {
                foreach (Activo activo in listaInventario)
                {
                    if (activo.Codigo == codigo)
                    {
                        switch (campo)
                        {
                            case "nombre": activo.Nombre = valor;
                                break;
                            case "codigo": if (obtenerActivo(valor) == null)
                                    activo.Codigo = valor;
                                else
                                    return false;
                                break;
                            case "cantidad": activo.Cantidad = int.Parse(valor);
                                break;
                            case "precio": activo.Precio = float.Parse(valor);
                                break;
                            default:
                                return false;
                        }
                        return true;
                    }
                }
            return false;

        }

    }
}
