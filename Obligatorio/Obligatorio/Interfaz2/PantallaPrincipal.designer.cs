using System.Windows.Forms;

namespace Interfaz
{
    partial class PantallaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarProductor = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCrearEvento = new System.Windows.Forms.Button();
            this.btnVisualizarEventos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificarCupon = new System.Windows.Forms.Button();
            this.btnAgregarCupon = new System.Windows.Forms.Button();
            this.btnReporteCompras = new System.Windows.Forms.Button();
            this.btnModificarEvento = new System.Windows.Forms.Button();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.btnReporteEntradas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Location = new System.Drawing.Point(10, 78);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1962, 592);
            this.controlPanel.TabIndex = 0;
            // 
            // btnAgregarProductor
            // 
            this.btnAgregarProductor.Location = new System.Drawing.Point(1419, 2);
            this.btnAgregarProductor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProductor.Name = "btnAgregarProductor";
            this.btnAgregarProductor.Size = new System.Drawing.Size(176, 46);
            this.btnAgregarProductor.TabIndex = 1;
            this.btnAgregarProductor.Text = "Agregar Productor";
            this.btnAgregarProductor.UseVisualStyleBackColor = true;
            this.btnAgregarProductor.Click += new System.EventHandler(this.BtnAgregarProductorClick);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(6, 2);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(176, 46);
            this.btnIniciarSesion.TabIndex = 2;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion);
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.Location = new System.Drawing.Point(279, 2);
            this.btnCrearEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(176, 46);
            this.btnCrearEvento.TabIndex = 3;
            this.btnCrearEvento.Text = "Crear Evento";
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            this.btnCrearEvento.Click += new System.EventHandler(this.BtnCrearEventoClick);
            // 
            // btnVisualizarEventos
            // 
            this.btnVisualizarEventos.Location = new System.Drawing.Point(642, 2);
            this.btnVisualizarEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisualizarEventos.Name = "btnVisualizarEventos";
            this.btnVisualizarEventos.Size = new System.Drawing.Size(176, 46);
            this.btnVisualizarEventos.TabIndex = 4;
            this.btnVisualizarEventos.Text = "Visualizar eventos";
            this.btnVisualizarEventos.UseVisualStyleBackColor = true;
            this.btnVisualizarEventos.Click += new System.EventHandler(this.BtnVisualizarEventosClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModificarCupon);
            this.panel1.Controls.Add(this.btnAgregarCupon);
            this.panel1.Controls.Add(this.btnReporteCompras);
            this.panel1.Controls.Add(this.btnModificarEvento);
            this.panel1.Controls.Add(this.btnEliminarEvento);
            this.panel1.Controls.Add(this.btnReporteEntradas);
            this.panel1.Controls.Add(this.btnVisualizarEventos);
            this.panel1.Controls.Add(this.btnCrearEvento);
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.btnAgregarProductor);
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1962, 54);
            this.panel1.TabIndex = 5;
            // 
            // btnModificarCupon
            // 
            this.btnModificarCupon.Location = new System.Drawing.Point(1214, 2);
            this.btnModificarCupon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarCupon.Name = "btnModificarCupon";
            this.btnModificarCupon.Size = new System.Drawing.Size(176, 46);
            this.btnModificarCupon.TabIndex = 0;
            this.btnModificarCupon.Text = "Modificar Cupon";
            this.btnModificarCupon.UseVisualStyleBackColor = true;
            this.btnModificarCupon.Click += new System.EventHandler(this.BtnModificarCupon_Click);
            // 
            // btnAgregarCupon
            // 
            this.btnAgregarCupon.Location = new System.Drawing.Point(1030, 2);
            this.btnAgregarCupon.Name = "btnAgregarCupon";
            this.btnAgregarCupon.Size = new System.Drawing.Size(176, 46);
            this.btnAgregarCupon.TabIndex = 0;
            this.btnAgregarCupon.Text = "Agregar Cupon";
            this.btnAgregarCupon.UseVisualStyleBackColor = true;
            this.btnAgregarCupon.Click += new System.EventHandler(this.BtnAgregarCupon_Click);
            // 
            // btnReporteCompras
            // 
            this.btnReporteCompras.Location = new System.Drawing.Point(1782, 2);
            this.btnReporteCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteCompras.Name = "btnReporteCompras";
            this.btnReporteCompras.Size = new System.Drawing.Size(176, 46);
            this.btnReporteCompras.TabIndex = 8;
            this.btnReporteCompras.Text = "Reporte Compras";
            this.btnReporteCompras.UseVisualStyleBackColor = true;
            this.btnReporteCompras.Click += new System.EventHandler(this.BtnReporteCompras_Click);
            // 
            // btnModificarEvento
            // 
            this.btnModificarEvento.Location = new System.Drawing.Point(460, 2);
            this.btnModificarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarEvento.Name = "btnModificarEvento";
            this.btnModificarEvento.Size = new System.Drawing.Size(176, 46);
            this.btnModificarEvento.TabIndex = 7;
            this.btnModificarEvento.Text = "Modificar eventos";
            this.btnModificarEvento.UseVisualStyleBackColor = true;
            this.btnModificarEvento.Click += new System.EventHandler(this.BtnVisualizarEventosBorradorClick);
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Location = new System.Drawing.Point(824, 2);
            this.btnEliminarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(176, 46);
            this.btnEliminarEvento.TabIndex = 6;
            this.btnEliminarEvento.Text = "Eliminar Evento";
            this.btnEliminarEvento.UseVisualStyleBackColor = true;
            this.btnEliminarEvento.Click += new System.EventHandler(this.BtnEliminarEventoClick);
            // 
            // btnReporteEntradas
            // 
            this.btnReporteEntradas.Location = new System.Drawing.Point(1600, 2);
            this.btnReporteEntradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteEntradas.Name = "btnReporteEntradas";
            this.btnReporteEntradas.Size = new System.Drawing.Size(176, 46);
            this.btnReporteEntradas.TabIndex = 5;
            this.btnReporteEntradas.Text = "Reporte Entradas";
            this.btnReporteEntradas.UseVisualStyleBackColor = true;
            this.btnReporteEntradas.Click += new System.EventHandler(this.BtnReporteEntradasClick);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaPrincipal";
            this.Text = "Página Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel controlPanel;
        private Button btnAgregarProductor;
        private Button btnIniciarSesion;
        private Button btnCrearEvento;
        private Button btnVisualizarEventos;
        private Panel panel1;
        private Button btnReporteEntradas;
        private Button btnEliminarEvento;
        private Button btnModificarEvento;
        private Button btnAgregarCupon;
        private Button btnReporteCompras;
        private Button btnModificarCupon;
    }
}