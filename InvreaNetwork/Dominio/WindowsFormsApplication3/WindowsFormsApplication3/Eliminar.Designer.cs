namespace WindowsFormsApplication3
{
    partial class Eliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.e1 = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            this.eLogin = new System.Windows.Forms.TextBox();
            this.ePassword = new System.Windows.Forms.TextBox();
            this.avisos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(446, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 34);
            this.button2.TabIndex = 64;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 63;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1.Location = new System.Drawing.Point(214, 212);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(65, 25);
            this.e1.TabIndex = 68;
            this.e1.Text = "Login";
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2.Location = new System.Drawing.Point(214, 256);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(106, 25);
            this.e2.TabIndex = 66;
            this.e2.Text = "Password";
            // 
            // eLogin
            // 
            this.eLogin.Location = new System.Drawing.Point(320, 212);
            this.eLogin.Name = "eLogin";
            this.eLogin.Size = new System.Drawing.Size(250, 20);
            this.eLogin.TabIndex = 67;
            // 
            // ePassword
            // 
            this.ePassword.Location = new System.Drawing.Point(320, 252);
            this.ePassword.Name = "ePassword";
            this.ePassword.Size = new System.Drawing.Size(250, 20);
            this.ePassword.TabIndex = 65;
            // 
            // avisos
            // 
            this.avisos.AutoSize = true;
            this.avisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisos.ForeColor = System.Drawing.Color.Red;
            this.avisos.Location = new System.Drawing.Point(214, 322);
            this.avisos.Name = "avisos";
            this.avisos.Size = new System.Drawing.Size(70, 20);
            this.avisos.TabIndex = 93;
            this.avisos.Text = "AVISOS";
            this.avisos.Visible = false;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(795, 608);
            this.Controls.Add(this.avisos);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.eLogin);
            this.Controls.Add(this.ePassword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.TextBox eLogin;
        private System.Windows.Forms.TextBox ePassword;
        private System.Windows.Forms.Label avisos;
    }
}