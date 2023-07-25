using System.Windows.Forms;

namespace Interfaz
{
    partial class AgregarProductor
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
            this.btnAgregarProductor = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarProductor
            // 
            this.btnAgregarProductor.Location = new System.Drawing.Point(30, 270);
            this.btnAgregarProductor.Name = "btnAgregarProductor";
            this.btnAgregarProductor.Size = new System.Drawing.Size(450, 50);
            this.btnAgregarProductor.TabIndex = 0;
            this.btnAgregarProductor.Text = "Agregar Productor";
            this.btnAgregarProductor.UseVisualStyleBackColor = true;
            this.btnAgregarProductor.Click += new System.EventHandler(this.BtnAgregarProductorClick);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(30, 30);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(78, 25);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(30, 90);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(78, 25);
            this.lbApellido.TabIndex = 2;
            this.lbApellido.Text = "Apellido";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(30, 150);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(157, 25);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Correo electrónico";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(30, 210);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(101, 25);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(330, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 31);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(330, 90);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 31);
            this.txtApellido.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(330, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 31);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(330, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 31);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.btnAgregarProductor);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.lbApellido);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Location = new System.Drawing.Point(605, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 373);
            this.panel1.TabIndex = 10;
            // 
            // AgregarProductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AgregarProductor";
            this.Size = new System.Drawing.Size(1706, 740);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAgregarProductor;
        private Label lbNombre;
        private Label lbApellido;
        private Label lbEmail;
        private Label lbPassword;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Panel panel1;
    }
}
