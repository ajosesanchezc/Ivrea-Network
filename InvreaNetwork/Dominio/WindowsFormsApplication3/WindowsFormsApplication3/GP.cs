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
    public partial class GP : claseBase1
    {
        /*///////////////////////VARIABLES GLOBALES//////////////////////////*/
        DataTable workTable2;//Tabla2
        string mensaje = "";
        string respuesta = "";
        string codigo = "";
        string fechaAuxiliar = "";
        int contador;
        int flag = 0;
        Cliente cliente;
 
        /*///////////////////////////////////CONSTRUCTOR/////////////////////////////////*/
        public GP()
        {
            InitializeComponent();
            desactivarCampos();
            desactivarCheks();
            workTable2 = new DataTable();
            workTable2 = agregarColumnas(workTable2, gproyecto);
            tabla2.DataSource = workTable2;
            cliente=new Cliente();
            
        }
       /*////////////////////////////////////MENSAJES////////////////////////////////////*/

        private string registrarMensaje()
        //Construye el mensaje de la opcion registro del departamento de recursos humanos.
        {
            string departamento;
            departamento = "GP " + "I" + "0005" + "|" + eCodigo.Text + "|" + eNombre.Text + "|" + convertirFecha(fecha1) + "|" + convertirFecha(fecha2) + "|" + ePresupuesto.Text + "|";
            return departamento;
        }

        private string modificarMensaje(string mensaje)
        //Construye el mensaje modificado por el usuario.
        {
            int bandera = 0;
            contador = 0;
            string auxiliar = "GP M";
            if (eNombre.Enabled == true)
            {
                if (validacionCampos3(eNombre.Text) == 0)
                {
                    contador++;
                    mensaje = mensaje + "nombre" + "|" + eNombre.Text + "|";
                }
                else
                {
                    flag = 1;
                    cambiarColor(e2); bandera = 1;
                }
            }
            if (ePresupuesto.Enabled == true)
            {
                if (validacionCampos2(ePresupuesto.Text) == 0)
                {
                    contador++;
                    mensaje = mensaje + "presupuesto" + "|" + ePresupuesto.Text + "|";
                }
                else
                {
                    flag = 1;
                     cambiarColor(e3); bandera = 1;
                }
            }
            if (eCodigo.Enabled == true)
            {
                if (validacionCampos2(eCodigo.Text) == 0)
                {
                    contador++;
                    mensaje = mensaje + "codigo" + "|" + eCodigo.Text + "|";
                }
                else
                {
                    flag = 1;
                     cambiarColor(e1); bandera = 1;
                }
            }
            if (fecha1.Enabled == true)
            {
                ++contador;
                mensaje = mensaje  + "fechaInicio" + "|" + convertirFecha(fecha1)+"|";
            }
            if (fecha2.Enabled == true)
            {
                ++contador;
                mensaje = mensaje + "fechaFin" + "|" + convertirFecha(fecha2) + "|";
            }

            if ((mensaje.Equals("") == false)&&(flag==0))
            {
                contador = contador * 2+1;
                string aux="";
                if (contador < 10) aux = "000";
                else aux = "00";
                mensaje =auxiliar+aux + Convert.ToString(contador) + "|"+eBuscador.Text+"|"+mensaje;
            }
            if (mensaje.Equals("") == true)
            {
                flag = 1;
            }
            if (bandera==1)
            {
                mostrarError("Verificar Datos;");
                mensajeError.Visible = true;
            }
            Console.Write("El mensaje es:");
            Console.WriteLine(mensaje);
            return mensaje; ;
        }


       /*////////////////////////////////////CAMPOS//////////////////////////////////////*/

        private void borrarCampos()
        //Inicializa todos los campos.
        {
            eNombre.Text = "";
            ePresupuesto.Text = "";
            eCodigo.Text = "";
            eBuscador.Text = "";
 
        }

        private void reiniciarVariables()
        {
            eBuscador.Text = "";
            mensaje = "";
            respuesta = "";
        }

        private void desactivarCampos()
        {
          
            fecha1.Enabled = false;
            fecha2.Enabled = false;
            eNombre.Enabled = false;
            eCodigo.Enabled = false;
            ePresupuesto.Enabled = false;
        }

        private void activarCampos()
        {
          
            fecha1.Enabled = true;
            fecha2.Enabled = true;
            eNombre.Enabled = true;
            eCodigo.Enabled = true;
            ePresupuesto.Enabled = true;
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
            checkBox1.Enabled = true;
            checkBox1.Checked = false;
            borrarCampos();
        }

        private void desactivarCheks()
        {
            check1.Enabled = false;
            check1.Checked = false;
            check2.Enabled = false;
            check2.Checked = false;
            check3.Enabled = false;
            check3.Checked = false;
            check4.Enabled = false;
            check4.Checked = false;
            check4.Checked = false;
            checkBox1.Enabled = false;
            checkBox1.Checked = false;
        }

        private void cambiarColor(Label etiqueta)
        {
            etiqueta.ForeColor = System.Drawing.Color.Red;
        }

        private void devolverColor()
        {
            e1.ForeColor = System.Drawing.Color.Black;
            e2.ForeColor = System.Drawing.Color.Black;
            e3.ForeColor = System.Drawing.Color.Black;
            e4.ForeColor = System.Drawing.Color.Black;
            e5.ForeColor = System.Drawing.Color.Black;
        }

        private void configuracionInicial()
        {
            devolverColor();
            Opciones.Text = "Consultar";
            desactivarCampos();
            desactivarCheks();
            eBuscador.Enabled = true;
            mensajeError.Visible = false;
        }

        private void mensajeDeError(string mensaje)
        //Muestra por pantalla al usuario, un mensaje de error.
        {
            mensajeError.Visible = true;
            mensajeError.Text = mensaje;
        }

        private void borrarAviso()
        {
            mensajeError.Text = "";
            mensajeError.Visible = false;
        }

        /*///////////////////////////////////VALIDACIONES//////////////////////////////////*/

        private bool validarCampos()
        {
            bool bandera=true;
            if (validacionCampos3(eNombre.Text) != 0)
            {
                bandera = false;
                cambiarColor(e2);
            }
            if (validacionCampos2(eCodigo.Text) != 0)
            {
                bandera = false;
                cambiarColor(e1);
            }
            if (validacionCampos2(ePresupuesto.Text) != 0)
            {
                bandera = false;
                cambiarColor(e3);
            }
            if (bandera == true) devolverColor();
            return bandera;
        }

        private void mostrarError(string mensaje)
        {
            mensajeError.Text = mensaje;
        }
        /*/////////////////////////////////////////////////////////////////////////////*/
        private void registrar()
        {
            if (validarCampos() == true)
            {
                mensaje = registrarMensaje();
                if (mensaje.Equals("") == false)
                {
                    respuesta = cliente.enviar(mensaje);
                    if (detectorError(respuesta) == 0)
                    {
                        mensajeDeError("Datos registrados sastifactoriamente");
                        borrarCampos();
                    }
                    else
                    {
                        mensajeDeError("No ha sido posible registrar los datos");
                    }
                }
            }
            else
            {
                mostrarError("Error en los campos;Verificar Datos.");
                mensajeError.Visible = true;
            }
        }

        private void modificar()
        {
            if (eBuscador.Equals("") == false)
            {
                mensaje = modificarMensaje(mensaje);
                if ((mensaje.Equals("") == false) && (flag == 0))
                {
                    respuesta = cliente.enviar(mensaje);
                    if (detectorError(respuesta) == 0)
                    {
                        mensajeDeError("Datos modificados sastifactoriamente");
                        tabla2.DataSource = eliminarFilas(workTable2);
                        configuracionInicial();
                        reiniciarVariables();
                    }
                    else
                    {
                        mensajeDeError(desfragmentar(respuesta)[1]);
                    }
                }
                if (flag == 1)
                {
                    mensajeDeError("Error en los campos seleccionados");
                }
            }
            else
            {
                mostrarError("Error;No hay informacion para modificar.");
                mensajeError.Visible = true;
            }
        }


        private void consultar()
        {
            mensaje = "GP C0001|" + eBuscador.Text + "|";
            respuesta = cliente.enviar(mensaje);
            if (detectorError(respuesta) == 0)
            {
                codigo = eBuscador.Text;
                workTable2 = agregarFila(workTable2, consultarMensaje1(respuesta));
                tabla2.DataSource = workTable2;
                mensajeDeError("Consulta Exitosa");
            }
            else
            {
                codigo = "";
                mensajeDeError("Error; No se pudo procesar la operacion de consulta");
            }

        }

        private void eliminar()
        {
            if (eBuscador.Text.Equals("") == false)
            {
                mensaje = "GP E0001|" + eBuscador.Text + "|";
                respuesta = cliente.enviar(mensaje);
                if (detectorError(mensaje) == 0)
                {
                    mensajeDeError("Datos Eliminados con exitos");
                }
                else
                {
                    mensajeDeError(desfragmentar(respuesta)[1]);
                }
            }
            else
            {
                mensajeDeError("Error; Campo de busqueda vacio");
            }
        }
        /*///////////////////////////////////EVENTOS///////////////////////////////////*/
        private void button1_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            mensaje = "";
            flag = 0;
            if (eDepartamento.Text.Equals("Gestion de Proyectos") == true)
            {
                if (check8.Checked == false)
                {
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
                else
                {
                    mensaje = "GP T0000";
                    respuesta=cliente.enviar(mensaje);
                    if (detectorError(respuesta) == 0)
                    {
                        mensajeDeError("Consulta Exitosa");
                        tabla2.DataSource = agregarFilas(workTable2, consultarMensaje1(respuesta));
                    }
                    else
                    {
                        mostrarError("No se pudo consultar todos los datos");
                    }
                }
            }
            else
            {
                switch (eDepartamento.Text)
                {
                    case ("Administracion de Inventarios"):
                        if (check8.Checked == false) mensaje = "ADIC0001|" + eBuscador.Text + "|";
                        else mensaje = "ADIT0000|";
                        break;
                    case ("Recursos Humanos"):
                        if (check8.Checked == false) mensaje = "RRHC0001|" + eBuscador.Text + "|";
                        else mensaje = "RRHT0000";
                        break;
                }
                        respuesta = cliente.enviar(mensaje);
                        if (detectorError(mensaje) == 0)
                        {
                            mensajeDeError("Consulta Exitosa");
                            Console.WriteLine(respuesta);
                            if (check8.Checked==false)tabla2.DataSource = agregarFila(workTable2, consultarMensaje1(respuesta));
                            else tabla2.DataSource=agregarFilas(workTable2,consultarMensaje1(respuesta));
                        }
                        else
                        {
                            mensajeDeError("Consulta sin Exitos");
                        }
                
            }
            mensaje = "";
            respuesta = "";
           
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            PRINCIPAL principal = new PRINCIPAL();
            principal.Visible = true;
            this.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private DataTable eliminarFilas(DataTable workTable, int cantidad)
        //Elimina N cantidad de filas de un DataTable.
        {
            int i = 0;
            for (i = 1; i <= cantidad; ++i)
            {
                workTable.Rows.RemoveAt(0);
            }//Fin_For
            return workTable;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabla2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //campoTipo.Text = eTipoConsulta.Text;
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void eDepartamento1_SelectedItemChanged(object sender, EventArgs e)
        {
            reiniciarVariables();
            configuracionInicial();
            borrarCampos();
            tabla2.DataSource=eliminarFilas(workTable2);
            switch (eDepartamento.Text)
            {
                case ("Gestion de Proyectos"):
                    Opciones.Items.AddRange(others);
                    Opciones.Text = "Consultar";
                    Opciones.Enabled = true;
                    tabla2.DataSource =agregarColumnas(workTable2, gproyecto);
                    break;
                default:
                    Opciones.Text = "Consultar";
                    Opciones.Enabled = false;
                    desactivarCheks();
                    desactivarCampos();
                    if (eDepartamento.Text.Equals("Administracion de Inventarios") == true) tabla2.DataSource = agregarColumnas(workTable2, adi);
                    if (eDepartamento.Text.Equals("Recursos Humanos") == true) tabla2.DataSource = agregarColumnas(workTable2, rrhh);
                    break;
            }

        }

        

        private void Opciones_SelectedItemChanged(object sender, EventArgs e)
        {
            borrarCampos();
            devolverColor();
            mensajeError.Visible = false;
            check8.Checked = false;
            borrarAviso();
            switch (Opciones.Text)
            {
                    case ("Registrar"):
                      reiniciarVariables();
                      codigo = "";
                      tabla2.DataSource = eliminarFilas(workTable2);
                      activarCampos();
                      eBuscador.Enabled = false;
                      desactivarCheks();
                      borrarCampos();
                      check8.Enabled=false;
                    break;
                    case ("Modificar"):
                    eBuscador.Enabled = true;
                    activarCheks();
                    break;
                default :
                      check8.Enabled = true;
                      tabla2.DataSource = eliminarFilas(workTable2);
                      desactivarCampos();
                      desactivarCheks();
                      eBuscador.Enabled = true;
                      codigo = "";
                    break;
            }
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            if (check1.Checked == true)
            {
                fecha1.Enabled = true;
            }
            else
            {
                fecha1.Enabled = false;
            }
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            if (check2.Checked == true)
            {
                fecha2.Enabled = true;
            }
            else
            {
                fecha2.Enabled = false;
            }
        }

        private void eBuscador0_Click(object sender, EventArgs e)
        {

        }

        private void fecha1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void fecha2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void check4_CheckedChanged(object sender, EventArgs e)
        {
            if (check4.Checked == true)
            {
                eCodigo.Enabled = true;
            }
            else
            {
                eCodigo.Enabled = false;
                eCodigo.Text = "";
            }
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            if (check3.Checked == true)
            {
                ePresupuesto.Enabled = true;
            }
            else
            {
                ePresupuesto.Enabled = false;
                ePresupuesto.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                eNombre.Enabled = true;
            }
            else
            {
                eNombre.Enabled = false;
                eNombre.Text = "";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void check8_CheckedChanged(object sender, EventArgs e)
        {
            if (check8.Checked == true)
            {
                eBuscador.Text = "";
                eBuscador.Enabled = false;
            }
            else
            {
                eBuscador.Enabled = true;
            }
        }
    }
}
