namespace Interfaz
{
    partial class AgregarCupon
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombreCupon = new System.Windows.Forms.TextBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.cbTipoCupon = new System.Windows.Forms.ComboBox();
            this.txtCantidadCupon = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescuento2 = new System.Windows.Forms.NumericUpDown();
            this.txtDescuento1 = new System.Windows.Forms.NumericUpDown();
            this.lbDescuento = new System.Windows.Forms.Label();
            this.btnAgregarCupon = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadCupon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(27, 25);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(65, 20);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // txtNombreCupon
            // 
            this.txtNombreCupon.Location = new System.Drawing.Point(297, 25);
            this.txtNombreCupon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreCupon.Name = "txtNombreCupon";
            this.txtNombreCupon.Size = new System.Drawing.Size(136, 26);
            this.txtNombreCupon.TabIndex = 1;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(27, 120);
            this.lbTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(39, 20);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(27, 72);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(73, 20);
            this.lbCantidad.TabIndex = 3;
            this.lbCantidad.Text = "Cantidad";
            // 
            // cbTipoCupon
            // 
            this.cbTipoCupon.FormattingEnabled = true;
            this.cbTipoCupon.Location = new System.Drawing.Point(297, 120);
            this.cbTipoCupon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTipoCupon.Name = "cbTipoCupon";
            this.cbTipoCupon.Size = new System.Drawing.Size(136, 28);
            this.cbTipoCupon.TabIndex = 4;
            this.cbTipoCupon.SelectedIndexChanged += new System.EventHandler(this.EventoCambioDeTipo);
            // 
            // txtCantidadCupon
            // 
            this.txtCantidadCupon.Location = new System.Drawing.Point(297, 72);
            this.txtCantidadCupon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadCupon.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidadCupon.Name = "txtCantidadCupon";
            this.txtCantidadCupon.Size = new System.Drawing.Size(138, 26);
            this.txtCantidadCupon.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Controls.Add(this.txtDescuento2);
            this.panel1.Controls.Add(this.txtDescuento1);
            this.panel1.Controls.Add(this.lbDescuento);
            this.panel1.Controls.Add(this.btnAgregarCupon);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.cbTipoCupon);
            this.panel1.Controls.Add(this.txtCantidadCupon);
            this.panel1.Controls.Add(this.lbTipo);
            this.panel1.Controls.Add(this.txtNombreCupon);
            this.panel1.Controls.Add(this.lbCantidad);
            this.panel1.Location = new System.Drawing.Point(540, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 331);
            this.panel1.TabIndex = 6;
            // 
            // txtDescuento2
            // 
            this.txtDescuento2.Location = new System.Drawing.Point(520, 172);
            this.txtDescuento2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescuento2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtDescuento2.Name = "txtDescuento2";
            this.txtDescuento2.Size = new System.Drawing.Size(138, 26);
            this.txtDescuento2.TabIndex = 9;
            // 
            // txtDescuento1
            // 
            this.txtDescuento1.Location = new System.Drawing.Point(297, 172);
            this.txtDescuento1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescuento1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtDescuento1.Name = "txtDescuento1";
            this.txtDescuento1.Size = new System.Drawing.Size(138, 26);
            this.txtDescuento1.TabIndex = 8;
            // 
            // lbDescuento
            // 
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Location = new System.Drawing.Point(27, 172);
            this.lbDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(87, 20);
            this.lbDescuento.TabIndex = 7;
            this.lbDescuento.Text = "Descuento";
            // 
            // btnAgregarCupon
            // 
            this.btnAgregarCupon.Location = new System.Drawing.Point(32, 268);
            this.btnAgregarCupon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarCupon.Name = "btnAgregarCupon";
            this.btnAgregarCupon.Size = new System.Drawing.Size(405, 40);
            this.btnAgregarCupon.TabIndex = 6;
            this.btnAgregarCupon.Text = "Agregar Cupon";
            this.btnAgregarCupon.UseVisualStyleBackColor = true;
            this.btnAgregarCupon.Click += new System.EventHandler(this.BtnAgregarCupon);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(466, 175);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "X";
            // 
            // AgregarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgregarCupon";
            this.Size = new System.Drawing.Size(1536, 592);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadCupon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombreCupon;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.ComboBox cbTipoCupon;
        private System.Windows.Forms.NumericUpDown txtCantidadCupon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarCupon;
        private System.Windows.Forms.NumericUpDown txtDescuento1;
        private System.Windows.Forms.Label lbDescuento;
        private System.Windows.Forms.NumericUpDown txtDescuento2;
        private System.Windows.Forms.Label lblX;
    }
}
