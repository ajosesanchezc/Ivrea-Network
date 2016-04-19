using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace Logica
{
   public class Departamento
    {
       String respuesta; 
       ADI adi = new ADI();
       GP gp = new GP();
       RRHH rrhh = new RRHH();
       AC acc = new AC();

       public Departamento() 
       {
       }


       private DateTime obtenerFecha(String strig)
       {
           String[] vector = strig.Split('/');

           DateTime fecha = new DateTime(int.Parse(vector[2]),int.Parse(vector[1]),int.Parse(vector[0]));

           System.Console.WriteLine(fecha);

           //foreach (string palabra in vector)
           //{
           //    Console.WriteLine(palabra);
           // }
           return (fecha);     
       }

       private String obtenerNumeroString(int num)
       {
           if (num >= 0 && num <= 9)
           {
               return ("000" + String.Concat(num));
           }
           else
               if (num >= 10 && num <= 99)
               {
                   return ("00" + String.Concat(num));
               }
               else
                   if (num >= 100 && num <= 999)
                   {
                       return ("0" + String.Concat(num));
                   }
                   else
                       return (String.Concat(num));
       }

       //<summary>
       //Genera la respuesta SI|NO para el cliente.
       //</summary>
       private String generarCodigo1(String area, String solicitud)
       {
           if (solicitud == "")
               respuesta = area + "0000";
           else
               respuesta = area + "1000" + "|" + solicitud + "|";

           Console.WriteLine("Respuesta del servidor: " + respuesta);
           
           return respuesta;
       }

       private String generarCodigoDepartamento(String res)
       {
           switch (res)
           {
               case "ADI":
                   return res + "0000";
                   break;
               case "GP ":
                   return res + "0000";
                   break;
               case "RRH":
                   return res + "0000";
                   break;
               default:
                   return "N/A1000|" + res+"|";

           }
           
           respuesta = res + "0000";
           System.Console.WriteLine(respuesta);
           return (respuesta);
       }

       //<summary>
       //Genera la respuesta del Empleado
       //</summary>
       private String generarCodigoProyecto(String area, Proyecto proyecto )
       {

           if (proyecto == null)
               respuesta = area + "1000";
           else
           {
               respuesta = area + "0005|"+proyecto.Codigo+"|"+proyecto.Nombre+"|"+proyecto.FechaInicio+"|"+proyecto.FechaInicio
                   +"|"+proyecto.Presupuesto+"|";
               
           }
           System.Console.WriteLine(respuesta);
           return (respuesta);
       }

       //<summary>
       //Genera la respuesta del Empleado
       //</summary>
       private String generarCodigoEmpleado(String area, Empleado empleado)
       {

           if (empleado == null)
               respuesta = area + "1000";
           else
           {
               respuesta = area + "0007|"+empleado.Nombre+"|"+empleado.Apellido+"|"+empleado.FechaIngreso+"|"+empleado.Cargo
                   +"|"+empleado.CI1+"|"+empleado.Costo+"|"+empleado.FechaNac+"|";

           }
           System.Console.WriteLine(respuesta);
           return (respuesta);
       }

       //<summary>
       //Genera la respuesta del ACTIVO
       //</summary>
       private String generarCodigoActivo(String area, Activo activo)
       {

           if (activo == null)
               respuesta = area + "1000";
           else
               respuesta = area + "0004|"+activo.Codigo+"|"+activo.Nombre+"|"+activo.Cantidad+"|"+activo.Precio+"|";
           
           System.Console.WriteLine(respuesta);
           return (respuesta);
       }




       private String generarCodigoTodoProyecto(String area, List<Proyecto> listaProyecto)
       {
           int cont = 0;
           String cadena = "";
           foreach (Proyecto proyecto in listaProyecto)
           {
               cadena = cadena + "|" + proyecto.Codigo+"_"+proyecto.Nombre+"_"+proyecto.FechaInicio+"_"+proyecto.FechaInicio
                   + "_" + proyecto.Presupuesto;
               cont++;
           }
           cont = (cont * 5);
           cadena = cadena + "|";

           respuesta = area + obtenerNumeroString(cont) + cadena;

           System.Console.WriteLine(respuesta);

           return respuesta;
       }



       private String generarCodigoTodoEmpleado(String area, List<Empleado> listaEmpleado)
       {
           int cont = 0;
           String cadena = "";
           foreach (Empleado empleado in listaEmpleado)
           {
               cadena = cadena + "|" + empleado.Nombre + "_" + empleado.Apellido + "_" + empleado.FechaIngreso + "_" + empleado.Cargo
                   + "_" + empleado.CI1 + "_" + empleado.Costo + "_" + empleado.FechaNac;
               cont++;
           }
           cont = (cont * 7);
           cadena = cadena + "|";
           respuesta = area + obtenerNumeroString(cont) + cadena;

           System.Console.WriteLine(respuesta);

           return respuesta;
       }


       private String generarCodigoTodoActivo(String area, List<Activo> listaInventario)
       {
           int cont = 0;
           String cadena = "";
           foreach(Activo activo in listaInventario)
           {
               cadena = cadena+ "|" + activo.Codigo + "_" + activo.Nombre + "_" + activo.Cantidad + "_" + activo.Precio;
               cont++;
           }
           cont = (cont*4);
           cadena = cadena + "|";
           respuesta = area + obtenerNumeroString(cont) + cadena;

           System.Console.WriteLine(respuesta);
           
           return respuesta;
       }

       private String hacerLlamados(String area, String Accion, String [] resto) 
       {
    
           switch (area)
           {
               case "GP ": System.Console.WriteLine("Gerencia Proyecto");
       
                   
                        switch (Accion)
                           {
                               case "M": System.Console.WriteLine("MODIFICAR");
                                  
                                   return generarCodigo1(area, gp.modificarProyecto(resto));

                               case "I": System.Console.WriteLine("CREAR");
                                 
                                   return generarCodigo1(area, gp.insertarProyecto(resto[1],resto[2],obtenerFecha(resto[3]),obtenerFecha(resto[4]),
                                      float.Parse(resto[5])));

                               case "E": System.Console.WriteLine("ELIMINAR");
                                     
                                   return   generarCodigo1(area,gp.eliminarProyecto(resto[1]));

                               case "C": System.Console.WriteLine("CONSULTAR");
                                   
                                   return generarCodigoProyecto(area, gp.obtenerProyecto(resto[1]));  
 
                               case "T": System.Console.WriteLine("CONSULTAR TODO");

                                    return generarCodigoTodoProyecto(area, gp.ListaProyecto);

                               case "A": System.Console.WriteLine("CREANDO UN USUARIO ");

                                    return generarCodigo1(area, acc.insertarUsuario(resto[1], resto[2], area));
                                  

                               default: System.Console.WriteLine("ERROR Accion no Valida");
                                   return "Error";
                           }
                   break;

           
                   
               case "RRH": System.Console.WriteLine("es de Recursos HUMANOS");
                  
               
                           switch (Accion)
                               {
                                   case "M": System.Console.WriteLine("MODIFICAR");
                                      
                                       return  generarCodigo1(area,rrhh.modificarEmpleado(resto));   
                                   case "I": System.Console.WriteLine("CREAR");
                                       
                                       return  generarCodigo1(area,rrhh.insertarEmpleado(resto[1],resto[2],obtenerFecha(resto[3]),resto[4],
                                        long.Parse(resto[5]),float.Parse(resto[6]),obtenerFecha(resto[7])));

                                   case "E": System.Console.WriteLine("ELIMINAR");
                                      return  generarCodigo1(area,rrhh.eliminarEmpleado(long.Parse(resto[1])));

                                   case "C": System.Console.WriteLine("CONSULTAR");
                                      
                                       return generarCodigoEmpleado(area,rrhh.obtenerEmpleado(int.Parse (resto[1])) );  
                        
                                   case "T": System.Console.WriteLine("CONSULTAR TODO"); 
                                     
                                       return generarCodigoTodoEmpleado(area, rrhh.ListaEmpleado);

                                   case "A": System.Console.WriteLine("CREANDO UN USUARIO ");
                                        
                                       return generarCodigo1(area, acc.insertarUsuario(resto[1], resto[2], area));

                                   default: System.Console.WriteLine("ERROR Accion no Valida");
                                       return "Error";
                               }
                   
                   break;


               case "ADI": System.Console.WriteLine("es de ADI");
                          
                           switch (Accion)
                           {
                               case "M": System.Console.WriteLine("MODIFICAR");
                                  
                                   return generarCodigo1(area, adi.modificarActivo(resto));

                               case "I": System.Console.WriteLine("CREAR");
                                   
                                  return generarCodigo1(area,adi.insertarActivo(resto[1],resto[2],int.Parse(resto[3]),float.Parse(resto[4])));

                               case "E": System.Console.WriteLine("ELIMINAR");
                                    
                                   return generarCodigo1(area,adi.eliminarActivo(resto[1]));

                               case "C": System.Console.WriteLine("CONSULTAR");
                                 
                                   return generarCodigoActivo(area,adi.obtenerActivo(resto[1]));

                               case "T": System.Console.WriteLine("CONSULTAR TODO");
                                  
                                   return generarCodigoTodoActivo(area, adi.ListaInventario);

                               case "A": System.Console.WriteLine("CREANDO UN USUARIO ");

                                   return generarCodigo1(area, acc.insertarUsuario(resto[1], resto[2], area));

                               default: System.Console.WriteLine("ERROR Accion no Valida");
                                   return "Error";
                           }

                   break;
               case "AC ": System.Console.WriteLine("ESTA ACCEDIENDO");

                   switch(Accion)
                   {

                       case "C": System.Console.WriteLine("ENTRO A ACCEDER");
                           //return generarCodigo1("N/A",acc.obtenerDepartamentoUsuario(resto[1], resto[2]));     
                           System.Console.WriteLine(generarCodigoDepartamento( acc.obtenerDepartamentoUsuario(resto[1], resto[2])));
                           return generarCodigoDepartamento( acc.obtenerDepartamentoUsuario(resto[1], resto[2]));

                       case "E": System.Console.WriteLine("ENTRO A ELIMINAR");
                          return generarCodigo1(area, acc.eliminarUsuario(resto[1], resto[2]));
                   
                   default: System.Console.WriteLine("Error no se encontro el Departamento");
                   return ("Error");
                }


           }
           return ("Error");  

       }
       
       
       
       
       public String newPeticion(String peticion)
       {
           String area;
           String Accion;
           String resto;
           int numCampos;

           

           area = peticion.Substring(0, 3);
           Accion = peticion.Substring(3, 1);
           numCampos = int.Parse(peticion.Substring(4, 4));



           resto = peticion.Substring(8, (peticion.Length - 8));

           String[] vector = resto.Split('|');



               return (hacerLlamados(area, Accion, vector));

       }


    }
}
