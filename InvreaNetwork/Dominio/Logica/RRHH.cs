using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using AccesoDatos;

namespace Logica
{
    public class RRHH
    {
        private List<Empleado> listaEmpleado = new List<Empleado>();
        Xml xml = new Xml();

        public RRHH()
        {
            listaEmpleado = xml.cargarlistaRecursos();
        }

        public List<Empleado> ListaEmpleado
        {
            get { return listaEmpleado; }
            set { listaEmpleado = value; }
        }


        //<summary>
        //Sirve para obtener un empleado con todos sus datos con solo proporcionar su CI
        //</summary>
        public Empleado obtenerEmpleado(long CI)
        {
            foreach (Empleado empleado in listaEmpleado)
            {
                if (empleado.CI1 == CI)
                    return (empleado);
            }
            return (null);
        }

        //    <summary>
        //    Inserta un nuevo empleado en la lista de empleados de RRHH, si la CI ya existe no inserta el nuevo empleado
        //    </summary>
        public String insertarEmpleado(String nombre, String apellido, DateTime fechaIngreso, String cargo, long CI, float costo, DateTime fechaNac)
        {
            Empleado empleadoExist = obtenerEmpleado(CI);
            if (empleadoExist == null)
            {
                Empleado empleado = new Empleado(nombre, apellido, fechaIngreso, cargo, CI, costo, fechaNac);
                listaEmpleado.Add(empleado);
                if (xml.agregarEmpleado(empleado))
                    return "";
                else
                    return "Error al almacenar información en disco";
            }
            return "Error, la cedula de identidad " + CI + " ya existe";

        }

        //    <summary>
        //    Elimina el empleado indicado con solo proporcionar su CI, se basa en el metodo "obtenerEmpleado" para 
        //    obtener el objeto de tipo Persona a eliminar
        //    </summary>
        public String eliminarEmpleado(long CI)
        {
            Empleado empleado = obtenerEmpleado(CI);
            if (empleado != null)
            {
                listaEmpleado.Remove(empleado);
                if (xml.eliminarEmpleado(String.Concat(CI)))
                    return "";
                else
                    return "Error al modificar información en disco";

            }
            return "Error, la cedula de identidad " + CI + " no existe";
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
        //    modifica uno o varios campos de acuerdo al valor indicado, manejado por su identificador (Cedula). Se asegura que la cedula
        //    exista para luego realizar el recorrido de modificaciones
        //    </summary>
        public String modificarEmpleado(String[] vector)
        {
            Console.WriteLine(vector.Length);

            foreach (String nombre in vector) 
            {
                Console.WriteLine(nombre);
            }
            
            int modificados = 0;
            long cedula = long.Parse(vector[1]);
            if (obtenerEmpleado(cedula) != null)
            {
                int limite = vector.Length - 2;
                for (int i = 2; i <= limite; i++)
                {
                    Console.WriteLine("empleado existe");
                    if (modEmpleado(cedula, vector[i], vector[i + 1]))
                    {

                        modificados = modificados + 2;
                        Console.WriteLine("entre al if, valor de i "+i);
                    }
                    i++;
                }
                int totalModificados = vector.Length - 3;
                if (modificados == totalModificados)
                    return "";
                else
                    return "Error al modificar información en disco";
            }
            return "Error, la cedula de identidad " + vector[1] + " no existe";
        }

        //    <summary>
        //    modifica el valor del campo indicado en el empleado, manejado por su identificador (CI). Se asegura que la CI 
        //    exista para luego realizar el recorrido
        //    </summary>
        private bool modEmpleado(long CI, String campo, String valor)
        {
                foreach (Empleado empleado in listaEmpleado)
                {
                    Boolean resultado;
                    if (empleado.CI1 == CI)
                    {
                        switch (campo)
                        {
                            case "nombre": empleado.Nombre = valor;
                                resultado = xml.modificarEmpleado(String.Concat(CI), "nombre", valor);
                                break;
                            case "apellido": empleado.Apellido = valor;
                                resultado = xml.modificarEmpleado(String.Concat(CI), "apellido", valor);
                                break;
                            case "fechaIngreso": empleado.FechaIngreso = obtenerFecha(valor);
                                resultado = xml.modificarEmpleado(String.Concat(CI), "fechaIngreso", valor);
                                break;
                            case "cargo": empleado.Cargo = valor;
                                Console.WriteLine( resultado = xml.modificarEmpleado(String.Concat(CI), "cargo", valor));
                                break;
                            case "cedula":
                                if (obtenerEmpleado(long.Parse(valor)) == null)
                                {
                                    empleado.CI1 = long.Parse(valor);
                                    resultado = xml.modificarEmpleado(String.Concat(CI), "cedula", valor);
                                }
                                else
                                    return false;
                                break;
                            case "costo": empleado.Costo = float.Parse(valor);
                                resultado = xml.modificarEmpleado(String.Concat(CI), "costo", valor);
                                break;
                            case "fechaNacimiento": empleado.FechaNac = obtenerFecha(valor);
                                resultado = xml.modificarEmpleado(String.Concat(CI), "fechaNacimiento", valor);
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
