using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using AccesoDatos;

namespace Logica
{
    public class GP
    {
        private List<Proyecto> listaProyecto = new List<Proyecto>();
        Xml xml = new Xml();

        public GP()
        {
            listaProyecto = xml.cargarlistaProyecto();
        }

        public List<Proyecto> ListaProyecto
        {
            get { return listaProyecto; }
            set { listaProyecto = value; }

        }

        //<summary>
        //Sirve para obtener un proyecto con todos sus datos con solo proporcionar su codigo, si no existe retorna null
        //</summary>
        public Proyecto obtenerProyecto(String codigo)
        {
            foreach (Proyecto proyecto in listaProyecto)
            {
                if (proyecto.Codigo == codigo)
                    return (proyecto);
            }
            return (null);
        }

        //    <summary>
        //    Inserta un nuevo proyecto en la lista de proyectos de GP
        //    </summary>
        public String insertarProyecto(String codigo, String nombre, DateTime fechaInicio, DateTime fechaFin, float presupuesto)
        {
            Proyecto proyectoExist = obtenerProyecto(codigo);
            if (proyectoExist == null)
            {
                Proyecto proyecto = new Proyecto(codigo, nombre, fechaInicio, fechaFin, presupuesto);
                listaProyecto.Add(proyecto);
                if (xml.agregarProyecto(proyecto))
                    return "";
                else
                    return "Error al almacenar información en disco";
            }
            else
              return "Error, el codigo " + codigo +" ya existe";
            
        }

        //    <summary>
        //    Elimina el proyecto indicado con solo proporcionar su Codigo, se basa en el metodo "obtenerProyecto" para 
        //    obtener el objeto de tipo Proyecto a eliminar
        //    </summary>
        public String eliminarProyecto(String codigo)
        {
            Proyecto proyecto = obtenerProyecto(codigo);
            if (proyecto != null)
            {
                listaProyecto.Remove(proyecto);
                if (xml.eliminarProyecto(codigo))
                    return "";
                else 
                    return "Error al modificar información en disco";
            }
            else 
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
        //    modifica el valor de los campos indicados, manejado por su identificador (Codigo). Se asegura que el codigo del proyecto
        //    exista para luego realizar el recorrido de modificaciones
        //    </summary>
        public String modificarProyecto(String[] vector)
        {
            int modificados = 0;
            String codigo = vector[1];
            if (obtenerProyecto(codigo) != null)
            {
                int limite = vector.Length - 2;
                for (int i = 2; i <= limite; i++)
                {
                    if (modProyecto(codigo, vector[i], vector[i + 1]))
                        modificados = modificados+2;
                    i++;
                }
                int totalModificados = vector.Length-3;
                if (modificados == totalModificados)
                    return "";
                else
                    return "Error al modificar información en disco";

            }
                return "Error, el codigo " + codigo + " no existe";
        }

        //    <summary>
        //    modifica el valor del campo indicado en el proyecto, manejado por su identificador (Codigo). Se asegura que el codigo 
        //    exista para luego realizar el recorrido
        //    </summary>
        private bool modProyecto(String codigo, String campo, String valor)
        {
                Boolean resultado;
                foreach (Proyecto proyecto in listaProyecto)
                {
                    if (proyecto.Codigo == codigo)
                    {
                        switch (campo)
                        {
                            case "nombre": proyecto.Nombre = valor;
                                resultado = xml.modificarProyecto(codigo, "nombre", valor);
                                break;
                            case "codigo":
                                if (obtenerProyecto(valor) == null)
                                {
                                    proyecto.Codigo = valor;
                                    resultado = xml.modificarProyecto(codigo, "codigo", valor);
                                }
                                else
                                    return false;
                                break;
                            case "fechaInicio": proyecto.FechaInicio = obtenerFecha(valor);
                                resultado = xml.modificarProyecto(codigo, "fechaInicio", valor);
                                break;
                            case "fechaFin": proyecto.FechaFin = obtenerFecha(valor);
                                resultado = xml.modificarProyecto(codigo, "fechaFin", valor);
                                break;
                            case "presupuesto": proyecto.Presupuesto = float.Parse(valor);
                                resultado = xml.modificarProyecto(codigo, "presupuesto", valor);
                                break;
                            default:
                                return false;
                        }
                        return resultado;
                    }
                }
            return false;

        }


    }
}
