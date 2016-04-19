namespace WindowsFormsApplication3
{
    partial class RRHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RRHH));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.eDepartamento0 = new System.Windows.Forms.Label();
            this.accion = new System.Windows.Forms.Label();
            this.eBuscador1 = new System.Windows.Forms.TextBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.eBuscador0 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check7 = new System.Windows.Forms.CheckBox();
            this.check6 = new System.Windows.Forms.CheckBox();
            this.e7 = new System.Windows.Forms.Label();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.check5 = new System.Windows.Forms.CheckBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.e6 = new System.Windows.Forms.Label();
            this.eCedula = new System.Windows.Forms.TextBox();
            this.e4 = new System.Windows.Forms.Label();
            this.eCosto = new System.Windows.Forms.TextBox();
            this.e3 = new System.Windows.Forms.Label();
            this.eNombre = new System.Windows.Forms.TextBox();
            this.eCargo = new System.Windows.Forms.TextBox();
            this.e5 = new System.Windows.Forms.Label();
            this.eApellido = new System.Windows.Forms.TextBox();
            this.e1 = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            this.eDepartamento = new System.Windows.Forms.DomainUpDown();
            this.Guardar = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.check8 = new System.Windows.Forms.CheckBox();
            this.eError = new System.Windows.Forms.Label();
            this.Opciones = new System.Windows.Forms.DomainUpDown();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.panel1.SuspendLayout();
            this.Guardar.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
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
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salirToolStripMenuItem.Text = "Cambiar Dep.";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.salirToolStripMenuItem1.Text = "Salir.";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(216, 510);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(118, 23);
            this.Aceptar.TabIndex = 19;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Ir Menu Princpal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(44, 39);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(166, 20);
            this.titulo.TabIndex = 21;
            this.titulo.Text = "Recursos Humanos";
            // 
            // eDepartamento0
            // 
            this.eDepartamento0.AutoSize = true;
            this.eDepartamento0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDepartamento0.Location = new System.Drawing.Point(65, 97);
            this.eDepartamento0.Name = "eDepartamento0";
            this.eDepartamento0.Size = new System.Drawing.Size(94, 16);
            this.eDepartamento0.TabIndex = 23;
            this.eDepartamento0.Text = "Departamento";
            // 
            // accion
            // 
            this.accion.AutoSize = true;
            this.accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accion.Location = new System.Drawing.Point(429, 123);
            this.accion.Name = "accion";
            this.accion.Size = new System.Drawing.Size(49, 16);
            this.accion.TabIndex = 24;
            this.accion.Text = "Accion";
            // 
            // eBuscador1
            // 
            this.eBuscador1.Location = new System.Drawing.Point(191, 123);
            this.eBuscador1.Name = "eBuscador1";
            this.eBuscador1.Size = new System.Drawing.Size(159, 20);
            this.eBuscador1.TabIndex = 27;
            this.eBuscador1.TextChanged += new System.EventHandler(this.eTipo_TextChanged);
            // 
            // tabla
            // 
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(102, 411);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(505, 84);
            this.tabla.TabIndex = 33;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla2_CellContentClick);
            // 
            // eBuscador0
            // 
            this.eBuscador0.AutoSize = true;
            this.eBuscador0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eBuscador0.Location = new System.Drawing.Point(65, 127);
            this.eBuscador0.Name = "eBuscador0";
            this.eBuscador0.Size = new System.Drawing.Size(51, 16);
            this.eBuscador0.TabIndex = 39;
            this.eBuscador0.Text = "Cedula";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.check4);
            this.panel1.Controls.Add(this.check7);
            this.panel1.Controls.Add(this.check6);
            this.panel1.Controls.Add(this.e7);
            this.panel1.Controls.Add(this.fecha2);
            this.panel1.Controls.Add(this.check5);
            this.panel1.Controls.Add(this.check1);
            this.panel1.Controls.Add(this.check2);
            this.panel1.Controls.Add(this.fecha1);
            this.panel1.Controls.Add(this.check3);
            this.panel1.Controls.Add(this.e6);
            this.panel1.Controls.Add(this.eCedula);
            this.panel1.Controls.Add(this.e4);
            this.panel1.Controls.Add(this.eCosto);
            this.panel1.Controls.Add(this.e3);
            this.panel1.Controls.Add(this.eNombre);
            this.panel1.Controls.Add(this.eCargo);
            this.panel1.Controls.Add(this.e5);
            this.panel1.Controls.Add(this.eApellido);
            this.panel1.Controls.Add(this.e1);
            this.panel1.Controls.Add(this.e2);
            this.panel1.Location = new System.Drawing.Point(68, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 207);
            this.panel1.TabIndex = 63;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(429, 91);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(69, 17);
            this.check4.TabIndex = 88;
            this.check4.Text = "Modificar";
            this.check4.UseVisualStyleBackColor = true;
            this.check4.CheckedChanged += new System.EventHandler(this.check4_CheckedChanged);
            // 
            // check7
            // 
            this.check7.AutoSize = true;
            this.check7.Location = new System.Drawing.Point(429, 170);
            this.check7.Name = "check7";
            this.check7.Size = new System.Drawing.Size(69, 17);
            this.check7.TabIndex = 84;
            this.check7.Text = "Modificar";
            this.check7.UseVisualStyleBackColor = true;
            this.check7.CheckedChanged += new System.EventHandler(this.check7_CheckedChanged);
            // 
            // check6
            // 
            this.check6.AutoSize = true;
            this.check6.Location = new System.Drawing.Point(429, 143);
            this.check6.Name = "check6";
            this.check6.Size = new System.Drawing.Size(69, 17);
            this.check6.TabIndex = 62;
            this.check6.Text = "Modificar";
            this.check6.UseVisualStyleBackColor = true;
            this.check6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // e7
            // 
            this.e7.AutoSize = true;
            this.e7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e7.Location = new System.Drawing.Point(21, 171);
            this.e7.Name = "e7";
            this.e7.Size = new System.Drawing.Size(94, 16);
            this.e7.TabIndex = 59;
            this.e7.Text = "Fecha Ingreso";
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(138, 169);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(263, 20);
            this.fecha2.TabIndex = 61;
            this.fecha2.ValueChanged += new System.EventHandler(this.fecha2_ValueChanged);
            // 
            // check5
            // 
            this.check5.AutoSize = true;
            this.check5.Location = new System.Drawing.Point(429, 116);
            this.check5.Name = "check5";
            this.check5.Size = new System.Drawing.Size(69, 17);
            this.check5.TabIndex = 87;
            this.check5.Text = "Modificar";
            this.check5.UseVisualStyleBackColor = true;
            this.check5.CheckedChanged += new System.EventHandler(this.check5_CheckedChanged);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(429, 6);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(69, 17);
            this.check1.TabIndex = 86;
            this.check1.Text = "Modificar";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(429, 32);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(69, 17);
            this.check2.TabIndex = 85;
            this.check2.Text = "Modificar";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(138, 141);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(263, 20);
            this.fecha1.TabIndex = 60;
            this.fecha1.ValueChanged += new System.EventHandler(this.fecha1_ValueChanged);
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(429, 60);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(69, 17);
            this.check3.TabIndex = 84;
            this.check3.Text = "Modificar";
            this.check3.UseVisualStyleBackColor = true;
            this.check3.CheckedChanged += new System.EventHandler(this.check3_CheckedChanged);
            // 
            // e6
            // 
            this.e6.AutoSize = true;
            this.e6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e6.Location = new System.Drawing.Point(19, 143);
            this.e6.Name = "e6";
            this.e6.Size = new System.Drawing.Size(77, 16);
            this.e6.TabIndex = 57;
            this.e6.Text = "Fecha Nac.";
            // 
            // eCedula
            // 
            this.eCedula.Location = new System.Drawing.Point(139, 61);
            this.eCedula.Name = "eCedula";
            this.eCedula.Size = new System.Drawing.Size(262, 20);
            this.eCedula.TabIndex = 79;
            this.eCedula.WordWrap = false;
            this.eCedula.TextChanged += new System.EventHandler(this.eCedula_TextChanged);
            // 
            // e4
            // 
            this.e4.AutoSize = true;
            this.e4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e4.Location = new System.Drawing.Point(19, 63);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(51, 16);
            this.e4.TabIndex = 73;
            this.e4.Text = "Cedula";
            // 
            // eCosto
            // 
            this.eCosto.Location = new System.Drawing.Point(139, 87);
            this.eCosto.Name = "eCosto";
            this.eCosto.Size = new System.Drawing.Size(262, 20);
            this.eCosto.TabIndex = 69;
            // 
            // e3
            // 
            this.e3.AutoSize = true;
            this.e3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e3.Location = new System.Drawing.Point(19, 91);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(43, 16);
            this.e3.TabIndex = 68;
            this.e3.Text = "Costo";
            // 
            // eNombre
            // 
            this.eNombre.Location = new System.Drawing.Point(139, 6);
            this.eNombre.Name = "eNombre";
            this.eNombre.Size = new System.Drawing.Size(262, 20);
            this.eNombre.TabIndex = 51;
            this.eNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // eCargo
            // 
            this.eCargo.Location = new System.Drawing.Point(139, 113);
            this.eCargo.Name = "eCargo";
            this.eCargo.Size = new System.Drawing.Size(262, 20);
            this.eCargo.TabIndex = 53;
            // 
            // e5
            // 
            this.e5.AutoSize = true;
            this.e5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e5.Location = new System.Drawing.Point(21, 115);
            this.e5.Name = "e5";
            this.e5.Size = new System.Drawing.Size(45, 16);
            this.e5.TabIndex = 61;
            this.e5.Text = "Cargo";
            // 
            // eApellido
            // 
            this.eApellido.Location = new System.Drawing.Point(139, 32);
            this.eApellido.Name = "eApellido";
            this.eApellido.Size = new System.Drawing.Size(262, 20);
            this.eApellido.TabIndex = 54;
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1.Location = new System.Drawing.Point(21, 4);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(57, 16);
            this.e1.TabIndex = 55;
            this.e1.Text = "Nombre";
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2.Location = new System.Drawing.Point(19, 34);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(65, 16);
            this.e2.TabIndex = 56;
            this.e2.Text = "Apellidos";
            // 
            // eDepartamento
            // 
            this.eDepartamento.InterceptArrowKeys = false;
            this.eDepartamento.Items.Add("Recursos Humanos");
            this.eDepartamento.Items.Add("Administracion de Inventarios");
            this.eDepartamento.Items.Add("Gestion de Proyectos");
            this.eDepartamento.Location = new System.Drawing.Point(191, 97);
            this.eDepartamento.Name = "eDepartamento";
            this.eDepartamento.ReadOnly = true;
            this.eDepartamento.Size = new System.Drawing.Size(416, 20);
            this.eDepartamento.TabIndex = 67;
            this.eDepartamento.Text = "Recursos Humanos";
            this.eDepartamento.SelectedItemChanged += new System.EventHandler(this.eDepartamento1_SelectedItemChanged);
            // 
            // Guardar
            // 
            this.Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Guardar.BackgroundImage")));
            this.Guardar.Controls.Add(this.toolStrip2);
            this.Guardar.Controls.Add(this.check8);
            this.Guardar.Controls.Add(this.eError);
            this.Guardar.Controls.Add(this.Opciones);
            this.Guardar.Controls.Add(this.eDepartamento);
            this.Guardar.Controls.Add(this.panel1);
            this.Guardar.Controls.Add(this.eBuscador0);
            this.Guardar.Controls.Add(this.tabla);
            this.Guardar.Controls.Add(this.eBuscador1);
            this.Guardar.Controls.Add(this.accion);
            this.Guardar.Controls.Add(this.eDepartamento0);
            this.Guardar.Controls.Add(this.titulo);
            this.Guardar.Controls.Add(this.button2);
            this.Guardar.Controls.Add(this.Aceptar);
            this.Guardar.Location = new System.Drawing.Point(0, 0);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(800, 600);
            this.Guardar.TabIndex = 71;
            this.Guardar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 90;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked_1);
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
            this.check8.Location = new System.Drawing.Point(452, 146);
            this.check8.Name = "check8";
            this.check8.Size = new System.Drawing.Size(114, 17);
            this.check8.TabIndex = 88;
            this.check8.Text = "Todos los registros";
            this.check8.UseVisualStyleBackColor = true;
            this.check8.CheckedChanged += new System.EventHandler(this.check8_CheckedChanged);
            // 
            // eError
            // 
            this.eError.AutoSize = true;
            this.eError.ForeColor = System.Drawing.Color.Red;
            this.eError.Location = new System.Drawing.Point(64, 395);
            this.eError.Name = "eError";
            this.eError.Size = new System.Drawing.Size(46, 13);
            this.eError.TabIndex = 72;
            this.eError.Text = "ERROR";
            this.eError.Visible = false;
            // 
            // Opciones
            // 
            this.Opciones.InterceptArrowKeys = false;
            this.Opciones.Items.Add("Consultar");
            this.Opciones.Items.Add("Modificar");
            this.Opciones.Items.Add("Eliminar");
            this.Opciones.Items.Add("Registrar");
            this.Opciones.Location = new System.Drawing.Point(501, 123);
            this.Opciones.Name = "Opciones";
            this.Opciones.ReadOnly = true;
            this.Opciones.Size = new System.Drawing.Size(106, 20);
            this.Opciones.TabIndex = 71;
            this.Opciones.Text = "Consultar";
            this.Opciones.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // RRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 602);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "RRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Humanos-IVREA Company";
            this.Load += new System.EventHandler(this.Ventana4_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Guardar.ResumeLayout(false);
            this.Guardar.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label eDepartamento0;
        private System.Windows.Forms.Label accion;
        private System.Windows.Forms.TextBox eBuscador1;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Label eBuscador0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox eCosto;
        private System.Windows.Forms.Label e3;
        private System.Windows.Forms.TextBox eNombre;
        private System.Windows.Forms.TextBox eCargo;
        private System.Windows.Forms.Label e5;
        private System.Windows.Forms.TextBox eApellido;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Label e7;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.Label e6;
        private System.Windows.Forms.DomainUpDown eDepartamento;
        private System.Windows.Forms.Panel Guardar;
        private System.Windows.Forms.DomainUpDown Opciones;
        private System.Windows.Forms.TextBox eCedula;
        private System.Windows.Forms.Label e4;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.CheckBox check7;
        private System.Windows.Forms.CheckBox check6;
        private System.Windows.Forms.CheckBox check5;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.Label eError;
        private System.Windows.Forms.CheckBox check8;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    }
}