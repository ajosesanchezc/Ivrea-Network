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
    public partial class RRHH : claseBase1
    {
        /*//////////////VARIABLES GLOBALES/////////////*/
        DataTable workTable2;//Tabla para observar los resultados.
        string mensaje = "";
        string respuesta = "";
        string cedula = "";
        int contador;
        bool flag = true;
        Cliente cliente;
        


        /*///////////////CONSTRUCTOR//////////////////*/
        public RRHH()
        {
            InitializeComponent();
            workTable2 = new DataTable();
            workTable2 = agregarColumnas(workTable2, rrhh);
            workTable2.Rows.Clear();
            tabla.DataSource = workTable2;
            desactivarCampos();
            desactivarCheks();
            cliente = new Cliente();
            
        }

        /*///////////////////////////////////CAMPOS//////////////////////////////////*/
        //En esta seccion se encuentra todos los metodos que manipulas los elementos
        // de tipo Boton y los elementos tipo checkBox.

        private void activarCampos()
        //Establece los campos de registros accesibles.Utilizados para validar los campos.
        {

            eNombre.Enabled = true;
            eApellido.Enabled = true;
            eCargo.Enabled = true;
            eCosto.Enabled = true;
            eCedula.Enabled = true;
            fecha1.Enabled = true;
            fecha2.Enabled = true;
        }

        private void desactivarCampos()
        //Desactiva todos los campos para ingresar datos.
        {
            eNombre.Enabled = false;
            eApellido.Enabled = false;
            eCargo.Enabled = false;
            eCosto.Enabled = false;
            eCedula.Enabled = false;
            fecha1.Enabled = false;
            fecha2.Enabled = false;
        }

        private void borrarCampos()
        //Coloca los campos para registrar en blanco.
        {
            eBuscador1.Text = "";
            eNombre.Text = "";
            eCargo.Text = "";
            eCosto.Text = "";
            eCedula.Text = "";
            eApellido.Text = "";
        }

        private void devolverColor()
        {
            e1.ForeColor = System.Drawing.Color.Black;
            e2.ForeColor = System.Drawing.Color.Black;
            e3.ForeColor = System.Drawing.Color.Black;
            e4.ForeColor = System.Drawing.Color.Black;
            e5.ForeColor = System.Drawing.Color.Black;
            e6.ForeColor = System.Drawing.Color.Black;
            e7.ForeColor = System.Drawing.Color.Black;
        }

        private void activarCheks()
        {
            check1.Enabled = true;
            check1.Checked = false;
            check2.Enabled = true;
            check2.Checked = false;
            check3.Enabled = true;
            check3.Checked = false;
            check4.Enabled = true;
            check4.Checked = false;
            check5.Enabled = true;
            check5.Checked = false;
            check6.Enabled = true;
            check6.Checked = false;
            check7.Enabled = true;
            check7.Checked = false;
            desactivarCampos();
        }

        private void desactivarCheks()
        {
            check1.Enabled = false;
            check2.Enabled = false;
            check3.Enabled = false;
            check4.Enabled = false;
            check5.Enabled = false;
            check6.Enabled = false;
            check7.Enabled = false;
        }

        private void cambiarColor(Label etiqueta)
        {
            etiqueta.ForeColor = System.Drawing.Color.Red;
        }

        private void mensajeDeError(string mensaje)
        //Muestra por pantalla al usuario, un mensaje de cualquier tipo.
        {
            eError.Text = mensaje;
            eError.Visible = true;
        }


        private void configuracionInicial()
        {
            Opciones.Text="Consultar";
            borrarCampos();
            devolverColor();
            desactivarCheks();
            eDepartamento.Text="Recursos Humanos";
        }

        private DataTable recursosHumanos(DataTable tabla)
        //Establece todas las condiciones graficas cuando el usuario
        //Selecione el departamento RRHH.
        {
            eBuscador0.Text = "Cedula";
            Opciones.Text = "Consultar";
            Opciones.Items.AddRange(others);
            Opciones.Enabled = true;
            tabla=establecerColumnas(workTable2, rrhh);
            return (tabla);
        }

        private DataTable gestionProyectos(DataTable tabla)
        //Establece todas las condiciones graficas cuando el usuario
        //Selecione el departamento gestion de proyectos.
        {
            eBuscador0.Text = "Codigo";
            Opciones.Text = "Consultar";
            Opciones.Enabled = false;
            borrarCampos();
            tabla= establecerColumnas(workTable2, gproyecto);
            return tabla;

        }

        private DataTable administracionInventarios(DataTable tabla)
        {
            eBuscador0.Text = "Codigo";
            borrarCampos();
            Opciones.Text = "Consultar";
            Opciones.Enabled = false;
            tabla = establecerColumnas(workTable2, adi);
            return tabla;
        }
        /*////////////////////////////////////////VALIDACIONES///////////////////////////////////////*/
        private bool validarCampos()
        {
            bool bandera = true;
            bandera = validacionCampos1();
            if (validacionCampos3(eNombre.Text) != 0) bandera = false;
            if (validacionCampos3(eApellido.Text) != 0) bandera = false;
            if (validacionCampos3(eCargo.Text) != 0) bandera = false;
            if (validacionCampos2(eCedula.Text) != 0) bandera = false;
            if (validacionCampos2(eCosto.Text) != 0) bandera = false;
            return bandera;
        }

        /*///////////////////////////////////////////////////////////////////////////////////*/
       //En esta seccion estan los metodos utilizados cuando el combobox de las opciones
       //(Consultar,eliminar,Registrar,etc) es cambiado por el usuario.
        private void registrar()
        {
            activarCampos();
            desactivarCheks();
            eBuscador1.Enabled = false;
            check8.Enabled = false;
        }

        private void consultar()
        {
            check8.Enabled = true;
            eBuscador1.Enabled = true;
        }

        private void eliminar()
        {
            eBuscador1.Enabled = true;
            eBuscador1.Text = "";
            desactivarCampos();
            desactivarCheks();
            tabla.DataSource = eliminarFilas(workTable2);

        }

        private void modificar()
        {
            eBuscador1.Enabled = true;
            activarCheks();

        }

       /*//////////////////////////////////////EVENTOS Y ACCIONES//////////////////////////////////*/
        private void button1_Click(object sender, EventArgs e)
        //Evento del boton Aceptar, para realizar alguna accion segun la opcion seleccionada por el usuario.
        {
             eError.Visible = false;
             devolverColor();
             flag = true;
             if (eDepartamento.Text.Equals("Recursos Humanos") == true)
             {
                 switch (Opciones.Text)
                 {
                     case ("Registrar"):
                         
                             mensaje = registrarMensaje();
                             if (validacionCampos1() == true)
                             {
                                 Console.WriteLine("entra al ciclo");
                                 respuesta = cliente.enviar(mensaje);
                                 if (detectorError(respuesta) == 0)
                                 {
                                     mensajeDeError("Datos registrados con exitos");
                                 }
                                 else
                                 {
                                     mensajeDeError(desfragmentar(respuesta)[1]);
                                 }
                             }
                             else
                             {
                                 mensajeDeError("Verificar datos ingresados");
                             }
                         
                         
                         break;
                     case ("Modificar"):
                         if (eBuscador1.Text.Equals("") == false)
                         {
                             mensaje = modificarMensaje(mensaje);
                             if (flag == true)
                             {
                                 respuesta = cliente.enviar(mensaje);
                                 if (mensaje.Equals("") == false)
                                 {
                                     if (detectorError(respuesta) == 0)
                                     {
                                         mensajeDeError("Ha sido modificado con exito");
                                         tabla.DataSource = eliminarFilas(workTable2);
                                         mensaje = "";
                                         respuesta = "";
                                     }
                                     else
                                     {
                                         mensajeDeError(desfragmentar(respuesta)[1]);
                                     }
                                 }
                             }
                             else
                             {
                                 mensajeDeError("Modificacion sin exitos.Intente de nuevo");
                             }
                         }
                         else
                         {
                             mensajeDeError("Campo de cedula vacio.Ingrese de nuevo la cedula a consultar");
                         }
                         break;
                     case ("Consultar"):
                         if (check8.Checked == false)
                         {
                             if (validacionCampos2(eBuscador1.Text) == 0)
                             {
                                 mensaje = mensajeProtocolo("RRHC", eBuscador1.Text);
                                 respuesta = cliente.enviar(mensaje);
                                 if (detectorError(respuesta) == 0)
                                 {
                                     cedula = eBuscador1.Text;
                                     workTable2 = agregarFila(workTable2, consultarMensaje1(respuesta));
                                     tabla.DataSource = workTable2;
                                 }
                                 else
                                 {
                                     mensaje = "";
                                     mensajeDeError("Error en la operacion.Intente de Nuevo");
                                 }
                             }
                             else
                             {
                                 mensaje = "";
                                 mensajeDeError("Error en los datos suministraods.");
                             }

                         }
                         else
                         {
                             mensaje = "RRHT0000";
                             respuesta = cliente.enviar(mensaje);
                             if (detectorError(respuesta) == 0)
                             {
                                 string[] auxiliar = consultarMensaje1(respuesta);
                                 agregarFilas(workTable2, auxiliar);
                             }
                             else
                             {
                                 mensajeDeError("No se pudo completar la operacion");
                             }
                         }

                         break;
                     case ("Eliminar"):
                         if (validacionCampos2(eBuscador1.Text) == 0)
                         {
                             mensaje = "RRHE0001|" + eBuscador1.Text + "|";
                             respuesta = cliente.enviar(mensaje);
                             if (detectorError(respuesta) == 0)
                             {
                                 mensajeDeError("Datos Eliminados con exitos");
                                 tabla.DataSource = eliminarFilas(workTable2);
                             }
                             else
                             {
                                 mensajeDeError("No se pudo eliminar;Intente de nuevo.");
                             }

                         }
                         else
                         {
                             mensajeDeError("Error en los datos ingresados");
                         }

                         break;
                 }
             }
             else
             {
                 switch (eDepartamento.Text)
                {
                    case ("Administracion de Inventarios"):
                        if (check8.Checked == false)
                        {
                            mensaje = "ADIC0001|" + eBuscador1.Text + "|";
                        }
                        else mensaje = "ADIT0000|";
                        break;
                    case ("Gestion de Proyectos"):
                        if (check8.Checked == false) mensaje = "GP C0001|" + eBuscador1.Text + "|";
                        else mensaje = "GP T0000";
                        break;
                }
                         if (check8.Checked == false)
                         {
                             if (eBuscador1.Text.Equals("") == false)
                             {
                                 respuesta = cliente.enviar(mensaje);
                                 if (detectorError(respuesta) == 0)
                                 {
                                     tabla.DataSource = agregarFila(workTable2, consultarMensaje1(respuesta));
                                 }
                                 else mensajeDeError("Consulta sin exitos.");
                             }
                         }
                         else
                         {
                             respuesta = cliente.enviar(mensaje);
                             tabla.DataSource = agregarFilas(workTable2, consultarMensaje1(respuesta));
                         }
                     
                     

                
            }
         mensaje = "";
         respuesta = "";
         borrarCampos();  
        }//Fin_Evento.

        private void departamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*campoTipo.Text = eTipoConsulta.Text;*/
        }

        private void eTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ventana4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void tabla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabla2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void dia2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tiempo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void eDepartamento1_SelectedItemChanged(object sender, EventArgs e)
        //Evento perteneciente al combobox de los departamentos.
        {
            if (eDepartamento.Text.Equals("Recursos Humanos") == true)
            {
               tabla.DataSource=recursosHumanos(workTable2);
            }
            if (eDepartamento.Text.Equals("Gestion de Proyectos") == true)
            {
                tabla.DataSource=gestionProyectos(workTable2);
            }
            if (eDepartamento.Text.Equals("Administracion de Inventarios") == true)
            {
                tabla.DataSource = administracionInventarios(workTable2);
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        //Evento del boton de Opciones (Consultar,Eliminar,Modificar,Registrar)
        {
            borrarCampos();
            devolverColor();
            desactivarCheks();
            switch (Opciones.Text)
            {
                case ("Registrar"):
                    registrar();
                    break;
                case ("Modificar"):
                    modificar();
                    break;
                case ("Consultar"):
                    consultar();
                    break;
                case ("Eliminar"):
                    eliminar();
                    break;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fecha1_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void eCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check6.Checked == true)
            {
                fecha1.Enabled = true;
            }
            else
            {
                fecha1.Enabled = false;
            }
        }

        private void fecha2_ValueChanged(object sender, EventArgs e)
        {
        }

       /*//////////////////////////////////////VALIDACIONES////////////////////////////////////////*/
        private Boolean validacionCampos1()
        //Verifica que los campos no esten vacion cuando el usuario decida registrar datos.
        {
            Boolean bandera = true;
            if (eNombre.Text.Equals("") == true)
            {
                bandera = false;
                cambiarColor(e1);
            }
            if (eApellido.Text.Equals("") == true)
            {
                bandera = false;
                cambiarColor(e2);
            }
            if (eCosto.Text.Equals("") == true)
            {
                bandera = false;
                cambiarColor(e3);
            }
            if (eCedula.Text.Equals("")==true) 
            {
                bandera = false;
                cambiarColor(e4);

            }
            //falta validad que las fechas sean las correctas.
            return bandera;
        }


     /*///////////////////////////////////////////////MENSAJES///////////////////////////////////*/


     private string registrarMensaje()
        //Construye el mensaje de la opcion registro del departamento de recursos humanos.
     {
         string departamento;
         departamento = "RRH" + "I" + "0007" + "|" + eNombre.Text + "|" + eApellido.Text + "|" + convertirFecha(fecha2) + "|" + eCargo.Text + "|" + eCedula.Text + "|" + eCosto.Text + "|" + convertirFecha(fecha1) + "|";
         return departamento;

     }

     private string modificarMensaje(string mensaje)
     //Construye el mensaje con los datos modificado por el usuario.
     {
         string auxiliar = "RRHM";
         int bandera = 0;
         flag = true;
         if (eNombre.Enabled == true)
         {
             if (validacionCampos3(eNombre.Text) == 0)
             {
                 contador++;
                 mensaje = mensaje + "nombre" + "|" + eNombre.Text + "|";
             }
             else
             {
                 bandera = 1; cambiarColor(e1);
                 flag = false ;
             }
         }
         if (eApellido.Enabled == true)
         {
             if (validacionCampos3(eApellido.Text) == 0)
             {
                 contador++;
                 mensaje = mensaje + "apellido" + "|" + eApellido.Text + "|";
        
             }
             else
             {
                 bandera = 1; cambiarColor(e2);
                 flag = false;
             }
         }
         if (eCedula.Enabled == true)
         {
             if (validacionCampos2(eCedula.Text) == 0)
             {
                 contador++;
                 mensaje = mensaje + "cedula" + "|" + eCedula.Text + "|";
             }
             else
             {
                 bandera = 1; cambiarColor(e4);
                 flag = false;
             }
         }
         if (eCargo.Enabled == true)
         {
             if (validacionCampos3(eCargo.Text) == 0)
             {
                 contador++;
                 mensaje = mensaje + "cargo" + "|" + eCargo.Text + "|";
             }
             else
             {
                 bandera = 1; cambiarColor(e5);
                 flag = false;
             }
         }

         if (eCosto.Enabled == true)
         {
             if (validacionCampos2(eCosto.Text) == 0)
             {
                 contador++;
                 mensaje = mensaje + "costo" + "|" + eCosto.Text +"|";
             }
             else
             {
                 bandera = 1; cambiarColor(e3);
                 flag = false;
             }
         }
         if (fecha1.Enabled == true)
         {
             ++contador;
             mensaje = mensaje+"fechaNacimiento" + "|" + convertirFecha(fecha1)+"|";
         }
         else
         {
             
         }
         if (fecha2.Enabled == true)
         {
             ++contador;
             mensaje = mensaje+"fechaIngreso" + "|" + convertirFecha(fecha2) + "|"; ;
         }
         else
         {
            
         }
         if ((mensaje.Equals("") == false)&&(flag==true))
         {
             contador = contador * 2+1;
             auxiliar= auxiliar + "000" + Convert.ToString(contador) + "|" +eBuscador1.Text+"|"+ mensaje;
             mensaje = auxiliar;
         }
         if (flag==false)
         {
             mensajeDeError("Error; Verificar Campos");
             
         }
         if (mensaje.Equals("") == true)
         {
             flag = false;
         }
         else
         {
             eError.Visible = false;
             devolverColor();
         }
        
         contador = 0;
         return mensaje;
     }


     private string[] consultarMensaje2(string mensaje)
     //Elimina el primer campo de la respuesta recibida por el servido al consultar
     {
         string[] aux = desfragmentar(mensaje);
         string[] aux2 = new string[aux.Length - 1];
         int i = 0;
         for (i = 1; i < aux.Length; ++i)
         {
             aux2[i - 1] = aux[i];
         }
         return aux2;
     }
     private void check1_CheckedChanged(object sender, EventArgs e)
     {
         if (check1.Checked == true)
         {
             eNombre.Enabled = true;
         }
         else
         {
             eNombre.Enabled = false;
             eNombre.Text = "";
         }
     }

     private void check2_CheckedChanged(object sender, EventArgs e)
     {
         if (check2.Checked == true)
         {
             eApellido.Enabled = true;
         }
         else
         {
             eApellido.Enabled = false;
             eApellido.Text = "";
         }
     }

     private void check3_CheckedChanged(object sender, EventArgs e)
     {
         if (check3.Checked == true)
         {
             eCedula.Enabled = true;
         }
         else
         {
             eCedula.Enabled = false;
             eCedula.Text = "";
         }
     }

     private void check5_CheckedChanged(object sender, EventArgs e)
     {
         if (check5.Checked == true)
         {
             eCargo.Enabled = true;
         }
         else
         {
             eCargo.Enabled = false;
             eCargo.Text = "";
         }
     }

     private void check7_CheckedChanged(object sender, EventArgs e)
     {
         if (check7.Checked == true)
         {
             fecha2.Enabled = true;
         }
         else
         {
             fecha2.Enabled = false;
         }
     }

     private void check4_CheckedChanged(object sender, EventArgs e)
     {
         if (check4.Checked == true)
         {
             eCosto.Enabled = true;
         }
         else
         {
             eCosto.Enabled = false;
             eCosto.Text = "";
         }
     }

     private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
     {

     }

        private void button2_Click(object sender, EventArgs e)
        {
            PRINCIPAL principal = new PRINCIPAL();
            principal.Visible = true;
            this.Visible = false;
        }

        private void toolStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void check8_CheckedChanged(object sender, EventArgs e)
        {
            if (check8.Checked == false)
            {
                eBuscador1.Enabled = true;

            }
            else
            {
                eBuscador1.Enabled = false;
            }
        }
       
    }
}
