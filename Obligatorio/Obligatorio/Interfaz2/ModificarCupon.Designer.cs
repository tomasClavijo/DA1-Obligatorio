namespace Interfaz
{
    partial class ModificarCupon
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
            this.txtNombreCupon = new System.Windows.Forms.TextBox();
            this.lbNombreCupon = new System.Windows.Forms.Label();
            this.lbCantidadCupon = new System.Windows.Forms.Label();
            this.numCantidadCupon = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listCupones = new System.Windows.Forms.ListBox();
            this.lbCupones = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModificarCupon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCupon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreCupon
            // 
            this.txtNombreCupon.Location = new System.Drawing.Point(193, 29);
            this.txtNombreCupon.Name = "txtNombreCupon";
            this.txtNombreCupon.Size = new System.Drawing.Size(92, 20);
            this.txtNombreCupon.TabIndex = 0;
            // 
            // lbNombreCupon
            // 
            this.lbNombreCupon.AutoSize = true;
            this.lbNombreCupon.Location = new System.Drawing.Point(12, 29);
            this.lbNombreCupon.Name = "lbNombreCupon";
            this.lbNombreCupon.Size = new System.Drawing.Size(44, 13);
            this.lbNombreCupon.TabIndex = 1;
            this.lbNombreCupon.Text = "Nombre";
            // 
            // lbCantidadCupon
            // 
            this.lbCantidadCupon.AutoSize = true;
            this.lbCantidadCupon.Location = new System.Drawing.Point(12, 28);
            this.lbCantidadCupon.Name = "lbCantidadCupon";
            this.lbCantidadCupon.Size = new System.Drawing.Size(49, 13);
            this.lbCantidadCupon.TabIndex = 2;
            this.lbCantidadCupon.Text = "Cantidad";
            // 
            // numCantidadCupon
            // 
            this.numCantidadCupon.Location = new System.Drawing.Point(193, 21);
            this.numCantidadCupon.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCantidadCupon.Name = "numCantidadCupon";
            this.numCantidadCupon.Size = new System.Drawing.Size(92, 20);
            this.numCantidadCupon.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNombreCupon);
            this.panel1.Controls.Add(this.txtNombreCupon);
            this.panel1.Location = new System.Drawing.Point(75, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 120);
            this.panel1.TabIndex = 5;
            // 
            // listCupones
            // 
            this.listCupones.FormattingEnabled = true;
            this.listCupones.Location = new System.Drawing.Point(568, 82);
            this.listCupones.Name = "listCupones";
            this.listCupones.Size = new System.Drawing.Size(307, 173);
            this.listCupones.TabIndex = 6;
            this.listCupones.SelectedIndexChanged += new System.EventHandler(this.EventoCuponSeleccionado);
            // 
            // lbCupones
            // 
            this.lbCupones.AutoSize = true;
            this.lbCupones.Location = new System.Drawing.Point(697, 56);
            this.lbCupones.Name = "lbCupones";
            this.lbCupones.Size = new System.Drawing.Size(49, 13);
            this.lbCupones.TabIndex = 7;
            this.lbCupones.Text = "Cupones";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCantidadCupon);
            this.panel2.Controls.Add(this.numCantidadCupon);
            this.panel2.Location = new System.Drawing.Point(75, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 120);
            this.panel2.TabIndex = 9;
            // 
            // btnModificarCupon
            // 
            this.btnModificarCupon.Location = new System.Drawing.Point(395, 344);
            this.btnModificarCupon.Name = "btnModificarCupon";
            this.btnModificarCupon.Size = new System.Drawing.Size(270, 26);
            this.btnModificarCupon.TabIndex = 9;
            this.btnModificarCupon.Text = "Modificad Cupon";
            this.btnModificarCupon.UseVisualStyleBackColor = true;
            this.btnModificarCupon.Click += new System.EventHandler(this.BtnModificarCupon_Click);
            // 
            // ModificarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificarCupon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbCupones);
            this.Controls.Add(this.listCupones);
            this.Controls.Add(this.panel1);
            this.Name = "ModificarCupon";
            this.Size = new System.Drawing.Size(1024, 385);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCupon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCupon;
        private System.Windows.Forms.Label lbNombreCupon;
        private System.Windows.Forms.Label lbCantidadCupon;
        private System.Windows.Forms.NumericUpDown numCantidadCupon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listCupones;
        private System.Windows.Forms.Label lbCupones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModificarCupon;
    }
}
