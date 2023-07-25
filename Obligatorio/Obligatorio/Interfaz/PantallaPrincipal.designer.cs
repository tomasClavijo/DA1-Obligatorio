using System.Windows.Forms;

namespace Interfaz
{
    partial class paginaPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.btnReporteEntradas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Location = new System.Drawing.Point(12, 98);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1706, 740);
            this.controlPanel.TabIndex = 0;
            // 
            // btnAgregarProductor
            // 
            this.btnAgregarProductor.Location = new System.Drawing.Point(610, 3);
            this.btnAgregarProductor.Name = "btnAgregarProductor";
            this.btnAgregarProductor.Size = new System.Drawing.Size(196, 58);
            this.btnAgregarProductor.TabIndex = 1;
            this.btnAgregarProductor.Text = "Agregar Productor";
            this.btnAgregarProductor.UseVisualStyleBackColor = true;
            this.btnAgregarProductor.Click += new System.EventHandler(this.btnAgregarProductorClick);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(841, 3);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(196, 58);
            this.btnIniciarSesion.TabIndex = 2;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion);
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.Location = new System.Drawing.Point(1071, 3);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(196, 58);
            this.btnCrearEvento.TabIndex = 3;
            this.btnCrearEvento.Text = "Crear Evento";
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            this.btnCrearEvento.Click += new System.EventHandler(this.btnCrearEventoClick);
            // 
            // btnVisualizarEventos
            // 
            this.btnVisualizarEventos.Location = new System.Drawing.Point(10, 3);
            this.btnVisualizarEventos.Name = "btnVisualizarEventos";
            this.btnVisualizarEventos.Size = new System.Drawing.Size(196, 58);
            this.btnVisualizarEventos.TabIndex = 4;
            this.btnVisualizarEventos.Text = "Visualizar eventos";
            this.btnVisualizarEventos.UseVisualStyleBackColor = true;
            this.btnVisualizarEventos.Click += new System.EventHandler(this.btnVisualizarEventosClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnEliminarEvento);
            this.panel1.Controls.Add(this.btnReporteEntradas);
            this.panel1.Controls.Add(this.btnVisualizarEventos);
            this.panel1.Controls.Add(this.btnCrearEvento);
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.btnAgregarProductor);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1706, 68);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar eventos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnVisualizarEventosBorradorClick);
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Location = new System.Drawing.Point(1504, 3);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(196, 58);
            this.btnEliminarEvento.TabIndex = 6;
            this.btnEliminarEvento.Text = "Eliminar Evento";
            this.btnEliminarEvento.UseVisualStyleBackColor = true;
            this.btnEliminarEvento.Click += new System.EventHandler(this.btnEliminarEventoClick);
            // 
            // btnReporteEntradas
            // 
            this.btnReporteEntradas.Location = new System.Drawing.Point(1296, 3);
            this.btnReporteEntradas.Name = "btnReporteEntradas";
            this.btnReporteEntradas.Size = new System.Drawing.Size(196, 58);
            this.btnReporteEntradas.TabIndex = 5;
            this.btnReporteEntradas.Text = "Reporte Entradas";
            this.btnReporteEntradas.UseVisualStyleBackColor = true;
            this.btnReporteEntradas.Click += new System.EventHandler(this.btnReporteEntradasClick);
            // 
            // paginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 844);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPanel);
            this.Name = "paginaPrincipal";
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
        private Button button1;
    }
}