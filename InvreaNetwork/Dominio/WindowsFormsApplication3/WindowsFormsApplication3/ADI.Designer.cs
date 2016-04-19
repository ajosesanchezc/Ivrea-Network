namespace WindowsFormsApplication3
{
    partial class ADI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADI));
            this.label1 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.eAceptar = new System.Windows.Forms.Button();
            this.eDepartamento = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Opciones = new System.Windows.Forms.DomainUpDown();
            this.eBuscador = new System.Windows.Forms.TextBox();
            this.accion = new System.Windows.Forms.Label();
            this.e0 = new System.Windows.Forms.Label();
            this.eError = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.check8 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.eCodigo = new System.Windows.Forms.TextBox();
            this.e4 = new System.Windows.Forms.Label();
            this.eNombre = new System.Windows.Forms.TextBox();
            this.ePrecio = new System.Windows.Forms.TextBox();
            this.e3 = new System.Windows.Forms.Label();
            this.eCantidad = new System.Windows.Forms.TextBox();
            this.e1 = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Administracion de Inventarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(103, 423);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(510, 75);
            this.tabla.TabIndex = 62;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Resultados";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 71;
            this.button2.Text = "Ir Menu Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // eAceptar
            // 
            this.eAceptar.Location = new System.Drawing.Point(242, 521);
            this.eAceptar.Name = "eAceptar";
            this.eAceptar.Size = new System.Drawing.Size(118, 23);
            this.eAceptar.TabIndex = 70;
            this.eAceptar.Text = "Aceptar";
            this.eAceptar.UseVisualStyleBackColor = true;
            this.eAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // eDepartamento
            // 
            this.eDepartamento.InterceptArrowKeys = false;
            this.eDepartamento.Items.Add("Administracion de Inventarios");
            this.eDepartamento.Items.Add("Gestion de Proyectos");
            this.eDepartamento.Items.Add("Recursos Humanos");
            this.eDepartamento.Location = new System.Drawing.Point(201, 100);
            this.eDepartamento.Name = "eDepartamento";
            this.eDepartamento.ReadOnly = true;
            this.eDepartamento.Size = new System.Drawing.Size(389, 20);
            this.eDepartamento.TabIndex = 73;
            this.eDepartamento.Text = "Administracion de Inventarios";
            this.eDepartamento.SelectedItemChanged += new System.EventHandler(this.eDepartamento1_SelectedItemChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Departamento";
            // 
            // Opciones
            // 
            this.Opciones.InterceptArrowKeys = false;
            this.Opciones.Items.Add("Consultar");
            this.Opciones.Items.Add("Eliminar");
            this.Opciones.Items.Add("Modificar");
            this.Opciones.Items.Add("Registrar");
            this.Opciones.Location = new System.Drawing.Point(420, 130);
            this.Opciones.Name = "Opciones";
            this.Opciones.ReadOnly = true;
            this.Opciones.Size = new System.Drawing.Size(170, 20);
            this.Opciones.TabIndex = 78;
            this.Opciones.Text = "Consultar";
            this.Opciones.SelectedItemChanged += new System.EventHandler(this.Opciones_SelectedItemChanged);
            // 
            // eBuscador
            // 
            this.eBuscador.Location = new System.Drawing.Point(201, 129);
            this.eBuscador.Name = "eBuscador";
            this.eBuscador.Size = new System.Drawing.Size(129, 20);
            this.eBuscador.TabIndex = 77;
            // 
            // accion
            // 
            this.accion.AutoSize = true;
            this.accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accion.Location = new System.Drawing.Point(363, 133);
            this.accion.Name = "accion";
            this.accion.Size = new System.Drawing.Size(49, 16);
            this.accion.TabIndex = 76;
            this.accion.Text = "Accion";
            // 
            // e0
            // 
            this.e0.AutoSize = true;
            this.e0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e0.Location = new System.Drawing.Point(77, 133);
            this.e0.Name = "e0";
            this.e0.Size = new System.Drawing.Size(52, 16);
            this.e0.TabIndex = 62;
            this.e0.Text = "Codigo";
            // 
            // eError
            // 
            this.eError.AutoSize = true;
            this.eError.ForeColor = System.Drawing.Color.Red;
            this.eError.Location = new System.Drawing.Point(92, 353);
            this.eError.Name = "eError";
            this.eError.Size = new System.Drawing.Size(22, 13);
            this.eError.TabIndex = 79;
            this.eError.Text = "xxx";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 91;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem1.Text = "Cambiar Dep.";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem2.Text = "Salir.";
            // 
            // check8
            // 
            this.check8.AutoSize = true;
            this.check8.Location = new System.Drawing.Point(432, 172);
            this.check8.Name = "check8";
            this.check8.Size = new System.Drawing.Size(114, 17);
            this.check8.TabIndex = 92;
            this.check8.Text = "Todos los registros";
            this.check8.UseVisualStyleBackColor = true;
            this.check8.CheckedChanged += new System.EventHandler(this.check8_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(95, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 133);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.check4);
            this.panel1.Controls.Add(this.check3);
            this.panel1.Controls.Add(this.check2);
            this.panel1.Controls.Add(this.check1);
            this.panel1.Controls.Add(this.eCodigo);
            this.panel1.Controls.Add(this.e4);
            this.panel1.Controls.Add(this.eNombre);
            this.panel1.Controls.Add(this.ePrecio);
            this.panel1.Controls.Add(this.e3);
            this.panel1.Controls.Add(this.eCantidad);
            this.panel1.Controls.Add(this.e1);
            this.panel1.Controls.Add(this.e2);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 108);
            this.panel1.TabIndex = 64;
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(450, 85);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(69, 17);
            this.check4.TabIndex = 67;
            this.check4.Text = "Modificar";
            this.check4.UseVisualStyleBackColor = true;
            this.check4.CheckedChanged += new System.EventHandler(this.check4_CheckedChanged);
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(450, 62);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(69, 17);
            this.check3.TabIndex = 66;
            this.check3.Text = "Modificar";
            this.check3.UseVisualStyleBackColor = true;
            this.check3.CheckedChanged += new System.EventHandler(this.check3_CheckedChanged_1);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(450, 35);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(69, 17);
            this.check2.TabIndex = 65;
            this.check2.Text = "Modificar";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(449, 7);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(69, 17);
            this.check1.TabIndex = 64;
            this.check1.Text = "Modificar";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged_1);
            // 
            // eCodigo
            // 
            this.eCodigo.Location = new System.Drawing.Point(124, 55);
            this.eCodigo.Name = "eCodigo";
            this.eCodigo.Size = new System.Drawing.Size(304, 20);
            this.eCodigo.TabIndex = 63;
            // 
            // e4
            // 
            this.e4.AutoSize = true;
            this.e4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e4.Location = new System.Drawing.Point(3, 59);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(52, 16);
            this.e4.TabIndex = 62;
            this.e4.Text = "Codigo";
            // 
            // eNombre
            // 
            this.eNombre.Location = new System.Drawing.Point(124, 3);
            this.eNombre.Name = "eNombre";
            this.eNombre.Size = new System.Drawing.Size(304, 20);
            this.eNombre.TabIndex = 51;
            // 
            // ePrecio
            // 
            this.ePrecio.Location = new System.Drawing.Point(124, 81);
            this.ePrecio.Name = "ePrecio";
            this.ePrecio.Size = new System.Drawing.Size(304, 20);
            this.ePrecio.TabIndex = 53;
            // 
            // e3
            // 
            this.e3.AutoSize = true;
            this.e3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e3.Location = new System.Drawing.Point(3, 85);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(87, 16);
            this.e3.TabIndex = 61;
            this.e3.Text = "Precio Activo";
            // 
            // eCantidad
            // 
            this.eCantidad.Location = new System.Drawing.Point(124, 29);
            this.eCantidad.Name = "eCantidad";
            this.eCantidad.Size = new System.Drawing.Size(304, 20);
            this.eCantidad.TabIndex = 54;
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1.Location = new System.Drawing.Point(3, 8);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(57, 16);
            this.e1.TabIndex = 55;
            this.e1.Text = "Nombre";
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2.Location = new System.Drawing.Point(3, 33);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(62, 16);
            this.e2.TabIndex = 56;
            this.e2.Text = "Cantidad";
            // 
            // ADI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.check8);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.eError);
            this.Controls.Add(this.e0);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.eBuscador);
            this.Controls.Add(this.accion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eDepartamento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.eAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.label1);
            this.Name = "ADI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion_de_Invetarios";
            this.Load += new System.EventHandler(this.Administracion_de_Invetarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button eAceptar;
        private System.Windows.Forms.DomainUpDown eDepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown Opciones;
        private System.Windows.Forms.TextBox eBuscador;
        private System.Windows.Forms.Label accion;
        private System.Windows.Forms.Label e0;
        private System.Windows.Forms.Label eError;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.CheckBox check8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.TextBox eCodigo;
        private System.Windows.Forms.Label e4;
        private System.Windows.Forms.TextBox eNombre;
        private System.Windows.Forms.TextBox ePrecio;
        private System.Windows.Forms.Label e3;
        private System.Windows.Forms.TextBox eCantidad;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Label e2;
    }
}