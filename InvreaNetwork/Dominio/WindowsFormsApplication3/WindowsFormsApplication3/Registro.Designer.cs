namespace WindowsFormsApplication3
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.eDepartamento = new System.Windows.Forms.DomainUpDown();
            this.eLogin = new System.Windows.Forms.TextBox();
            this.ePassword = new System.Windows.Forms.TextBox();
            this.e1 = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.avisos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eDepartamento
            // 
            this.eDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDepartamento.InterceptArrowKeys = false;
            this.eDepartamento.Items.Add("Administracion de Inventarios");
            this.eDepartamento.Items.Add("Gestion de Proyectos");
            this.eDepartamento.Items.Add("Recursos Humanos");
            this.eDepartamento.Location = new System.Drawing.Point(318, 312);
            this.eDepartamento.Name = "eDepartamento";
            this.eDepartamento.ReadOnly = true;
            this.eDepartamento.Size = new System.Drawing.Size(282, 24);
            this.eDepartamento.TabIndex = 74;
            this.eDepartamento.Text = "Administracion de Inventarios";
            // 
            // eLogin
            // 
            this.eLogin.Location = new System.Drawing.Point(318, 159);
            this.eLogin.Name = "eLogin";
            this.eLogin.Size = new System.Drawing.Size(250, 20);
            this.eLogin.TabIndex = 75;
            // 
            // ePassword
            // 
            this.ePassword.Location = new System.Drawing.Point(318, 234);
            this.ePassword.Name = "ePassword";
            this.ePassword.Size = new System.Drawing.Size(250, 20);
            this.ePassword.TabIndex = 76;
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1.Location = new System.Drawing.Point(127, 153);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(65, 25);
            this.e1.TabIndex = 77;
            this.e1.Text = "Login";
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2.Location = new System.Drawing.Point(127, 232);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(106, 25);
            this.e2.TabIndex = 78;
            this.e2.Text = "Password";
            this.e2.Click += new System.EventHandler(this.e2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(436, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 80;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 79;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // avisos
            // 
            this.avisos.AutoSize = true;
            this.avisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisos.ForeColor = System.Drawing.Color.Red;
            this.avisos.Location = new System.Drawing.Point(144, 378);
            this.avisos.Name = "avisos";
            this.avisos.Size = new System.Drawing.Size(70, 20);
            this.avisos.TabIndex = 93;
            this.avisos.Text = "AVISOS";
            this.avisos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 94;
            this.label1.Text = "Departamento";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avisos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.ePassword);
            this.Controls.Add(this.eLogin);
            this.Controls.Add(this.eDepartamento);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown eDepartamento;
        private System.Windows.Forms.TextBox eLogin;
        private System.Windows.Forms.TextBox ePassword;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label avisos;
        private System.Windows.Forms.Label label1;
    }
}