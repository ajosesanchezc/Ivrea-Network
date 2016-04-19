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
    public partial class MODIFICAR : claseBase1
    {



        private List<String> campo1;//campos del departamento
        private List<String> campo2;//datos de los campos
        string[] departamento;
        string[] campos;
        string mensaje;
        DataTable workTable1;
        Form ventana;

        public MODIFICAR(string[] departamento, string[] campos,Form ventana)
        {
            InitializeComponent();
            this.departamento = departamento;
            this.campos = campos;
            campo1 = new List<string>();
            campo2 = new List<string>();
            workTable1 = new DataTable();
            workTable1 = agregarColumnas(workTable1, campos);
            tabla.DataSource = workTable1;
            cargarDatos();
            titulos(departamento);
            desactivarCampos();
            this.ventana = ventana;
        }
        private void activarCampos()
        {
            fecha1.Enabled = true;
            f1.Enabled = true;


        }
        private void desactivarCampos()
        //Desabilita los campos de modificacion.
        {
            fecha1.Enabled = false;
            f1.Enabled = false;
        }
        private void cargarDatos()
        //Coloca los campos en el comboBox
        {
            eOpciones.Items.Clear();
            eOpciones.Items.AddRange(campos);
           
        }

        private void ModificarRRH_Load(object sender, EventArgs e)
        {

        }

        protected DataTable agregarColumnas(DataTable workTable, String[] listaNombres)
        //Agrega N catidad de columnas a DataTable.
        {
            int i = 0;
            for (i = 0; i < listaNombres.Length; ++i)
            {
                workTable.Columns.Add(listaNombres[i], typeof(String));
            }
            return workTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //mensaje = mensaje + eOpciones.Text+"|"+eModificador.Text +"|";
            if (eModificador.Text.Equals("") == false)
            {
                if (campo1.Contains(eOpciones.Text) == false)
                {
                    campo1.Add(eOpciones.Text);
                    campo2.Add(eModificador.Text);
                    Console.WriteLine(campo1.IndexOf(eOpciones.Text));

                }
                else
                {
                    campo2.RemoveAt(campo1.IndexOf(eOpciones.Text));
                    campo2.Insert(campo1.IndexOf(eOpciones.Text), eModificador.Text);
                    Console.WriteLine(campo1.IndexOf(eOpciones.Text));

                }
                int i = 0;
                for (i = 0; i < campo2.Count; ++i)
                {
                    Console.WriteLine(campo2.ElementAt(i));
                }
                eModificador.Text = "";
            }
            else
            {
                eError.Text = "Error:Introduzca un valor";
            }
        }

        private string data(List<String> campo1,List<String> campo2)
        //Construye el mensaje y devuelve el mensaje a enviar.
        {
            int i = 0;
            int auxiliar1 = campo1.Count + campo2.Count + 1;
            string auxiliar2="";
            if (auxiliar1 >= 10)
            {
                auxiliar2 = "00" + Convert.ToString(campo1.Count + campo2.Count + 1);
            }
            else
            {
                auxiliar2 = "000" + Convert.ToString(campo1.Count + campo2.Count + 1);
            }
            string msn = departamento[0] + "M" + auxiliar2 +"|"+departamento[1]+"|";
            for (i = 0; i < campo1.Count; ++i)
            {
                msn = msn + campo1.ElementAt(i)+"|"+campo2.ElementAt(i) + "|";
            }
            Console.WriteLine(msn);
            return (msn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(fecha1.Text);
            mensaje=data(campo1, campo2);
        }

        private void titulos(string[] departamento)
        //Establece los titulos de la ventanade acuerdo al departamento
        {
            if (departamento[0].Equals("RRH") == true)
            {
                eTitulo.Text = "Recursos Humanos";
                this.Text = "Recursos Humanos";
            }
            if (departamento[0].Equals("ADI") == true)
            {
                eTitulo.Text = "Administracion de Inventarios";
                this.Text = "Administracion de Inventarios";
            }
            if (departamento[0].Equals("GP_") == true)
            {
                eTitulo.Text = "Gestion de Proyectos";
                this.Text = "Gestion de Proyectos";
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            //tabla.DataSource=desfragmentar(workTable1, mensaje);
            ventana.Visible = true;
            ventana.Enabled = true;
            this.Dispose();
        }

        private void eBuscador_Click(object sender, EventArgs e)
        {
            activarCampos();
        }

        private void fechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void eOpciones_SelectedItemChanged(object sender, EventArgs e)
        {
            switch (eOpciones.Text)
            {
                case "fechaIngreso":
                    f1.Text = eOpciones.Text;
                    activarCampos();
                    eModificador.Enabled = false;
                break;
                case "fechaNacimiento":
                   f1.Text = eOpciones.Text;
                   activarCampos();
                   eModificador.Enabled = false;
                break;
                case "fechaInicio":
                   f1.Text = eOpciones.Text;
                   activarCampos();
                   eModificador.Enabled = false;
                break;
                case "fechaFin":
                   f1.Text = eOpciones.Text;
                   activarCampos();
                   eModificador.Enabled = false;
                break;
                default:
                  f1.Text = "Fecha";
                  eModificador.Enabled = true;
                  desactivarCampos();
                break;

            }
        }




    }
}
