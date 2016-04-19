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
    public partial class Registro : Form
    {
        Cliente cliente;
        String respuesta;

        public Registro()
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


        private void Respuesta(String respuesta)
        {
            Console.WriteLine(respuesta.Substring(3,1));

            if (respuesta.Substring(3, 1) == "1")
            {
                
                String[] vector = respuesta.Split('|');


                mostrarAviso(vector[1]);
            }
            else
            {
                mostrarAviso("Se ha registrado exitosamente");
            }



        }


        private string construirMensaje(string campo0,string campo1, string campo2)
        {
            string sms = campo0 + "A0002|" + campo1 + "|" + campo2 + "|";

            System.Console.WriteLine(sms);
            return sms;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            String departamento= "";

            if (validarCampos() == true)
            {

                switch (eDepartamento.Text)
                {
                    case ("Administracion de Inventarios"):
                        departamento = "ADI";
                        break;
                    case ("Recursos Humanos"):
                        departamento = "RRH";
                        break;
                    case ("Gestion de Proyectos"):
                        departamento = "GP ";
                        break;
                    default:
                        break;
                }
                respuesta =  cliente.enviar( construirMensaje(departamento, eLogin.Text, ePassword.Text));
                Respuesta(respuesta);
                Console.WriteLine(respuesta);


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

        private void e2_Click(object sender, EventArgs e)
        {

        }
    }
}
