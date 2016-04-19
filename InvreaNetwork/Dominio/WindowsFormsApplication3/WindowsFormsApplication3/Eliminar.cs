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
    public partial class Eliminar : Form
    {
        Cliente cliente;
        public Eliminar()
        {
            InitializeComponent();
            cliente = new Cliente();
        }



        private bool validarCampos()
        {
            if ((eLogin.Text.Equals("") == true) || (ePassword.Text.Equals("") == true))
            {
                return false;
            }
            return true;
        }



        private void mostrarAviso(string mensaje)
        {
            avisos.Text = mensaje;
            avisos.Visible = true;
        }

        private string construirMensaje(string campo1, string campo2)
        {
            string sms = "AC E0002|" + campo1 + "|" + campo2 + "|";
            return sms;

        }

        private void Respuesta(String respuesta)
        {
            Console.WriteLine(respuesta.Substring(3, 1));

            if (respuesta.Substring(3, 1) == "1")
            {

                String[] vector = respuesta.Split('|');
                mostrarAviso(vector[1]);
            }
            else
                mostrarAviso("La eliminacion se realizo correctamente");
        }


        


        private void button1_Click(object sender, EventArgs e)
        {
            String respuesta = "";
            String mensaje = "";
            if (validarCampos() == true)
            {
                mensaje = construirMensaje(eLogin.Text, ePassword.Text);
                respuesta = cliente.enviar(mensaje);
                Console.WriteLine(respuesta);
                Respuesta(respuesta);
            }
            else
            {
                
                mostrarAviso("Verificar Campos vacios");  
            }

          




        }

        private void button2_Click(object sender, EventArgs e)
        {
                  
            PRINCIPAL principal = new PRINCIPAL();
            principal.Visible = true;
            this.Visible = false;
        }
        
    }
}
