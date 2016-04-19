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
    public partial class ADI : claseBase1
    {
        /*////////////////////////////////////////VARIABLES GLOBALES///////////////////////////*/
        DataTable workTable1;
        int contador;
        string mensaje = "";
        string mensajeModificado = "ADIM";
        string respuesta = "SI";
        string codigo = "";
        bool  flag=true;
        Cliente cliente;

        /*/////////////////////////////////////////CONSTRUCTOR//////////////////////////////////*/
        public ADI()
        {
            InitializeComponent();
            workTable1 = new DataTable();
            workTable1=agregarColumnas(workTable1, adi);
            tabla.DataSource = workTable1;
            configuracionInicial();
            cliente = new Cliente();
        }

        /*/////////////////////////////////////////MENSAJES////////////////////////////////////*/
        //Metodos relacionados con los mensajes enviados y recibidos por el servidor a el cliente.
        
        private string registrarMensaje()
        //Construye el mensaje de la opcion registro del departamento de Administracion de Inventarios.
        {
            string departamento;
            departamento = "ADII" + "0004" + "|" + eCodigo.Text + "|" + eNombre.Text + "|" + eCantidad.Text + "|" + ePrecio.Text + "|";
            return departamento;

        }

        private void mostrarError(string mensaje)
        //Avisa al usuario sobre un posible error cometido.
        {
            eError.Text = mensaje;
            eError.Visible = true;
        }

        private string modificarMensaje(string mensaje,string codigo)
        //Construye el mensaje modificado por el usuario.
        {
            contador = 0;
            int bandera = 0;
            devolverColor();
            if (eNombre.Enabled == true)
            {
                if (validacionCampos3(eNombre.Text) == 0)
                {
                    contador++;
                    mensaje = mensaje + "nombre" + "|" + eNombre.Text + "|";
                }
                else 
                {
                    flag = false;
                    cambiarColor(e1);
                }
            }

            if (eCantidad.Enabled == true)
            {
                if (validacionCampos2(eCantidad.Text) == 0)
                {
                    contador++;
                    mensaje = mensaje + "cantidad" + "|" + eCantidad.Text + "|";
                }
                else
                {
                    flag = false;
                    cambiarColor(e2);
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
                    cambiarColor(e4);
                    flag = false;
                }

            }
            if (ePrecio.Enabled == true)
            {
                if (validacionCampos2(ePrecio.Text) == 0)
                {
                    contador++;
                    mensaje = mensaje + "precio" + "|" + ePrecio.Text + "|";
                }
                else
                {
                    flag = false;
                    cambiarColor(e3);
                }

            }
           

            if ((mensaje.Equals("") == false)&&(bandera==0))
            {
                contador = contador * 2 + 1;
                mensaje = "ADIM" + "000" + Convert.ToString(contador) + "|"+codigo+"|" + mensaje;
                eError.Visible = false;
            }
            if (mensaje.Equals("") == true)
            {
                flag = false;
            }
            
            Console.Write("El mensaje es:  ");
            Console.WriteLine(mensajeModificado);
            //Desde aqui se envia el mensaje modificado al servidor.
            return mensaje;

        }


      /*///////////////////////////////////////////CAMPOS/////////////////////////////////////////*/  
      //En esta seccion se encuentran los metodos relacionados con la manipulacion
      //De los campos y las etiquetas del WindosForm.
        private void activarCampos()
        {
            eNombre.Enabled = true;
            eCantidad.Enabled = true;
            eCodigo.Enabled = true;
            ePrecio.Enabled = true;
          
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
            desactivarCampos();
        }

        private void borrarCampos()
        //Inicializa todos los campos.
        {
            eNombre.Text = "";
            ePrecio.Text = "";
            eCodigo.Text = "";
            eCantidad.Text = "";
            eBuscador.Text = "";
        }

        private void cambiarColor(Label etiqueta)
        {
            etiqueta.ForeColor = System.Drawing.Color.Red;
        }

        private void configuracionInicial()
        //Establece la configuracion inicial de los componentes graficos(Botones,radiobutons ,etc)
        {
            desactivarCampos();
            desactivarCheks();
            eError.Visible = false;
            Opciones.Text = "Consultar";
            eDepartamento.Text = "Administracion de Inventarios";
            reestablecerVariables();
            borrarCampos();
            workTable1 = eliminarFilas(workTable1);
            tabla.DataSource = workTable1;
        }

        private void desactivarCheks()
        {
            check1.Enabled = false;
            check2.Enabled = false;
            check3.Enabled = false;
            check4.Enabled = false;
        }

        private void desactivarCampos()
        {
            eNombre.Enabled = false;
            eCantidad.Enabled = false;
            eCodigo.Enabled = false;
            ePrecio.Enabled = false;
        }
        private void devolverColor()
        {
            e1.ForeColor = System.Drawing.Color.Black;
            e2.ForeColor = System.Drawing.Color.Black;
            e3.ForeColor = System.Drawing.Color.Black;
            e4.ForeColor = System.Drawing.Color.Black;
        }

        private void mensajeDeError(string mensaje)
        {
            eError.Text = mensaje;
            eError.Visible = true;
        }

        private void reestablecerVariables()
        {
            mensaje = "";
            respuesta = "";
            codigo = "";
        }
       /*//////////////////////////////////////////VALIDACIONES///////////////////////////////*/
       //En esta seccion se encuentra los metodos que validan o verifican los datos introducidos
        //por el usuario.
        private bool validarCampos()
        //Utiliza los metodos de la clase base, para validar los datos introducido por el usuario.
        {
            bool bandera = true;
            if (validacionCampos3(eNombre.Text)!=0) bandera = false;
            if (validacionCampos2(eCodigo.Text)!=0) bandera = false;
            if (validacionCampos2(ePrecio.Text)!=0) bandera = false;
            if (validacionCampos2(eCantidad.Text)!=0) bandera = false;
            return bandera;
        }


        /*///////////////////////////////////EVENTOS//////////////////////////////////////////*/
        
        //En esta seccion, se encuentra todos los metodos, relacionados con algun evento o
        //accion de algun componente grafico(Botones,ComboBox,Radio Butons,etc..)
        private void Administracion_de_Invetarios_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            configuracionInicial();
        }

        private void button1_Click(object sender, EventArgs e)
        //Realiza la Accion solicitada por el usuario (Consultar,eliminar,registrar,Modificar)
        {
            int bandera = 0;
            flag = true;
            if (eDepartamento.Text.Equals("Administracion de Inventarios") == true)
            {
                switch (Opciones.Text)
                {
                    case ("Registrar"):

                        if (validarCampos() == true)
                        {
                            mensaje = registrarMensaje();
                            respuesta = cliente.enviar(mensaje);
                            if (detectorError(respuesta) == 0)
                            {
                                configuracionInicial();
                            }
                            else
                            {
                                bandera = 1;
                                mostrarError(desfragmentar(respuesta)[1]);
                            }
                        }
                        else
                        {
                            mostrarError("Error en los campos;Verificar los campos senalados");
                            bandera = 1;
                        }
                        break;
                    case ("Modificar"):
                        if (eBuscador.Text.Equals("") == false)
                        {
                            mensaje = modificarMensaje(mensaje, eBuscador.Text);
                            if (flag == true)
                            {
                                respuesta = cliente.enviar(mensaje);
                                if (detectorError(respuesta) == 0)
                                {
                                    configuracionInicial();
                                    Console.WriteLine(mensaje);
                                    Console.WriteLine("El mensaje ha sido modificado con exitos");
                                }
                                else
                                {
                                    mostrarError(desfragmentar(respuesta)[1]);
                                }
                            }
                            else
                            {
                                mensajeDeError("Operacion sin exitos;No hay datos para modificar");
                            }
                        }
                        else
                        {

                        }
                       
                        break;
                    case ("Consultar"):

                        if (check8.Checked == false)
                        {
                            if (validacionCampos2(eBuscador.Text) == 0)
                            {
                                mensaje = "ADIC0001|" + eBuscador.Text + "|";
                                eError.Visible = false;
                                respuesta = cliente.enviar(mensaje);
                                if (detectorError(respuesta) == 0)
                                {
                                    codigo = eBuscador.Text;
                                    workTable1 = agregarFila(workTable1, consultarMensaje1(respuesta));
                                    tabla.DataSource = workTable1;
                                }
                                else mostrarError("Consulta sin exitos. Intente de nuevo");
                                
                            }
                            else
                            {
                                mostrarError("Codigo Incorrecto; Verifique el codigo a buscar");
                             
                            }
                        }
                        else
                        {

                            mensaje = "ADIT0000";
                            respuesta = cliente.enviar(mensaje);
                            if (detectorError(respuesta) == 0)
                            {
                                string[] auxiliar = consultarMensaje1(respuesta);
                                agregarFilas(workTable1, auxiliar);
                            }
                        }
                        break;
                    case ("Eliminar"):
                        if (eBuscador.Text.Equals("") == false)
                        {
                            mensaje = "ADIE0001|" + eBuscador.Text + "|";
                            respuesta = cliente.enviar(mensaje);
                            if (detectorError(respuesta) == 0)
                            {
                                configuracionInicial();
                                mostrarError("Datos eliminados sastifactoriamente.");
                            }
                            else
                            {
                                bandera = 1;
                                mostrarError("No se pudo eliminar la data");
                            }
                        }
                        else
                        {
                            mensajeDeError("Datos de busqueda vacios;Intente nuevamente");
                        }
                        break;

                }
               
                borrarCampos();
            }//fin if.
            else
            {
                switch (eDepartamento.Text)
                {
                    case ("Recursos Humanos"):
                        if (check8.Checked == false)
                        {
                            if (eBuscador.Text.Equals("") == false) mensaje = "RRHC0001|" + eBuscador.Text + "|";
                            else mensajeDeError("Campo de busqueda vacio; Ingrese la cedula nuevamente");
                        }
                        else
                        {
                            mensaje = "RRHT0000";
                        }
                        
                        break;
                    case ("Gestion de Proyectos"):
                        if (check8.Checked == false)
                        {
                            if (eBuscador.Text.Equals("") == false)mensaje = "GP C0001|" + eBuscador.Text + "|";
                            else mensajeDeError("Campo de busqueda vacio; Ingrese el codigo nuevamente");
                        }
                        else mensaje = "GP T0000";
                        break;
                }
                if (check8.Checked == false)
                {
                    if (eBuscador.Text.Equals("") == false)
                    {
                        respuesta = cliente.enviar(mensaje);
                        if (detectorError(respuesta) == 0)
                        {
                            tabla.DataSource = agregarFila(workTable1, consultarMensaje1(respuesta));
                        }
                        else mensajeDeError("Consulta sin exitos.");
                    }
                    else
                    {
                        mensajeDeError("Campo de busqueda vacia;Intente de nuevo");
                    }
                }
                else
                {
                    respuesta = cliente.enviar(mensaje);
                    tabla.DataSource = agregarFilas(workTable1, consultarMensaje1(respuesta));
                }
               
            }
            
            mensaje = "";
        }

        private void eDepartamento1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (eDepartamento.Text.Equals("Administracion de Inventarios")==true)
            {
                Opciones.Items.AddRange(others);
                tabla.DataSource = establecerColumnas(workTable1, adi);
                Opciones.Text = "Consultar";
                Opciones.Enabled = true;
                eCodigo.Text = "Codigo";
            }
            else
            {
                if (eDepartamento.Text.Equals("Recursos Humanos") == true)
                {
                    tabla.DataSource = establecerColumnas(workTable1, rrhh);
                    eCodigo.Text = "Cedula";
                }
                else
                {
                    tabla.DataSource = establecerColumnas(workTable1, gproyecto);
                    eCodigo.Text = "Codigo";
                }
                Opciones.Text = "Consultar";
                Opciones.Enabled = false;
                desactivarCampos();
            }
            /*workTable1 = eliminarFilas();*/
            /*tabla.DataSource = workTable1();*/
        }
        private void check1_CheckedChanged_1(object sender, EventArgs e)
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
                eCantidad.Enabled = true;
            }
            else
            {
                eCantidad.Enabled = false;
                eCantidad.Text = "";
            }
        }

        private void check3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (check3.Checked == true)
            {
                eCodigo.Enabled = true;
            }
            else
            {
                eCodigo.Enabled = false;
                eCodigo.Text = "";
            }
        }

        private void check4_CheckedChanged(object sender, EventArgs e)
        {
            if (check4.Checked == true)
            {
                ePrecio.Enabled = true;
            }
            else
            {
                ePrecio.Enabled = false;
                ePrecio.Text = "";
            }
        }
        private void check8_CheckedChanged(object sender, EventArgs e)
        {
            if (check8.Checked == true)
            {
                eBuscador.Enabled = false;
            }
            else
            {
                eBuscador.Enabled = true;
            }
        }

        private void borrarAviso()
        //Metodo encargado de borrar los mensajes enviados al usuario.
        {
            eError.Text = "";
            eError.Visible = false;
        }

        private void Opciones_SelectedItemChanged(object sender, EventArgs e)
        {
            desactivarCheks();
            borrarCampos();
            desactivarCampos();
            devolverColor();
            check8.Enabled = false;
            check8.Checked = false;
            tabla.DataSource = eliminarFilas(workTable1);
            switch (Opciones.Text)
            {
                case ("Registrar"):
                    activarCampos();
                    eBuscador.Enabled = false;
                    reestablecerVariables();
                    tabla.DataSource = eliminarFilas(workTable1);

                    break;
                case ("Modificar"):
                    activarCheks();
                    eBuscador.Enabled = true;
                    break;
                
                default:
                    check8.Enabled = true;
                    eBuscador.Enabled = true;
                    tabla.DataSource = eliminarFilas(workTable1);
                    borrarCampos();
                    break;
            }
            borrarAviso();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PRINCIPAL principal = new PRINCIPAL();
            principal.Visible = true;
            this.Visible = false;
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        } 
    }
}
