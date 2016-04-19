using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplication3
{
    public class claseBase1:Form
    //Implementa  los metodos comunes entre las ventanas de los departamentos.
    {

        protected String[] filas = {""};
        protected String[] consultar = { "Consultar" };
        protected String[] others = { "Consultar", "Registrar", "Elminar", "Modificar" };
        protected String[] adi = { "codigo","nombre","cantidad","costo",""};
        protected String[] rrhh = { "nombre", "apellido", "fechaIngreso", "cargo", "cedula", "costo", "fechaNacimiento",""};
        protected String[] gproyecto = { "codigo","nombre","fechaInicio","fechaFin","presupuesto",""};
        protected String[] areas={"Administracion de Inventarios","Gestion de Proyectos","Recursos Humanos"};
        protected String rHumanos = "RRH";
        protected String gProyectos ="GP_";
        protected String aInventarios = "ADI";


    /*/////////////////////////////////////METODOS DATA TABLE Y DATAGRIDVIEW/////////////////*/
       protected DataTable agregarFilas(DataTable workTable, string[] mensaje)
        //Agregar todos los datos de la base de datos de X departamento al datagridview.
        {
            int i = 0;
            workTable.Rows.Clear();
            for (i = 0; i <mensaje.Length; ++i)
            {
                string[] filas = desfragmentar2(mensaje[i]);
                workTable.Rows.Add(filas);
            }//Fin_For
            return workTable;
        }

        protected  DataTable agregarColumnas(DataTable workTable, String[] listaNombres)
        //Agrega N catidad de columnas a DataTable.
        {
            int i = 0;
            workTable.Columns.Clear();
            for (i = 0; i < listaNombres.Length; ++i)
            {
                workTable.Columns.Add(listaNombres[i], typeof(String));
            }
            return workTable;
        }

        protected DataTable agregarFila(DataTable tabla,string[] fila)
        //Agrega una fila con informacion al DataTable
        {
            tabla.Rows.Clear();
            tabla.Rows.Add(fila);
            return tabla;
        }

        protected DataTable eliminarFilas(DataTable tabla)
        //Elimina todas las filas de un datatable.
        {
            int i = 0;
            tabla.Rows.Clear();
            return tabla;
        }

        protected string[] consultarMensaje1(string mensaje)
        {
            char[] separador = { '|' };
            string[] aux1 = desfragmentar(mensaje);
            string[] aux2 = new string[aux1.Length - 1];
            int i = 0;
            for (i = 1; i < aux1.Length; ++i)
            {
                aux2[i - 1] = aux1[i];
            }
            return aux2;
        }

        protected DataTable establecerColumnas(DataTable tabla,string[] columnas)
        {
            tabla.Columns.Clear();
            tabla = agregarColumnas(tabla, columnas);
            return tabla;
        }

        protected int detectorError(string mensaje)
        //Detecta si la operacion del usuario tuvo exitos o no.
        {
       
            if (mensaje[3].Equals('1') == true)
            {
                return 1;
            }
            return 0;
        }
        /*////////////////////////////////////EVENTOS////////////////////////////////////////*/
        private void claseBase1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // claseBase1
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "claseBase1";
            this.Load += new System.EventHandler(this.claseBase1_Load);
            this.ResumeLayout(false);

        }
        /*////////////////////////////////////MENSAJES///////////////////////////////////////*/
        protected string[] desfragmentar(string mensaje)
        //Divie el mensaje enviado por el servidor y lo coloca en el datagridview.
        {
            char[] signo = { '|' };
            string[] datos = mensaje.Split(signo);
            return datos;

        }

        protected string convertirFecha(DateTimePicker fecha)
        //Convierte la fecha de los campos a tipo string.
        {
            Console.WriteLine("ANTES"+fecha);
            char[] separador = { ' ' };
            string[] aux1 = fecha.Value.ToString().Split(separador);
            separador[0] = '/';
            string[] aux2 = aux1[0].Split(separador);
            string date = aux2[0] + "/" + aux2[1] + "/" + aux2[2];
            Console.WriteLine("DESPUES" + date);
            return date;
        }

       protected string mensajeProtocolo(string departamento,string busqueda)
       //metodo para concadenar y construir el mensaje de cualquier departamento.;
       {
           string sms=departamento+"0001"+"|"+busqueda+"|";
           Console.WriteLine(sms);
           return sms;
       }


       protected string[] desfragmentar2(string mensaje)
       {
           char[] separador = {'_'};
           string[] datos =mensaje.Split(separador);
           return datos;
       }
      /*//////////////////////////////////////VALIDACIONES/////////////////////////////////////*/
    
         protected int validacionCampos2(string campo1)
         //Valida el tipo de dato introducido por el usuario.
         {
             int bandera = 0;
           try
           {
               int aux1=0;
               if (campo1.Equals("") == false) { aux1 = Convert.ToInt32(campo1); }
               else 
                   return -1 ;
           }
           catch (System.FormatException erro2)
           {
               bandera =1;
           }
           catch (System.Exception error3)
           {
               bandera = 1;
               Console.WriteLine("Error tipo 3");
           }
           return bandera;
         }


       protected int validacionCampos3(string campo)
       //Valida que el usuario no halla introducido ningun numero en el campo.
       {
           int i = 0;
           int bandera = 0;
           if (campo.Equals("") == false)
           {
               for (i = 0; i < 10; ++i)
               {
                   if (campo.Contains(Convert.ToString(i)) == true) { bandera = 1; break;}
               }
           }
           else
           {
               bandera=-1;
           }
           return bandera; ;
       }

        protected DataTable datosTabla(string[] datos, DataTable tabla)
        {
            tabla.Rows.Add(datos);
            return tabla;
        }

    }
}
