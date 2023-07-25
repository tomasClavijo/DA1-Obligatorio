using System.Windows.Forms;

namespace Interfaz
{
    partial class IniciarSesion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAgregarProductor = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnAgregarProductor);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Location = new System.Drawing.Point(363, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 149);
            this.panel1.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(198, 47);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(92, 20);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAgregarProductor
            // 
            this.btnAgregarProductor.Location = new System.Drawing.Point(18, 78);
            this.btnAgregarProductor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarProductor.Name = "btnAgregarProductor";
            this.btnAgregarProductor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarProductor.Size = new System.Drawing.Size(270, 26);
            this.btnAgregarProductor.TabIndex = 9;
            this.btnAgregarProductor.Text = "Iniciar Sesión";
            this.btnAgregarProductor.UseVisualStyleBackColor = true;
            this.btnAgregarProductor.Click += new System.EventHandler(this.BtnIniciarSesionClick);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(18, 47);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 13);
            this.lbPassword.TabIndex = 11;
            this.lbPassword.Text = "Contraseña";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(198, 16);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(92, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(18, 16);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(93, 13);
            this.lbEmail.TabIndex = 10;
            this.lbEmail.Text = "Correo electrónico";
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IniciarSesion";
            this.Size = new System.Drawing.Size(1024, 385);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtPassword;
        private Button btnAgregarProductor;
        private Label lbPassword;
        private TextBox txtEmail;
        private Label lbEmail;
    }
}
