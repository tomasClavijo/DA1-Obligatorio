using System.Windows.Forms;

namespace Interfaz
{
    partial class VisualizarFunciones
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
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSeleccionarFuncion = new System.Windows.Forms.Label();
            this.lbTicketsDisponibles = new System.Windows.Forms.Label();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketsComprar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComprarTickets = new System.Windows.Forms.Button();
            this.numCantidadComprar = new System.Windows.Forms.NumericUpDown();
            this.lbCantidadComprar = new System.Windows.Forms.Label();
            this.estadoCupon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CedulaAsistente = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.apellidoAsistente = new System.Windows.Forms.Label();
            this.NombreAsistente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadComprar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFunciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFunciones.ColumnHeadersHeight = 34;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaInicio,
            this.FechaFin});
            this.dgvFunciones.Location = new System.Drawing.Point(241, 1);
            this.dgvFunciones.Margin = new System.Windows.Forms.Padding(1);
            this.dgvFunciones.MultiSelect = false;
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowHeadersWidth = 62;
            this.dgvFunciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFunciones.RowTemplate.Height = 33;
            this.dgvFunciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunciones.Size = new System.Drawing.Size(457, 117);
            this.dgvFunciones.TabIndex = 0;
            this.dgvFunciones.SelectionChanged += new System.EventHandler(this.SeleccionarFuncion);
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.MinimumWidth = 8;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.MinimumWidth = 8;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // lbSeleccionarFuncion
            // 
            this.lbSeleccionarFuncion.AutoSize = true;
            this.lbSeleccionarFuncion.Location = new System.Drawing.Point(117, 19);
            this.lbSeleccionarFuncion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbSeleccionarFuncion.Name = "lbSeleccionarFuncion";
            this.lbSeleccionarFuncion.Size = new System.Drawing.Size(101, 13);
            this.lbSeleccionarFuncion.TabIndex = 1;
            this.lbSeleccionarFuncion.Text = "Seleccionar función";
            // 
            // lbTicketsDisponibles
            // 
            this.lbTicketsDisponibles.AutoSize = true;
            this.lbTicketsDisponibles.Location = new System.Drawing.Point(117, 154);
            this.lbTicketsDisponibles.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbTicketsDisponibles.Name = "lbTicketsDisponibles";
            this.lbTicketsDisponibles.Size = new System.Drawing.Size(97, 13);
            this.lbTicketsDisponibles.TabIndex = 2;
            this.lbTicketsDisponibles.Text = "Tickets disponibles";
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTickets.ColumnHeadersHeight = 34;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.TicketsComprar});
            this.dgvTickets.Location = new System.Drawing.Point(241, 139);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(1);
            this.dgvTickets.MultiSelect = false;
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowHeadersWidth = 62;
            this.dgvTickets.RowTemplate.Height = 33;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(457, 109);
            this.dgvTickets.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad disponible";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // TicketsComprar
            // 
            this.TicketsComprar.HeaderText = "Tickets a comprar";
            this.TicketsComprar.MinimumWidth = 8;
            this.TicketsComprar.Name = "TicketsComprar";
            this.TicketsComprar.ReadOnly = true;
            // 
            // btnComprarTickets
            // 
            this.btnComprarTickets.Location = new System.Drawing.Point(391, 310);
            this.btnComprarTickets.Margin = new System.Windows.Forms.Padding(1);
            this.btnComprarTickets.Name = "btnComprarTickets";
            this.btnComprarTickets.Size = new System.Drawing.Size(155, 26);
            this.btnComprarTickets.TabIndex = 4;
            this.btnComprarTickets.Text = "Comprar tickets";
            this.btnComprarTickets.UseVisualStyleBackColor = true;
            this.btnComprarTickets.Click += new System.EventHandler(this.BtnComprarTickets_Click);
            // 
            // numCantidadComprar
            // 
            this.numCantidadComprar.Location = new System.Drawing.Point(424, 273);
            this.numCantidadComprar.Margin = new System.Windows.Forms.Padding(2);
            this.numCantidadComprar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCantidadComprar.Name = "numCantidadComprar";
            this.numCantidadComprar.Size = new System.Drawing.Size(72, 20);
            this.numCantidadComprar.TabIndex = 5;
            this.numCantidadComprar.ValueChanged += new System.EventHandler(this.CambioValorCantidadComprar);
            // 
            // lbCantidadComprar
            // 
            this.lbCantidadComprar.AutoSize = true;
            this.lbCantidadComprar.Location = new System.Drawing.Point(409, 258);
            this.lbCantidadComprar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbCantidadComprar.Name = "lbCantidadComprar";
            this.lbCantidadComprar.Size = new System.Drawing.Size(102, 13);
            this.lbCantidadComprar.TabIndex = 6;
            this.lbCantidadComprar.Text = "Cantidad a comprar:";
            // 
            // estadoCupon
            // 
            this.estadoCupon.AutoSize = true;
            this.estadoCupon.Location = new System.Drawing.Point(848, 122);
            this.estadoCupon.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.estadoCupon.Name = "estadoCupon";
            this.estadoCupon.Size = new System.Drawing.Size(75, 13);
            this.estadoCupon.TabIndex = 7;
            this.estadoCupon.Text = "NombreCupon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(834, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Datos asistente";
            // 
            // CedulaAsistente
            // 
            this.CedulaAsistente.AutoSize = true;
            this.CedulaAsistente.Location = new System.Drawing.Point(880, 95);
            this.CedulaAsistente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CedulaAsistente.Name = "CedulaAsistente";
            this.CedulaAsistente.Size = new System.Drawing.Size(58, 13);
            this.CedulaAsistente.TabIndex = 19;
            this.CedulaAsistente.Text = "unaCedula";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(834, 48);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 16;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(834, 73);
            this.lbApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(47, 13);
            this.lbApellido.TabIndex = 17;
            this.lbApellido.Text = "Apellido:";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Location = new System.Drawing.Point(832, 95);
            this.lbCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(43, 13);
            this.lbCedula.TabIndex = 18;
            this.lbCedula.Text = "Cédula:";
            // 
            // apellidoAsistente
            // 
            this.apellidoAsistente.AutoSize = true;
            this.apellidoAsistente.Location = new System.Drawing.Point(882, 73);
            this.apellidoAsistente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apellidoAsistente.Name = "apellidoAsistente";
            this.apellidoAsistente.Size = new System.Drawing.Size(56, 13);
            this.apellidoAsistente.TabIndex = 20;
            this.apellidoAsistente.Text = "unApellido";
            // 
            // NombreAsistente
            // 
            this.NombreAsistente.AutoSize = true;
            this.NombreAsistente.Location = new System.Drawing.Point(882, 48);
            this.NombreAsistente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombreAsistente.Name = "NombreAsistente";
            this.NombreAsistente.Size = new System.Drawing.Size(56, 13);
            this.NombreAsistente.TabIndex = 21;
            this.NombreAsistente.Text = "unNombre";
            // 
            // VisualizarFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NombreAsistente);
            this.Controls.Add(this.apellidoAsistente);
            this.Controls.Add(this.CedulaAsistente);
            this.Controls.Add(this.estadoCupon);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCantidadComprar);
            this.Controls.Add(this.numCantidadComprar);
            this.Controls.Add(this.btnComprarTickets);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.lbTicketsDisponibles);
            this.Controls.Add(this.lbSeleccionarFuncion);
            this.Controls.Add(this.dgvFunciones);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "VisualizarFunciones";
            this.Size = new System.Drawing.Size(1024, 385);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadComprar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvFunciones;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private Label lbSeleccionarFuncion;
        private Label lbTicketsDisponibles;
        private DataGridView dgvTickets;
        private Button btnComprarTickets;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn TicketsComprar;
        private NumericUpDown numCantidadComprar;
        private Label lbCantidadComprar;
        private Label estadoCupon;
        private Label label1;
        private Label CedulaAsistente;
        private Label lbNombre;
        private Label lbApellido;
        private Label lbCedula;
        private Label apellidoAsistente;
        private Label NombreAsistente;
    }
}
