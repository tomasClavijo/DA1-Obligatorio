using System.Windows.Forms;

namespace Interfaz
{
    partial class AgregarEvento
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
            this.btnAgregarTicket = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txtNombreTicket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarTicket = new System.Windows.Forms.Button();
            this.listTickets = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbFormato = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.btnCrearFuncion = new System.Windows.Forms.Button();
            this.btnEliminarFuncion = new System.Windows.Forms.Button();
            this.listFunciones = new System.Windows.Forms.ListBox();
            this.lbFunciones = new System.Windows.Forms.Label();
            this.btnCrearEvento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkMostrarTicketsRestantes = new System.Windows.Forms.CheckBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.txtDireccionEvento = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.boxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarTicket
            // 
            this.btnAgregarTicket.Location = new System.Drawing.Point(660, 530);
            this.btnAgregarTicket.Name = "btnAgregarTicket";
            this.btnAgregarTicket.Size = new System.Drawing.Size(386, 50);
            this.btnAgregarTicket.TabIndex = 12;
            this.btnAgregarTicket.Text = "Agregar Ticket";
            this.btnAgregarTicket.UseVisualStyleBackColor = true;
            this.btnAgregarTicket.Click += new System.EventHandler(this.BtnAgregarTicket_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(866, 410);
            this.txtPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(180, 31);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(866, 470);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(180, 31);
            this.txtCantidad.TabIndex = 11;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(660, 470);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(83, 25);
            this.lbCantidad.TabIndex = 54;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(660, 410);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(60, 25);
            this.lbPrecio.TabIndex = 53;
            this.lbPrecio.Text = "Precio";
            // 
            // txtNombreTicket
            // 
            this.txtNombreTicket.Location = new System.Drawing.Point(866, 350);
            this.txtNombreTicket.Name = "txtNombreTicket";
            this.txtNombreTicket.Size = new System.Drawing.Size(180, 31);
            this.txtNombreTicket.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre";
            // 
            // btnEliminarTicket
            // 
            this.btnEliminarTicket.Location = new System.Drawing.Point(660, 280);
            this.btnEliminarTicket.Name = "btnEliminarTicket";
            this.btnEliminarTicket.Size = new System.Drawing.Size(386, 34);
            this.btnEliminarTicket.TabIndex = 8;
            this.btnEliminarTicket.Text = "Eliminar Ticket";
            this.btnEliminarTicket.UseVisualStyleBackColor = true;
            this.btnEliminarTicket.Click += new System.EventHandler(this.BtnEliminarTicket_Click);
            // 
            // listTickets
            // 
            this.listTickets.FormattingEnabled = true;
            this.listTickets.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listTickets.ItemHeight = 25;
            this.listTickets.Location = new System.Drawing.Point(660, 100);
            this.listTickets.Name = "listTickets";
            this.listTickets.Size = new System.Drawing.Size(386, 154);
            this.listTickets.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tickets";
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Location = new System.Drawing.Point(330, 100);
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(183, 31);
            this.txtDescripcionEvento.TabIndex = 2;
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(330, 40);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(183, 31);
            this.txtNombreEvento.TabIndex = 1;
            // 
            // cbFormato
            // 
            this.cbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Location = new System.Drawing.Point(330, 220);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(183, 33);
            this.cbFormato.TabIndex = 4;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(330, 160);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(183, 33);
            this.cbCategoria.TabIndex = 3;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(30, 220);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(88, 25);
            this.lbCategoria.TabIndex = 61;
            this.lbCategoria.Text = "Categoría";
            // 
            // lbFormato
            // 
            this.lbFormato.AutoSize = true;
            this.lbFormato.Location = new System.Drawing.Point(30, 160);
            this.lbFormato.Name = "lbFormato";
            this.lbFormato.Size = new System.Drawing.Size(80, 25);
            this.lbFormato.TabIndex = 60;
            this.lbFormato.Text = "Formato";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(30, 100);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(104, 25);
            this.lbDescripcion.TabIndex = 59;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(30, 40);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(78, 25);
            this.lbNombre.TabIndex = 58;
            this.lbNombre.Text = "Nombre";
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(1290, 410);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(89, 25);
            this.lbFechaFin.TabIndex = 73;
            this.lbFechaFin.Text = "Fecha Fin:";
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(1290, 350);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(108, 25);
            this.lbFechaInicio.TabIndex = 72;
            this.lbFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtFin
            // 
            this.dtFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFin.Location = new System.Drawing.Point(1422, 410);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(254, 31);
            this.dtFin.TabIndex = 16;
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(1422, 350);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(254, 31);
            this.dtInicio.TabIndex = 15;
            // 
            // btnCrearFuncion
            // 
            this.btnCrearFuncion.Location = new System.Drawing.Point(1290, 530);
            this.btnCrearFuncion.Name = "btnCrearFuncion";
            this.btnCrearFuncion.Size = new System.Drawing.Size(386, 50);
            this.btnCrearFuncion.TabIndex = 18;
            this.btnCrearFuncion.Text = "Agregar Función";
            this.btnCrearFuncion.UseVisualStyleBackColor = true;
            this.btnCrearFuncion.Click += new System.EventHandler(this.BtnCrearFuncion_Click);
            // 
            // btnEliminarFuncion
            // 
            this.btnEliminarFuncion.Location = new System.Drawing.Point(1290, 280);
            this.btnEliminarFuncion.Name = "btnEliminarFuncion";
            this.btnEliminarFuncion.Size = new System.Drawing.Size(386, 34);
            this.btnEliminarFuncion.TabIndex = 14;
            this.btnEliminarFuncion.Text = "Eliminar Función";
            this.btnEliminarFuncion.UseVisualStyleBackColor = true;
            this.btnEliminarFuncion.Click += new System.EventHandler(this.BtnEliminarFuncion_Click);
            // 
            // listFunciones
            // 
            this.listFunciones.FormattingEnabled = true;
            this.listFunciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listFunciones.ItemHeight = 25;
            this.listFunciones.Location = new System.Drawing.Point(1290, 100);
            this.listFunciones.Name = "listFunciones";
            this.listFunciones.Size = new System.Drawing.Size(386, 154);
            this.listFunciones.TabIndex = 13;
            // 
            // lbFunciones
            // 
            this.lbFunciones.AutoSize = true;
            this.lbFunciones.Location = new System.Drawing.Point(1290, 40);
            this.lbFunciones.Name = "lbFunciones";
            this.lbFunciones.Size = new System.Drawing.Size(91, 25);
            this.lbFunciones.TabIndex = 66;
            this.lbFunciones.Text = "Funciones";
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.Location = new System.Drawing.Point(660, 665);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(386, 50);
            this.btnCrearEvento.TabIndex = 19;
            this.btnCrearEvento.Text = "Crear Evento";
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            this.btnCrearEvento.Click += new System.EventHandler(this.BtnCrearEventoClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1275, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 75;
            // 
            // checkMostrarTicketsRestantes
            // 
            this.checkMostrarTicketsRestantes.AutoSize = true;
            this.checkMostrarTicketsRestantes.Location = new System.Drawing.Point(1374, 470);
            this.checkMostrarTicketsRestantes.Name = "checkMostrarTicketsRestantes";
            this.checkMostrarTicketsRestantes.Size = new System.Drawing.Size(231, 29);
            this.checkMostrarTicketsRestantes.TabIndex = 17;
            this.checkMostrarTicketsRestantes.Text = "Mostrar tickets restantes";
            this.checkMostrarTicketsRestantes.UseVisualStyleBackColor = true;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(30, 280);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(85, 25);
            this.lbDireccion.TabIndex = 77;
            this.lbDireccion.Text = "Dirección";
            // 
            // txtDireccionEvento
            // 
            this.txtDireccionEvento.Location = new System.Drawing.Point(330, 280);
            this.txtDireccionEvento.Name = "txtDireccionEvento";
            this.txtDireccionEvento.Size = new System.Drawing.Size(183, 31);
            this.txtDireccionEvento.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(30, 330);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(483, 50);
            this.btnAgregarImagen.TabIndex = 6;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.BtnAgregarImagen_Click);
            // 
            // boxImagen
            // 
            this.boxImagen.Location = new System.Drawing.Point(30, 399);
            this.boxImagen.Name = "boxImagen";
            this.boxImagen.Size = new System.Drawing.Size(485, 180);
            this.boxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxImagen.TabIndex = 81;
            this.boxImagen.TabStop = false;
            // 
            // AgregarEvento2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.boxImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtDireccionEvento);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.checkMostrarTicketsRestantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCrearEvento);
            this.Controls.Add(this.lbFechaFin);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.btnCrearFuncion);
            this.Controls.Add(this.btnEliminarFuncion);
            this.Controls.Add(this.listFunciones);
            this.Controls.Add(this.lbFunciones);
            this.Controls.Add(this.txtDescripcionEvento);
            this.Controls.Add(this.txtNombreEvento);
            this.Controls.Add(this.cbFormato);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbFormato);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnAgregarTicket);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.txtNombreTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarTicket);
            this.Controls.Add(this.listTickets);
            this.Controls.Add(this.label2);
            this.Name = "AgregarEvento2";
            this.Size = new System.Drawing.Size(1706, 740);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregarTicket;
        private NumericUpDown txtPrecio;
        private NumericUpDown txtCantidad;
        private Label lbCantidad;
        private Label lbPrecio;
        private TextBox txtNombreTicket;
        private Label label1;
        private Button btnEliminarTicket;
        private ListBox listTickets;
        private Label label2;
        private TextBox txtDescripcionEvento;
        private TextBox txtNombreEvento;
        private ComboBox cbFormato;
        private ComboBox cbCategoria;
        private Label lbCategoria;
        private Label lbFormato;
        private Label lbDescripcion;
        private Label lbNombre;
        private Label lbFechaFin;
        private Label lbFechaInicio;
        private DateTimePicker dtFin;
        private DateTimePicker dtInicio;
        private Button btnCrearFuncion;
        private Button btnEliminarFuncion;
        private ListBox listFunciones;
        private Label lbFunciones;
        private Button btnCrearEvento;
        private Label label3;
        private CheckBox checkMostrarTicketsRestantes;
        private Label lbDireccion;
        private TextBox txtDireccionEvento;
        private OpenFileDialog openFileDialog;
        private Button btnAgregarImagen;
        private PictureBox boxImagen;
    }
}
