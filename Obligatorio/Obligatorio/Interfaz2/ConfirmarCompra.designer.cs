using System.Windows.Forms;

namespace Interfaz
{
    partial class ConfirmarCompra
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
            this.txtBoxCompra = new System.Windows.Forms.RichTextBox();
            this.btnConfirmarCompa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxCompra
            // 
            this.txtBoxCompra.Location = new System.Drawing.Point(556, 56);
            this.txtBoxCompra.Name = "txtBoxCompra";
            this.txtBoxCompra.ReadOnly = true;
            this.txtBoxCompra.Size = new System.Drawing.Size(394, 382);
            this.txtBoxCompra.TabIndex = 1;
            this.txtBoxCompra.Text = "";
            // 
            // btnConfirmarCompa
            // 
            this.btnConfirmarCompa.Location = new System.Drawing.Point(556, 486);
            this.btnConfirmarCompa.Name = "btnConfirmarCompa";
            this.btnConfirmarCompa.Size = new System.Drawing.Size(394, 40);
            this.btnConfirmarCompa.TabIndex = 2;
            this.btnConfirmarCompa.Text = "Confirmar Compra";
            this.btnConfirmarCompa.UseVisualStyleBackColor = true;
            this.btnConfirmarCompa.Click += new System.EventHandler(this.BtnConfirmarCompaClick);
            // 
            // ConfirmarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfirmarCompa);
            this.Controls.Add(this.txtBoxCompra);
            this.Name = "ConfirmarCompra";
            this.Size = new System.Drawing.Size(1536, 592);
            this.ResumeLayout(false);

        }

        #endregion
        private RichTextBox txtBoxCompra;
        private Button btnConfirmarCompa;
    }
}
