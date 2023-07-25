using System.Windows.Forms;

namespace Interfaz
{
    partial class ReporteEntradas
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
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.txtPrecioMaximo = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioMinimo = new System.Windows.Forms.NumericUpDown();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.listReporteEntradas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(599, 84);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(143, 25);
            this.lbDescripcion.TabIndex = 63;
            this.lbDescripcion.Text = "Rango de precio";
            // 
            // txtPrecioMaximo
            // 
            this.txtPrecioMaximo.Location = new System.Drawing.Point(980, 84);
            this.txtPrecioMaximo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtPrecioMaximo.Name = "txtPrecioMaximo";
            this.txtPrecioMaximo.Size = new System.Drawing.Size(180, 31);
            this.txtPrecioMaximo.TabIndex = 64;
            // 
            // txtPrecioMinimo
            // 
            this.txtPrecioMinimo.Location = new System.Drawing.Point(773, 84);
            this.txtPrecioMinimo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtPrecioMinimo.Name = "txtPrecioMinimo";
            this.txtPrecioMinimo.Size = new System.Drawing.Size(180, 31);
            this.txtPrecioMinimo.TabIndex = 67;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(599, 168);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(561, 50);
            this.btnGenerarReporte.TabIndex = 68;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporteClick);
            // 
            // listReporteEntradas
            // 
            this.listReporteEntradas.FormattingEnabled = true;
            this.listReporteEntradas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listReporteEntradas.ItemHeight = 25;
            this.listReporteEntradas.Location = new System.Drawing.Point(599, 266);
            this.listReporteEntradas.Name = "listReporteEntradas";
            this.listReporteEntradas.Size = new System.Drawing.Size(561, 204);
            this.listReporteEntradas.TabIndex = 69;
            // 
            // ReporteEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listReporteEntradas);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.txtPrecioMinimo);
            this.Controls.Add(this.txtPrecioMaximo);
            this.Controls.Add(this.lbDescripcion);
            this.Name = "ReporteEntradas";
            this.Size = new System.Drawing.Size(1706, 740);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioMinimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbDescripcion;
        private NumericUpDown txtPrecioMaximo;
        private NumericUpDown txtPrecioMinimo;
        private Button btnGenerarReporte;
        private ListBox listReporteEntradas;
    }
}
