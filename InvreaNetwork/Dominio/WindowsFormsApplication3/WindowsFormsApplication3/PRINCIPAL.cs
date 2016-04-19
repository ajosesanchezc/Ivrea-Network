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
    public partial class PRINCIPAL : Form
    {
        public PRINCIPAL()
        {
            InitializeComponent();
        }

        private void eIngresar_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.Visible = true;
            this.Visible = false;
        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {

        }
    }
}
