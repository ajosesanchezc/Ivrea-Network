namespace WindowsFormsApplication3
{
    partial class MODIFICAR
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
            this.eModificador2 = new System.Windows.Forms.Label();
            this.eModificador = new System.Windows.Forms.TextBox();
            this.eCancelar = new System.Windows.Forms.Button();
            this.eAceptar = new System.Windows.Forms.Button();
            this.eOpciones2 = new System.Windows.Forms.Label();
            this.eGuardar = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eTitulo = new System.Windows.Forms.Label();
            this.eOpciones = new System.Windows.Forms.DomainUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.eError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eModificador2
            // 
            this.eModificador2.AutoSize = true;
            this.eModificador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.eModificador2.Location = new System.Drawing.Point(34, 42);
            this.eModificador2.Name = "eModificador2";
            this.eModificador2.Size = new System.Drawing.Size(59, 16);
            this.eModificador2.TabIndex = 1;
            this.eModificador2.Text = "Campo2";
            // 
            // eModificador
            // 
            this.eModificador.Location = new System.Drawing.Point(130, 38);
            this.eModificador.Name = "eModificador";
            this.eModificador.Size = new System.Drawing.Size(284, 20);
            this.eModificador.TabIndex = 28;
            // 
            // eCancelar
            // 
            this.eCancelar.Location = new System.Drawing.Point(316, 439);
            this.eCancelar.Name = "eCancelar";
            this.eCancelar.Size = new System.Drawing.Size(101, 23);
            this.eCancelar.TabIndex = 30;
            this.eCancelar.Text = "Cancelar";
            this.eCancelar.UseVisualStyleBackColor = true;
            this.eCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // eAceptar
            // 
            this.eAceptar.Location = new System.Drawing.Point(192, 439);
            this.eAceptar.Name = "eAceptar";
            this.eAceptar.Size = new System.Drawing.Size(118, 23);
            this.eAceptar.TabIndex = 29;
            this.eAceptar.Text = "Aceptar";
            this.eAceptar.UseVisualStyleBackColor = true;
            this.eAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // eOpciones2
            // 
            this.eOpciones2.AutoSize = true;
            this.eOpciones2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eOpciones2.Location = new System.Drawing.Point(34, 16);
            this.eOpciones2.Name = "eOpciones2";
            this.eOpciones2.Size = new System.Drawing.Size(74, 16);
            this.eOpciones2.TabIndex = 39;
            this.eOpciones2.Text = "Opcion(es)";
            // 
            // eGuardar
            // 
            this.eGuardar.Location = new System.Drawing.Point(37, 100);
            this.eGuardar.Name = "eGuardar";
            this.eGuardar.Size = new System.Drawing.Size(126, 23);
            this.eGuardar.TabIndex = 42;
            this.eGuardar.Text = "Guardar";
            this.eGuardar.UseVisualStyleBackColor = true;
            this.eGuardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(65, 322);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(486, 49);
            this.tabla.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Resultados";
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1.Location = new System.Drawing.Point(34, 68);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(46, 16);
            this.f1.TabIndex = 79;
            this.f1.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 94;
            this.label3.Text = "Campos";
            // 
            // eTitulo
            // 
            this.eTitulo.AutoSize = true;
            this.eTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eTitulo.Location = new System.Drawing.Point(58, 47);
            this.eTitulo.Name = "eTitulo";
            this.eTitulo.Size = new System.Drawing.Size(49, 20);
            this.eTitulo.TabIndex = 95;
            this.eTitulo.Text = "titulo";
            // 
            // eOpciones
            // 
            this.eOpciones.InterceptArrowKeys = false;
            this.eOpciones.Location = new System.Drawing.Point(129, 12);
            this.eOpciones.Name = "eOpciones";
            this.eOpciones.ReadOnly = true;
            this.eOpciones.Size = new System.Drawing.Size(285, 20);
            this.eOpciones.TabIndex = 96;
            this.eOpciones.Text = "Cedula";
            this.eOpciones.SelectedItemChanged += new System.EventHandler(this.eOpciones_SelectedItemChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fecha1);
            this.panel1.Controls.Add(this.eOpciones);
            this.panel1.Controls.Add(this.f1);
            this.panel1.Controls.Add(this.eGuardar);
            this.panel1.Controls.Add(this.eOpciones2);
            this.panel1.Controls.Add(this.eModificador);
            this.panel1.Controls.Add(this.eModificador2);
            this.panel1.Location = new System.Drawing.Point(62, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 157);
            this.panel1.TabIndex = 97;
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(130, 64);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(284, 20);
            this.fecha1.TabIndex = 99;
            // 
            // eError
            // 
            this.eError.AutoSize = true;
            this.eError.Location = new System.Drawing.Point(70, 409);
            this.eError.Name = "eError";
            this.eError.Size = new System.Drawing.Size(484, 13);
            this.eError.TabIndex = 98;
            this.eError.Text = "                                                                                 " +
                "                                                                              ";
            // 
            // MODIFICAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 474);
            this.Controls.Add(this.eError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.eCancelar);
            this.Controls.Add(this.eAceptar);
            this.Name = "MODIFICAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarRRH";
            this.Load += new System.EventHandler(this.ModificarRRH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eModificador2;
        private System.Windows.Forms.TextBox eModificador;
        private System.Windows.Forms.Button eCancelar;
        private System.Windows.Forms.Button eAceptar;
        private System.Windows.Forms.Label eOpciones2;
        private System.Windows.Forms.Button eGuardar;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label f1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label eTitulo;
        private System.Windows.Forms.DomainUpDown eOpciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label eError;
        private System.Windows.Forms.DateTimePicker fecha1;

    }
}