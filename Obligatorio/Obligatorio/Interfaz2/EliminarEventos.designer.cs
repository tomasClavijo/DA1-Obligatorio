using System.Windows.Forms;

namespace Interfaz
{
    partial class EliminarEventos
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
            this.dataEventos = new System.Windows.Forms.DataGridView();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEventos
            // 
            this.dataEventos.AllowUserToAddRows = false;
            this.dataEventos.AllowUserToDeleteRows = false;
            this.dataEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEventos.ColumnHeadersHeight = 34;
            this.dataEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.Categoria,
            this.Formato,
            this.Imagen});
            this.dataEventos.Location = new System.Drawing.Point(3, 50);
            this.dataEventos.MultiSelect = false;
            this.dataEventos.Name = "dataEventos";
            this.dataEventos.ReadOnly = true;
            this.dataEventos.RowHeadersWidth = 62;
            this.dataEventos.RowTemplate.Height = 33;
            this.dataEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEventos.Size = new System.Drawing.Size(1700, 520);
            this.dataEventos.TabIndex = 1;
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Location = new System.Drawing.Point(628, 625);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(450, 50);
            this.btnEliminarEvento.TabIndex = 3;
            this.btnEliminarEvento.Text = "Eliminar";
            this.btnEliminarEvento.UseVisualStyleBackColor = true;
            this.btnEliminarEvento.Click += new System.EventHandler(this.BtnEliminarEventoClick);
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
            // EliminarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminarEvento);
            this.Controls.Add(this.dataEventos);
            this.Name = "EliminarEventos";
            this.Size = new System.Drawing.Size(1706, 740);
            ((System.ComponentModel.ISupportInitialize)(this.dataEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataEventos;
        private Button btnEliminarEvento;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Formato;
        private DataGridViewImageColumn Imagen;
    }
}
