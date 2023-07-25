using System.Windows.Forms;

namespace Interfaz
{
    partial class ModificarEventoBorrador
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
            this.boxImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.txtDireccionEvento = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.checkMostrarTicketsRestantes = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarEvento = new System.Windows.Forms.Button();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.btnCrearFuncion = new System.Windows.Forms.Button();
            this.listFunciones = new System.Windows.Forms.ListBox();
            this.lbFunciones = new System.Windows.Forms.Label();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbFormato = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnEliminarFuncion = new System.Windows.Forms.Button();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // boxImagen
            // 
            this.boxImagen.Location = new System.Drawing.Point(30, 392);
            this.boxImagen.Name = "boxImagen";
            this.boxImagen.Size = new System.Drawing.Size(485, 180);
            this.boxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxImagen.TabIndex = 114;
            this.boxImagen.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(30, 323);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(483, 50);
            this.btnAgregarImagen.TabIndex = 87;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.BtnAgregarImagen_Click);
            // 
            // txtDireccionEvento
            // 
            this.txtDireccionEvento.Location = new System.Drawing.Point(330, 273);
            this.txtDireccionEvento.Name = "txtDireccionEvento";
            this.txtDireccionEvento.Size = new System.Drawing.Size(183, 31);
            this.txtDireccionEvento.TabIndex = 86;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(30, 273);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(85, 25);
            this.lbDireccion.TabIndex = 113;
            this.lbDireccion.Text = "Dirección";
            // 
            // checkMostrarTicketsRestantes
            // 
            this.checkMostrarTicketsRestantes.AutoSize = true;
            this.checkMostrarTicketsRestantes.Location = new System.Drawing.Point(1374, 463);
            this.checkMostrarTicketsRestantes.Name = "checkMostrarTicketsRestantes";
            this.checkMostrarTicketsRestantes.Size = new System.Drawing.Size(231, 29);
            this.checkMostrarTicketsRestantes.TabIndex = 98;
            this.checkMostrarTicketsRestantes.Text = "Mostrar tickets restantes";
            this.checkMostrarTicketsRestantes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1275, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 112;
            // 
            // btnModificarEvento
            // 
            this.btnModificarEvento.Location = new System.Drawing.Point(660, 658);
            this.btnModificarEvento.Name = "btnModificarEvento";
            this.btnModificarEvento.Size = new System.Drawing.Size(386, 50);
            this.btnModificarEvento.TabIndex = 100;
            this.btnModificarEvento.Text = "Modificar Evento";
            this.btnModificarEvento.UseVisualStyleBackColor = true;
            this.btnModificarEvento.Click += new System.EventHandler(this.BtnModificarEvento_Click);
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(1290, 403);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(89, 25);
            this.lbFechaFin.TabIndex = 111;
            this.lbFechaFin.Text = "Fecha Fin:";
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(1290, 343);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(108, 25);
            this.lbFechaInicio.TabIndex = 110;
            this.lbFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtFin
            // 
            this.dtFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFin.Location = new System.Drawing.Point(1422, 403);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(254, 31);
            this.dtFin.TabIndex = 97;
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(1422, 343);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(254, 31);
            this.dtInicio.TabIndex = 96;
            // 
            // btnCrearFuncion
            // 
            this.btnCrearFuncion.Location = new System.Drawing.Point(1290, 523);
            this.btnCrearFuncion.Name = "btnCrearFuncion";
            this.btnCrearFuncion.Size = new System.Drawing.Size(386, 50);
            this.btnCrearFuncion.TabIndex = 99;
            this.btnCrearFuncion.Text = "Agregar Función";
            this.btnCrearFuncion.UseVisualStyleBackColor = true;
            this.btnCrearFuncion.Click += new System.EventHandler(this.BtnCrearFuncion_Click);
            // 
            // listFunciones
            // 
            this.listFunciones.FormattingEnabled = true;
            this.listFunciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listFunciones.ItemHeight = 25;
            this.listFunciones.Location = new System.Drawing.Point(1290, 93);
            this.listFunciones.Name = "listFunciones";
            this.listFunciones.Size = new System.Drawing.Size(386, 154);
            this.listFunciones.TabIndex = 94;
            // 
            // lbFunciones
            // 
            this.lbFunciones.AutoSize = true;
            this.lbFunciones.Location = new System.Drawing.Point(1290, 33);
            this.lbFunciones.Name = "lbFunciones";
            this.lbFunciones.Size = new System.Drawing.Size(91, 25);
            this.lbFunciones.TabIndex = 109;
            this.lbFunciones.Text = "Funciones";
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(330, 33);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(183, 31);
            this.txtNombreEvento.TabIndex = 82;
            // 
            // cbFormato
            // 
            this.cbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Location = new System.Drawing.Point(330, 213);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(183, 33);
            this.cbFormato.TabIndex = 85;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(330, 153);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(183, 33);
            this.cbCategoria.TabIndex = 84;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(30, 213);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(88, 25);
            this.lbCategoria.TabIndex = 108;
            this.lbCategoria.Text = "Categoría";
            // 
            // lbFormato
            // 
            this.lbFormato.AutoSize = true;
            this.lbFormato.Location = new System.Drawing.Point(30, 153);
            this.lbFormato.Name = "lbFormato";
            this.lbFormato.Size = new System.Drawing.Size(80, 25);
            this.lbFormato.TabIndex = 107;
            this.lbFormato.Text = "Formato";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnEliminarFuncion
            // 
            this.btnEliminarFuncion.Location = new System.Drawing.Point(1290, 273);
            this.btnEliminarFuncion.Name = "btnEliminarFuncion";
            this.btnEliminarFuncion.Size = new System.Drawing.Size(386, 34);
            this.btnEliminarFuncion.TabIndex = 95;
            this.btnEliminarFuncion.Text = "Eliminar Función";
            this.btnEliminarFuncion.UseVisualStyleBackColor = true;
            this.btnEliminarFuncion.Click += new System.EventHandler(this.BtnEliminarFuncion_Click);
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Location = new System.Drawing.Point(330, 93);
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(183, 31);
            this.txtDescripcionEvento.TabIndex = 83;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(30, 93);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(104, 25);
            this.lbDescripcion.TabIndex = 106;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(30, 33);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(78, 25);
            this.lbNombre.TabIndex = 105;
            this.lbNombre.Text = "Nombre";
            // 
            // btnAgregarTicket
            // 
            this.btnAgregarTicket.Location = new System.Drawing.Point(660, 523);
            this.btnAgregarTicket.Name = "btnAgregarTicket";
            this.btnAgregarTicket.Size = new System.Drawing.Size(386, 50);
            this.btnAgregarTicket.TabIndex = 93;
            this.btnAgregarTicket.Text = "Agregar Ticket";
            this.btnAgregarTicket.UseVisualStyleBackColor = true;
            this.btnAgregarTicket.Click += new System.EventHandler(this.BtnAgregarTicket_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(866, 403);
            this.txtPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(180, 31);
            this.txtPrecio.TabIndex = 91;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(866, 463);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(180, 31);
            this.txtCantidad.TabIndex = 92;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(660, 463);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(83, 25);
            this.lbCantidad.TabIndex = 104;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(660, 403);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(60, 25);
            this.lbPrecio.TabIndex = 103;
            this.lbPrecio.Text = "Precio";
            // 
            // txtNombreTicket
            // 
            this.txtNombreTicket.Location = new System.Drawing.Point(866, 343);
            this.txtNombreTicket.Name = "txtNombreTicket";
            this.txtNombreTicket.Size = new System.Drawing.Size(180, 31);
            this.txtNombreTicket.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 102;
            this.label1.Text = "Nombre";
            // 
            // btnEliminarTicket
            // 
            this.btnEliminarTicket.Location = new System.Drawing.Point(660, 273);
            this.btnEliminarTicket.Name = "btnEliminarTicket";
            this.btnEliminarTicket.Size = new System.Drawing.Size(386, 34);
            this.btnEliminarTicket.TabIndex = 89;
            this.btnEliminarTicket.Text = "Eliminar Ticket";
            this.btnEliminarTicket.UseVisualStyleBackColor = true;
            this.btnEliminarTicket.Click += new System.EventHandler(this.BtnEliminarTicket_Click);
            // 
            // listTickets
            // 
            this.listTickets.FormattingEnabled = true;
            this.listTickets.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listTickets.ItemHeight = 25;
            this.listTickets.Location = new System.Drawing.Point(660, 93);
            this.listTickets.Name = "listTickets";
            this.listTickets.Size = new System.Drawing.Size(386, 154);
            this.listTickets.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 101;
            this.label2.Text = "Tickets";
            // 
            // ModificarEventoBorrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtDireccionEvento);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.checkMostrarTicketsRestantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificarEvento);
            this.Controls.Add(this.lbFechaFin);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.btnCrearFuncion);
            this.Controls.Add(this.listFunciones);
            this.Controls.Add(this.lbFunciones);
            this.Controls.Add(this.txtNombreEvento);
            this.Controls.Add(this.cbFormato);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbFormato);
            this.Controls.Add(this.btnEliminarFuncion);
            this.Controls.Add(this.txtDescripcionEvento);
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
            this.Name = "ModificarEventoBorrador";
            this.Size = new System.Drawing.Size(1706, 740);
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox boxImagen;
        private Button btnAgregarImagen;
        private TextBox txtDireccionEvento;
        private Label lbDireccion;
        private CheckBox checkMostrarTicketsRestantes;
        private Label label3;
        private Button btnModificarEvento;
        private Label lbFechaFin;
        private Label lbFechaInicio;
        private DateTimePicker dtFin;
        private DateTimePicker dtInicio;
        private Button btnCrearFuncion;
        private ListBox listFunciones;
        private Label lbFunciones;
        private TextBox txtNombreEvento;
        private ComboBox cbFormato;
        private ComboBox cbCategoria;
        private Label lbCategoria;
        private Label lbFormato;
        private OpenFileDialog openFileDialog;
        private Button btnEliminarFuncion;
        private TextBox txtDescripcionEvento;
        private Label lbDescripcion;
        private Label lbNombre;
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
    }
}
