using System.Windows.Forms;

namespace Interfaz
{
    partial class VisualizarEventosBorrador
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
            this.dgvEventosBorrador = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosBorrador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventosBorrador
            // 
            this.dgvEventosBorrador.AllowUserToAddRows = false;
            this.dgvEventosBorrador.AllowUserToDeleteRows = false;
            this.dgvEventosBorrador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventosBorrador.ColumnHeadersHeight = 34;
            this.dgvEventosBorrador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.Categoria,
            this.Formato,
            this.Direccion,
            this.Imagen});
            this.dgvEventosBorrador.Location = new System.Drawing.Point(3, 110);
            this.dgvEventosBorrador.MultiSelect = false;
            this.dgvEventosBorrador.Name = "dgvEventosBorrador";
            this.dgvEventosBorrador.ReadOnly = true;
            this.dgvEventosBorrador.RowHeadersWidth = 62;
            this.dgvEventosBorrador.RowTemplate.Height = 33;
            this.dgvEventosBorrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventosBorrador.Size = new System.Drawing.Size(1700, 520);
            this.dgvEventosBorrador.TabIndex = 1;
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
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(431, 672);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(112, 34);
            this.btnPublicar.TabIndex = 2;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.BtnPublicarEventoClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(753, 672);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 34);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificarEventoClick);
            // 
            // VisualizarEventosBorrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.dgvEventosBorrador);
            this.Name = "VisualizarEventosBorrador";
            this.Size = new System.Drawing.Size(1706, 740);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosBorrador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvEventosBorrador;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Formato;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewImageColumn Imagen;
        private Button btnPublicar;
        private Button btnModificar;
    }
}
