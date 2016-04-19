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
    public partial class LOGIN : claseBase1
    {
        string sms="";
        string respuesta="";
        string mensaje = "";
        Cliente cliente;
        /*////////////////////////////CONSTRUCTOR/////////////////*/
        public LOGIN()
        {
            InitializeComponent();
            cliente = new Cliente();
        }


 
   
        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void mostrarAviso(string mensaje)
        {
            avisos.Text = mensaje;
            avisos.Visible = true;
        }

        private string getDepartamento(string mensaje)
        {
            string dto = mensaje.Substring(0, 3);
            Console.WriteLine(dto);
            return dto;
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
        
         
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void check2_CheckedChanged_1(object sender, EventArgs e)
        {
         
           
        }

        private bool validarCampos()
        {
            if ((eLogin.Text.Equals("")==true)||(ePassword.Text.Equals("")==true))
            {
                return false;
            }
            return true;
        }


     




        private  void button1_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                mensaje = construirMensaje(eLogin.Text, ePassword.Text);
                Console.WriteLine("EL mensaje es:");
                Console.WriteLine(mensaje);
                respuesta = cliente.enviar(mensaje);
                Console.WriteLine(respuesta);
                switch (getDepartamento(respuesta))
                {
                    case ("RRH"):
                        RRHH recursosH = new RRHH();
                        recursosH.Visible = true;
                        this.Visible = false;
                        break;
                    case ("ADI"):
                        ADI administracionI = new ADI();
                        administracionI.Visible = true;
                        this.Visible = false;
                        break;
                    case ("GP "):
                        GP gestionP = new GP();
                        gestionP.Visible = true;
                        this.Visible = false;
                        break;
                   default:
                        String[] vector = respuesta.Split('|');
                        mostrarAviso(vector[1]);
                        break;
                }
               
            }
            else
            {
                mostrarAviso("Verificar Campos vacios");
            }
            
            
        }

        private string construirMensaje(string campo1,string campo2)
        {
            string  sms="AC C0002|"+campo1+"|"+campo2+"|";
            return sms;

        }

        private void check1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRINCIPAL principal = new PRINCIPAL();
            principal.Visible = true;
            this.Visible = false;
        }
    }
}
