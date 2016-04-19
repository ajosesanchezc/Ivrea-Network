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
    public abstract class claseEjemplo
    //Implementa  los metodos comunes entre las ventanas de los departamentos
    {
        protected String[] filas = { "" };
        protected String[] gp = { "Consultar" };
        protected String[] others = { "Consultar", "Registrar", "Elminar", "Modificar" };
        protected String[] adi = { "Codigo Activo", "Nombre Activo" };
        protected String[] rrhh = { "Cedula Identidad", "Nombres", "Apellidos", "Fecha Nac." };
        protected String[] gproyecto = { "Codigo del Proyecto", "Nombre del Proyecto" };

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // claseEjemplo
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "claseEjemplo";
            this.Load += new System.EventHandler(this.claseEjemplo_Load);
            this.ResumeLayout(false);

        }

        private void claseEjemplo_Load(object sender, EventArgs e)
        {

        }





    }


}
