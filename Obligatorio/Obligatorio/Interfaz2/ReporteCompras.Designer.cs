
namespace Interfaz
{
    partial class ReporteCompras
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
            this.lbCategoria = new System.Windows.Forms.Label();
            this.numMontoFiltrar = new System.Windows.Forms.NumericUpDown();
            this.txtCIUsuario = new System.Windows.Forms.TextBox();
            this.btnFiltrarCompras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.NombreYApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numMontoFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(472, 29);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(129, 20);
            this.lbNombre.TabIndex = 81;
            this.lbNombre.Text = "Filtrar por monto:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(19, 29);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(131, 20);
            this.lbCategoria.TabIndex = 79;
            this.lbCategoria.Text = "Filtrar por cédula:";
            // 
            // numMontoFiltrar
            // 
            this.numMontoFiltrar.Location = new System.Drawing.Point(617, 27);
            this.numMontoFiltrar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMontoFiltrar.Name = "numMontoFiltrar";
            this.numMontoFiltrar.Size = new System.Drawing.Size(165, 26);
            this.numMontoFiltrar.TabIndex = 86;
            // 
            // txtCIUsuario
            // 
            this.txtCIUsuario.Location = new System.Drawing.Point(171, 26);
            this.txtCIUsuario.Name = "txtCIUsuario";
            this.txtCIUsuario.Size = new System.Drawing.Size(165, 26);
            this.txtCIUsuario.TabIndex = 87;
            // 
            // btnFiltrarCompras
            // 
            this.btnFiltrarCompras.Location = new System.Drawing.Point(567, 545);
            this.btnFiltrarCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrarCompras.Name = "btnFiltrarCompras";
            this.btnFiltrarCompras.Size = new System.Drawing.Size(405, 40);
            this.btnFiltrarCompras.TabIndex = 88;
            this.btnFiltrarCompras.Text = "Filtrar";
            this.btnFiltrarCompras.UseVisualStyleBackColor = true;
            this.btnFiltrarCompras.Click += new System.EventHandler(this.BtnFiltrarCompras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1050, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Fecha Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1050, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Fecha Inicio:";
            // 
            // dateFin
            // 
            this.dateFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFin.Location = new System.Drawing.Point(1169, 65);
            this.dateFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(229, 26);
            this.dateFin.TabIndex = 96;
            this.dateFin.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // dateInicio
            // 
            this.dateInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicio.Location = new System.Drawing.Point(1169, 17);
            this.dateInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(229, 26);
            this.dateInicio.TabIndex = 95;
            this.dateInicio.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvCompras.ColumnHeadersHeight = 34;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreYApellido,
            this.Cedula,
            this.Codigos,
            this.MontoTotal});
            this.dgvCompras.Location = new System.Drawing.Point(3, 110);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompras.MultiSelect = false;
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersWidth = 62;
            this.dgvCompras.RowTemplate.Height = 33;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(1530, 416);
            this.dgvCompras.TabIndex = 1;
            // 
            // NombreYApellido
            // 
            this.NombreYApellido.HeaderText = "Nombre y Apellido";
            this.NombreYApellido.MinimumWidth = 8;
            this.NombreYApellido.Name = "NombreYApellido";
            this.NombreYApellido.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.MinimumWidth = 8;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Codigos
            // 
            this.Codigos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigos.FillWeight = 500F;
            this.Codigos.HeaderText = "Códigos";
            this.Codigos.MinimumWidth = 8;
            this.Codigos.Name = "Codigos";
            this.Codigos.ReadOnly = true;
            this.Codigos.Width = 103;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 8;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // ReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.btnFiltrarCompras);
            this.Controls.Add(this.txtCIUsuario);
            this.Controls.Add(this.numMontoFiltrar);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.dgvCompras);
            this.Name = "ReporteCompras";
            this.Size = new System.Drawing.Size(2303, 888);
            ((System.ComponentModel.ISupportInitialize)(this.numMontoFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.NumericUpDown numMontoFiltrar;
        private System.Windows.Forms.TextBox txtCIUsuario;
        private System.Windows.Forms.Button btnFiltrarCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreYApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigos;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
    }
}
