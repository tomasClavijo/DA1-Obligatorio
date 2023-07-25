using System.Windows.Forms;

namespace Interfaz
{
    partial class VisualizarEventos
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
            this.btnComprarEvento = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbCategoriaFiltrar = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.EstadoCupon = new System.Windows.Forms.Label();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComprarEvento
            // 
            this.btnComprarEvento.Location = new System.Drawing.Point(378, 354);
            this.btnComprarEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComprarEvento.Name = "btnComprarEvento";
            this.btnComprarEvento.Size = new System.Drawing.Size(270, 26);
            this.btnComprarEvento.TabIndex = 2;
            this.btnComprarEvento.Text = "Comprar";
            this.btnComprarEvento.UseVisualStyleBackColor = true;
            this.btnComprarEvento.Click += new System.EventHandler(this.BtnComprarEventoClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.Categoria,
            this.Formato,
            this.Direccion,
            this.Imagen});
            this.dataGridView1.Location = new System.Drawing.Point(2, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 8;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Formato
            // 
            this.Formato.HeaderText = "Formato";
            this.Formato.MinimumWidth = 8;
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 8;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagen.MinimumWidth = 8;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Width = 266;
            // 
            // cbCategoriaFiltrar
            // 
            this.cbCategoriaFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaFiltrar.FormattingEnabled = true;
            this.cbCategoriaFiltrar.Location = new System.Drawing.Point(156, 14);
            this.cbCategoriaFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategoriaFiltrar.Name = "cbCategoriaFiltrar";
            this.cbCategoriaFiltrar.Size = new System.Drawing.Size(111, 21);
            this.cbCategoriaFiltrar.TabIndex = 62;
            this.cbCategoriaFiltrar.SelectionChangeCommitted += new System.EventHandler(this.CambioSeleccionCategoria);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(13, 14);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(99, 13);
            this.lbCategoria.TabIndex = 63;
            this.lbCategoria.Text = "Filtrar por categoría";
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(494, 15);
            this.txtNombreEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(111, 20);
            this.txtNombreEvento.TabIndex = 64;
            this.txtNombreEvento.TextChanged += new System.EventHandler(this.CambioSeleccionNombre);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(314, 15);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(88, 13);
            this.lbNombre.TabIndex = 65;
            this.lbNombre.Text = "Filtrar por nombre";
            // 
            // EstadoCupon
            // 
            this.EstadoCupon.AutoSize = true;
            this.EstadoCupon.Location = new System.Drawing.Point(700, 46);
            this.EstadoCupon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EstadoCupon.Name = "EstadoCupon";
            this.EstadoCupon.Size = new System.Drawing.Size(57, 13);
            this.EstadoCupon.TabIndex = 77;
            this.EstadoCupon.Text = "Fecha Fin:";
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(700, 15);
            this.lbFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lbFechaInicio.TabIndex = 76;
            this.lbFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtFin
            // 
            this.dtFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFin.Location = new System.Drawing.Point(779, 46);
            this.dtFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(154, 20);
            this.dtFin.TabIndex = 75;
            this.dtFin.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtFin.ValueChanged += new System.EventHandler(this.CambioSeleccionFechaFin);
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(779, 15);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(154, 20);
            this.dtInicio.TabIndex = 74;
            this.dtInicio.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtInicio.ValueChanged += new System.EventHandler(this.CambioSeleccionFechaInicio);
            // 
            // VisualizarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EstadoCupon);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.txtNombreEvento);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.cbCategoriaFiltrar);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnComprarEvento);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VisualizarEventos";
            this.Size = new System.Drawing.Size(1024, 385);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnComprarEvento;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Formato;
        private DataGridViewImageColumn Imagen;
        private DataGridViewButtonColumn Comprar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem eventosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem stripMenuCategoria;
        private ComboBox cbFormato;
        private Label lbCategoria;
        private ComboBox cbCategoriaFiltrar;
        private DataGridViewTextBoxColumn Direccion;
        private TextBox txtNombreEvento;
        private Label lbNombre;
        private Label EstadoCupon;
        private Label lbFechaInicio;
        private DateTimePicker dtFin;
        private DateTimePicker dtInicio;
    }
}
