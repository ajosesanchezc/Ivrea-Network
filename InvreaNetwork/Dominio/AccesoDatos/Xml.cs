using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Dominio;

namespace AccesoDatos
{
    public class Xml
    {
        String rutaProyecto;
        String rutaRecursos;
        XmlDocument xmlDocumentP;
        XmlDocument xmlDocumentR;
        Boolean rutas;

        public Xml()
        {
            rutas = true;
            crearRutasArchivos();
        }

        //<summary>
        //Metodo encargado de crear las rutas para los archivos de Recursos Humanos y Lista de Proyectos con sus elementos
        //raices empleados y proyectos respectivamentes
        //</summary>
        private void crearRutasArchivos()
        {
            xmlDocumentP = new XmlDocument();
            String path = @"C:\pruebas";
            System.IO.Directory.CreateDirectory(path); 
            rutaProyecto = @"C:\pruebas\ListaProyectos.xml";

            try
            {
                xmlDocumentP.Load(rutaProyecto);
            }
            catch (Exception)
            {
                XmlTextWriter xmlWriter = new XmlTextWriter(rutaProyecto, Encoding.UTF8);
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");
                xmlWriter.WriteStartElement("proyectos");
                xmlWriter.Close();
                xmlDocumentP.Load(rutaProyecto);
            }

            xmlDocumentR = new XmlDocument();
            rutaRecursos = @"C:\pruebas\ListaRecursosHumanos.xml";
            try
            {
                xmlDocumentR.Load(rutaRecursos);

            }
            catch (Exception)
            {
                XmlTextWriter xmlWriter = new XmlTextWriter(rutaRecursos, Encoding.UTF8);
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");
                xmlWriter.WriteStartElement("empleados");
                xmlWriter.Close();
                xmlDocumentR.Load(rutaRecursos);
            }
        }


        //<summary>
        //Metodo encargado de eliminar un empleado del archivo de recursos humanos, con solo proporcionar su cedula de identidad
        //</summary>
        public Boolean eliminarEmpleado(String cedula)
        {
            int cont = 0;
            XmlNodeList empleados = xmlDocumentR.GetElementsByTagName("empleado");
            foreach (XmlElement nodo in empleados)
            {
                if (nodo.GetAttribute("cedula") == cedula)
                {
                    cont = 1;
                    nodo.ParentNode.RemoveChild(nodo);
                    break;
                }
            }

            if (cont == 1)
            {
                try
                {
                    xmlDocumentR.Save(rutaRecursos);
                    return true;
                }
                catch (XmlException)
                {
                    return false;
                }
            }
            return false;
        }

        //<summary>
        //Metodo encargado de eliminar un empleado del archivo de recursos humanos, con solo proporcionar su cedula de identidad
        //el campo a modificar y el nuevo valor del campo
        //</summary>
        public Boolean modificarEmpleado(String cedula, String campo, String valor)
        {
            int cont = 0;
            XmlNodeList empleados = xmlDocumentR.GetElementsByTagName("empleado");
            foreach (XmlElement nodo in empleados)
            {
                if (nodo.GetAttribute("cedula") == cedula)
                {
                    cont = 1;
                    nodo.SetAttribute(campo, valor);
                }
            }

            if (cont == 1)
            {
                try
                {
                    xmlDocumentR.Save(rutaRecursos);
                    return true;
                }
                catch (XmlException)
                {
                    return false;
                }
            }
            return false;
        }

        //<summary>
        //Metodo encargado de eliminar un proyecto del archivo de gerencia de proyecto, con solo proporcionar el codigo del proyecto
        //</summary>
        public Boolean eliminarProyecto(String codigo)
        {
            int cont = 0;
            XmlNodeList proyectos = xmlDocumentP.GetElementsByTagName("proyecto");
            foreach (XmlElement nodo in proyectos)
            {
                if (nodo.GetAttribute("codigo") == codigo)
                {
                    cont = 1;
                    nodo.ParentNode.RemoveChild(nodo);
                    break;
                }

            }

            if (cont == 1)
            {
                try
                {
                    xmlDocumentP.Save(rutaProyecto);
                    return true;
                }
                catch (XmlException e)
                {
                    Console.WriteLine(e);
                    return false;
                }
            }
            return false;
        }

        //<summary>
        //Metodo encargado de eliminar un proyecto del archivo de gerencia de proyecto, con solo proporcionar su codigo de proyecto
        //el campo a modificar y el nuevo valor del campo.
        //</summary>
        public Boolean modificarProyecto(String codigo, String campo, String valor)
        {
            int cont = 0;
            XmlNodeList proyectos = xmlDocumentP.GetElementsByTagName("proyecto");
            foreach (XmlElement nodo in proyectos)
            {
                if (nodo.GetAttribute("codigo") == codigo)
                {
                    cont = 1;
                    nodo.SetAttribute(campo, valor);
                }
            }

            if (cont == 1)
            {
                try
                {
                    xmlDocumentP.Save(rutaProyecto);
                    return true;
                }
                catch (XmlException)
                {
                    return false;
                }
            }
            return false;
        }


        //<summary>
        //Metodo encargado de transformar de tipo DateTime a string para realizar la escritura en archivo
        //</summary>
        private String obtenerFechaString(DateTime fecha)
        {
            String fechaString = null;
            fechaString = String.Concat(fecha.Day);
            fechaString = fechaString + @"/" + String.Concat(fecha.Month) + @"/" + String.Concat(fecha.Year);
            return fechaString;
        }

