
namespace Interfaz
{
    partial class AplicarCupon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Continuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.codigoCupon = new System.Windows.Forms.TextBox();
            this.process1 = new System.Diagnostics.Process();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Continuar
            // 
            this.Continuar.Location = new System.Drawing.Point(433, 243);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(88, 35);
            this.Continuar.TabIndex = 0;
            this.Continuar.Text = "Continuar";
            this.Continuar.UseVisualStyleBackColor = true;
            this.Continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el codigo del cupon (si lo posee)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Cedula";
            // 
            // Cedula
            // 
            this.Cedula.Location = new System.Drawing.Point(359, 44);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(235, 20);
            this.Cedula.TabIndex = 4;
            // 
            // codigoCupon
            // 
            this.codigoCupon.Location = new System.Drawing.Point(359, 184);
            this.codigoCupon.Name = "codigoCupon";
            this.codigoCupon.Size = new System.Drawing.Size(235, 20);
            this.codigoCupon.TabIndex = 5;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(356, 119);
            this.lbApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 22;
            this.lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(356, 67);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 21;
            this.lbNombre.Text = "Nombre";
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Location = new System.Drawing.Point(359, 134);
            this.txtApellidoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(235, 20);
            this.txtApellidoUsuario.TabIndex = 20;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(359, 82);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(235, 20);
            this.txtNombreUsuario.TabIndex = 19;
            // 
            // AplicarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtApellidoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.codigoCupon);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Continuar);
            this.Name = "AplicarCupon";
            this.Size = new System.Drawing.Size(1024, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Continuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.TextBox codigoCupon;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
    }
}
