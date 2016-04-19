namespace WindowsFormsApplication3
{
    partial class GP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GP));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.e1 = new System.Windows.Forms.Label();
            this.eCodigo = new System.Windows.Forms.TextBox();
            this.e2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabla2 = new System.Windows.Forms.DataGridView();
            this.eDepartamento = new System.Windows.Forms.DomainUpDown();
            this.departamento = new System.Windows.Forms.Label();
            this.eNombre = new System.Windows.Forms.TextBox();
            this.e4 = new System.Windows.Forms.Label();
            this.e5 = new System.Windows.Forms.Label();
            this.ePresupuesto = new System.Windows.Forms.TextBox();
            this.e3 = new System.Windows.Forms.Label();
            this.Opciones = new System.Windows.Forms.DomainUpDown();
            this.accion = new System.Windows.Forms.Label();
            this.eBuscador0 = new System.Windows.Forms.Label();
            this.eBuscador = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.mensajeError = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.check8 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(821, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.salirToolStripMenuItem.Text = "Cambiar Dep.";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.salirToolStripMenuItem1.Text = "Salir.";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // eAceptar
            // 
            this.eAceptar.Location = new System.Drawing.Point(237, 511);
            this.eAceptar.Name = "eAceptar";
            this.eAceptar.Size = new System.Drawing.Size(118, 23);
            this.eAceptar.TabIndex = 0;
            this.eAceptar.Text = "Aceptar";
            this.eAceptar.UseVisualStyleBackColor = true;
            this.eAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ir Menu Princpal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion de Proyectos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1.Location = new System.Drawing.Point(19, 39);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(52, 16);
            this.e1.TabIndex = 10;
            this.e1.Text = "Codigo";
            // 
            // eCodigo
            // 
            this.eCodigo.Location = new System.Drawing.Point(130, 40);
            this.eCodigo.Name = "eCodigo";
            this.eCodigo.Size = new System.Drawing.Size(295, 20);
            this.eCodigo.TabIndex = 11;
            this.eCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2.Location = new System.Drawing.Point(19, 10);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(57, 16);
            this.e2.TabIndex = 13;
            this.e2.Text = "Nombre";
            this.e2.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Resultados";
            // 
            // tabla2
            // 
            this.tabla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tabla2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla2.Location = new System.Drawing.Point(84, 418);
            this.tabla2.Name = "tabla2";
            this.tabla2.Size = new System.Drawing.Size(518, 77);
            this.tabla2.TabIndex = 17;
            this.tabla2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // eDepartamento
            // 
            this.eDepartamento.InterceptArrowKeys = false;
            this.eDepartamento.Items.Add("Gestion de Proyectos");
            this.eDepartamento.Items.Add("Recursos Humanos");
            this.eDepartamento.Items.Add("Administracion de Inventarios");
            this.eDepartamento.Location = new System.Drawing.Point(201, 117);
            this.eDepartamento.Name = "eDepartamento";
            this.eDepartamento.ReadOnly = true;
            this.eDepartamento.Size = new System.Drawing.Size(415, 20);
            this.eDepartamento.TabIndex = 69;
            this.eDepartamento.Text = "Gestion de Proyectos";
            this.eDepartamento.SelectedItemChanged += new System.EventHandler(this.eDepartamento1_SelectedItemChanged);
            // 
            // departamento
            // 
            this.departamento.AutoSize = true;
            this.departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamento.Location = new System.Drawing.Point(119, 117);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(37, 16);
            this.departamento.TabIndex = 68;
            this.departamento.Text = "Dep.";
            // 
            // eNombre
            // 
            this.eNombre.Location = new System.Drawing.Point(130, 11);
            this.eNombre.Name = "eNombre";
            this.eNombre.Size = new System.Drawing.Size(295, 20);
            this.eNombre.TabIndex = 70;
            // 
            // e4
            // 
            this.e4.AutoSize = true;
            this.e4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e4.Location = new System.Drawing.Point(16, 95);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(80, 16);
            this.e4.TabIndex = 71;
            this.e4.Text = "Fecha Inicio";
            // 
            // e5
            // 
            this.e5.AutoSize = true;
            this.e5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e5.Location = new System.Drawing.Point(16, 123);
            this.e5.Name = "e5";
            this.e5.Size = new System.Drawing.Size(78, 16);
            this.e5.TabIndex = 72;
            this.e5.Text = "Fecha Final";
            // 
            // ePresupuesto
            // 
            this.ePresupuesto.Location = new System.Drawing.Point(130, 69);
            this.ePresupuesto.Name = "ePresupuesto";
            this.ePresupuesto.Size = new System.Drawing.Size(295, 20);
            this.ePresupuesto.TabIndex = 73;
            // 
            // e3
            // 
            this.e3.AutoSize = true;
            this.e3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e3.Location = new System.Drawing.Point(17, 68);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(84, 16);
            this.e3.TabIndex = 74;
            this.e3.Text = "Presupuesto";
            // 
            // Opciones
            // 
            this.Opciones.InterceptArrowKeys = false;
            this.Opciones.Items.Add("Consultar");
            this.Opciones.Items.Add("Eliminar");
            this.Opciones.Items.Add("Modificar");
            this.Opciones.Items.Add("Registrar");
            this.Opciones.Location = new System.Drawing.Point(498, 144);
            this.Opciones.Name = "Opciones";
            this.Opciones.ReadOnly = true;
            this.Opciones.Size = new System.Drawing.Size(118, 20);
            this.Opciones.TabIndex = 76;
            this.Opciones.Text = "Consultar";
            this.Opciones.SelectedItemChanged += new System.EventHandler(this.Opciones_SelectedItemChanged);
            // 
            // accion
            // 
            this.accion.AutoSize = true;
            this.accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accion.ForeColor = System.Drawing.Color.Black;
            this.accion.Location = new System.Drawing.Point(443, 145);
            this.accion.Name = "accion";
            this.accion.Size = new System.Drawing.Size(49, 16);
            this.accion.TabIndex = 75;
            this.accion.Text = "Accion";
            // 
            // eBuscador0
            // 
            this.eBuscador0.AutoSize = true;
            this.eBuscador0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eBuscador0.Location = new System.Drawing.Point(119, 148);
            this.eBuscador0.Name = "eBuscador0";
            this.eBuscador0.Size = new System.Drawing.Size(52, 16);
            this.eBuscador0.TabIndex = 78;
            this.eBuscador0.Text = "Codigo";
            this.eBuscador0.Click += new System.EventHandler(this.eBuscador0_Click);
            // 
            // eBuscador
            // 
            this.eBuscador.Location = new System.Drawing.Point(201, 144);
            this.eBuscador.Name = "eBuscador";
            this.eBuscador.Size = new System.Drawing.Size(190, 20);
            this.eBuscador.TabIndex = 77;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.check3);
            this.panel1.Controls.Add(this.check4);
            this.panel1.Controls.Add(this.check2);
            this.panel1.Controls.Add(this.check1);
            this.panel1.Controls.Add(this.fecha2);
            this.panel1.Controls.Add(this.fecha1);
            this.panel1.Controls.Add(this.e3);
            this.panel1.Controls.Add(this.ePresupuesto);
            this.panel1.Controls.Add(this.e5);
            this.panel1.Controls.Add(this.e4);
            this.panel1.Controls.Add(this.eNombre);
            this.panel1.Controls.Add(this.e2);
            this.panel1.Controls.Add(this.eCodigo);
            this.panel1.Controls.Add(this.e1);
            this.panel1.Location = new System.Drawing.Point(103, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 156);
            this.panel1.TabIndex = 79;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(447, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 81;
            this.checkBox1.Text = "Modificar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(447, 69);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(69, 17);
            this.check3.TabIndex = 80;
            this.check3.Text = "Modificar";
            this.check3.UseVisualStyleBackColor = true;
            this.check3.CheckedChanged += new System.EventHandler(this.check3_CheckedChanged);
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(447, 40);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(69, 17);
            this.check4.TabIndex = 79;
            this.check4.Text = "Modificar";
            this.check4.UseVisualStyleBackColor = true;
            this.check4.CheckedChanged += new System.EventHandler(this.check4_CheckedChanged);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(447, 122);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(69, 17);
            this.check2.TabIndex = 78;
            this.check2.Text = "Modificar";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(447, 95);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(69, 17);
            this.check1.TabIndex = 77;
            this.check1.Text = "Modificar";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged);
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(130, 124);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(295, 20);
            this.fecha2.TabIndex = 76;
            this.fecha2.ValueChanged += new System.EventHandler(this.fecha2_ValueChanged);
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(130, 96);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(295, 20);
            this.fecha1.TabIndex = 75;
            this.fecha1.ValueChanged += new System.EventHandler(this.fecha1_ValueChanged);
            // 
            // mensajeError
            // 
            this.mensajeError.AutoSize = true;
            this.mensajeError.ForeColor = System.Drawing.Color.Red;
            this.mensajeError.Location = new System.Drawing.Point(100, 366);
            this.mensajeError.Name = "mensajeError";
            this.mensajeError.Size = new System.Drawing.Size(29, 13);
            this.mensajeError.TabIndex = 80;
            this.mensajeError.Text = "Error";
            this.mensajeError.Visible = false;
            // 
            // tiempo
            // 
            this.tiempo.Enabled = true;
            this.tiempo.Interval = 50;
            // 
            // check8
            // 
            this.check8.AutoSize = true;
            this.check8.Location = new System.Drawing.Point(513, 184);
            this.check8.Name = "check8";
            this.check8.Size = new System.Drawing.Size(118, 17);
            this.check8.TabIndex = 82;
            this.check8.Text = "Todos Los registros";
            this.check8.UseVisualStyleBackColor = true;
            this.check8.CheckedChanged += new System.EventHandler(this.check8_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.check8);
            this.panel2.Controls.Add(this.mensajeError);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.eBuscador0);
            this.panel2.Controls.Add(this.eBuscador);
            this.panel2.Controls.Add(this.Opciones);
            this.panel2.Controls.Add(this.accion);
            this.panel2.Controls.Add(this.eDepartamento);
            this.panel2.Controls.Add(this.departamento);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.tabla2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.eAceptar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 606);
            this.panel2.TabIndex = 83;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // GP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 597);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Proyectos-IVREA Company";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Button eAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.TextBox eCodigo;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tabla2;
        private System.Windows.Forms.DomainUpDown eDepartamento;
        private System.Windows.Forms.Label departamento;
        private System.Windows.Forms.TextBox eNombre;
        private System.Windows.Forms.Label e4;
        private System.Windows.Forms.Label e5;
        private System.Windows.Forms.TextBox ePresupuesto;
        private System.Windows.Forms.Label e3;
        private System.Windows.Forms.DomainUpDown Opciones;
        private System.Windows.Forms.Label accion;
        private System.Windows.Forms.Label eBuscador0;
        private System.Windows.Forms.TextBox eBuscador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.Label mensajeError;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox check8;
        private System.Windows.Forms.Panel panel2;
    }
}