        //<summary>
        //Metodo encargado de agregar al archivo todo los proyectos existentes en lista, usa el 
        //metodo agregarProyecto que agrega cada nodo(proyecto) de la lista
        //</summary>
        public Boolean guardarListaProyecto(List<Proyecto> listaProyecto)
        {
            int cont = 0;
            foreach (Proyecto proyecto in listaProyecto)
            {
                if (agregarProyecto(proyecto) == false)
                    cont++;
            }
            if (cont == 0)
                return true;
            return false;
        }


        //<summary>
        //Metodo encargado de agregar un nuevo proyecto al archivo
        //</summary>
        public Boolean agregarProyecto(Proyecto proyecto)
        {
            XmlNode root = xmlDocumentP.DocumentElement;
            XmlElement nodoProyecto = xmlDocumentP.CreateElement("proyecto");
            nodoProyecto.SetAttribute("codigo", proyecto.Codigo);
            nodoProyecto.SetAttribute("nombre", proyecto.Nombre);
            nodoProyecto.SetAttribute("fechaInicio", obtenerFechaString(proyecto.FechaInicio));
            nodoProyecto.SetAttribute("fechaFin", obtenerFechaString(proyecto.FechaFin));
            nodoProyecto.SetAttribute("presupuesto", String.Concat(proyecto.Presupuesto));
            root.AppendChild(nodoProyecto);
            Boolean resultado = true;

            try
            {
                xmlDocumentP.Save(rutaProyecto);
            }
            catch (XmlException)
            {
                resultado = false;
            }
            return resultado;
        }

        //<summary>
        //Metodo encargado de tranformar un string de fecha(01/01/2000) a un objeto de tipo DateTime
        //</summary>
        private DateTime obtenerFecha(String strig)
        {
            String[] vector = strig.Split('/');

            DateTime fecha = new DateTime(int.Parse(vector[2]), int.Parse(vector[1]), int.Parse(vector[0]));
            return (fecha);

        }

        //<summary>
        //Metodo encargado de cargar del archivo todos los proyectos existentes y guardarlos en la lista para realizar el 
        //manejo de la misma
        //</summary>
        public List<Proyecto> cargarlistaProyecto()
        {
            List<Proyecto> listaProyecto = new List<Proyecto>();
            XmlNodeList proyectos = xmlDocumentP.GetElementsByTagName("proyecto");
            foreach (XmlElement nodo in proyectos)
            {
                Proyecto proyecto = new Proyecto();
                proyecto.Codigo = nodo.GetAttribute("codigo");
                proyecto.FechaInicio = obtenerFecha(nodo.GetAttribute("fechaInicio"));
                proyecto.FechaFin = obtenerFecha(nodo.GetAttribute("fechaFin"));
                proyecto.Nombre = nodo.GetAttribute("nombre");
                proyecto.Presupuesto = float.Parse(nodo.GetAttribute("presupuesto"));
                listaProyecto.Add(proyecto);
            }
            return listaProyecto;
        }

        //<summary>
        //Metodo encargado de agregar al archivo todo los empleados existentes en lista, usa el 
        //metodo agregarEmpleado que agrega cada nodo(empleado) de la lista
        //</summary>
        public Boolean guardarListaRecursos(List<Empleado> listaRecursos)
        {
            int cont = 0;
            foreach (Empleado empleado in listaRecursos)
            {
                if (agregarEmpleado(empleado) == false)
                    cont++;
            }
            if (cont == 0)
                return true;
            return false;
        }

        //<summary>
        //Metodo encargado de agregar un nuevo Empleado al archivo de Recursos Humanos
        //</summary>
        public Boolean agregarEmpleado(Empleado empleado)
        {
            Boolean resultado;
            if (rutas)
            {
                XmlNode root = xmlDocumentR.DocumentElement;
                XmlElement nodoEmpleado = xmlDocumentR.CreateElement("empleado");
                nodoEmpleado.SetAttribute("nombre", empleado.Nombre);
                nodoEmpleado.SetAttribute("apellido", empleado.Apellido);
                nodoEmpleado.SetAttribute("fechaIngreso", obtenerFechaString(empleado.FechaIngreso));
                nodoEmpleado.SetAttribute("cargo", empleado.Cargo);
                nodoEmpleado.SetAttribute("cedula", String.Concat(empleado.CI1));
                nodoEmpleado.SetAttribute("costo", String.Concat(empleado.Costo));
                nodoEmpleado.SetAttribute("fechaNacimiento", obtenerFechaString(empleado.FechaNac));
                root.AppendChild(nodoEmpleado);
                resultado = true;
            }
            else
                resultado = false;

            try
            {
                xmlDocumentR.Save(rutaRecursos);
            }
            catch (XmlException)
            {
                resultado = false;
            }
            return resultado;
        }

        //<summary>
        //Metodo encargado de cargar del archivo todos los empleados existentes y guardarlos en la lista para realizar el 
        //manejo de la misma
        //</summary>
        public List<Empleado> cargarlistaRecursos()
        {
            List<Empleado> listaRecursos = new List<Empleado>();
            XmlNodeList empleados = xmlDocumentR.GetElementsByTagName("empleado");
            foreach (XmlElement nodo in empleados)
            {
                Empleado empleado = new Empleado();
                empleado.Nombre = nodo.GetAttribute("nombre");
                empleado.Apellido = nodo.GetAttribute("apellido");
                empleado.FechaIngreso = obtenerFecha(nodo.GetAttribute("fechaIngreso"));
                empleado.FechaNac = obtenerFecha(nodo.GetAttribute("fechaNacimiento"));
                empleado.Costo = float.Parse(nodo.GetAttribute("costo"));
                empleado.CI1 = long.Parse(nodo.GetAttribute("cedula"));
                empleado.Cargo = nodo.GetAttribute("cargo");
                listaRecursos.Add(empleado);
            }
            return listaRecursos;
        }



    }
}
