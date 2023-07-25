using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LogicaDeNegocio.Interfaces;
using Dominio;

namespace Interfaz
{
    public partial class AgregarEvento : UserControl
    {
        private ILogicaProductor _logicaProductor;
        public List<Funcion> funciones;
        public List<Ticket> tickets;
        public string imagenEvento;
        private const int CERO = 0;
        public AgregarEvento(ILogicaProductor logicaProductor)
        {
            funciones = new List<Funcion>();
            tickets = new List<Ticket>();
            _logicaProductor = logicaProductor;
            InitializeComponent();

            cbCategoria.DataSource = Enum.GetValues(typeof(Categoria));
            cbFormato.DataSource = Enum.GetValues(typeof(Formato));
        }

        private void BtnCrearEventoClick(object sender, EventArgs e)
        {
            try

            {
                List<Funcion> _nuevasFunciones = new List<Funcion> { };
                foreach (Funcion funcion in funciones)
                {
                    List<Ticket> _nuevosTickets = new List<Ticket> { };

                    foreach (Ticket ticket in tickets)
                    {
                        _nuevosTickets.Add(ticket);
                    }
                    Funcion nuevaFuncion = new Funcion(funcion.FechaInicio, funcion.FechaFin, _nuevosTickets, funcion.MostrarDisponibles);
                    _nuevasFunciones.Add(nuevaFuncion);
                }

                Evento evento = new Evento
                {
                    Nombre = txtNombreEvento.Text,
                    Descripcion = txtDescripcionEvento.Text,
                    Direccion = txtDireccionEvento.Text,
                    Imagen = imagenEvento,
                    Formato = (Formato)cbFormato.SelectedValue,
                    Categoria = (Categoria)cbCategoria.SelectedValue,
                    Funciones = _nuevasFunciones,
                    Tickets = tickets,
                    EsBorrador = true
                };
                _logicaProductor.CrearEventoBorrador(evento);

                MessageBox.Show("Evento creado con éxito");
                LimpiarControles();
                funciones = new List<Funcion>();
                tickets = new List<Ticket>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCrearFuncion_Click(object sender, EventArgs e)
        {
            try
            {
                // Validacion en Interfaz porque si lo hacemos en dominio tenemos que cambiar nuestros tests.
                if (dtInicio.Value < DateTime.Now)
                {
                    throw new Exception("La fecha de inicio debe de ser mayor a la fecha actual");
                }
                Funcion funcion = new Funcion(dtInicio.Value, dtFin.Value, tickets, checkMostrarTicketsRestantes.Checked);
                listFunciones.Items.Add(funcion.FechaInicio + " - " + funcion.FechaFin);
                funciones.Add(funcion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAgregarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = new Ticket
                {
                    Nombre = txtNombreTicket.Text,
                    Cantidad = (int)txtCantidad.Value,
                    Precio = (int)txtPrecio.Value,
                };
                tickets.Add(ticket);

                listTickets.Items.Add(ticket.Nombre + " - " + ticket.Cantidad + " - $" + ticket.Precio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceTicketEliminado = listTickets.SelectedIndex;
                listTickets.Items.RemoveAt(indiceTicketEliminado);
                tickets.RemoveAt(indiceTicketEliminado);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un ticket para eliminar.");
            }
        }

        private void BtnEliminarFuncion_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFuncionEliminar = listFunciones.SelectedIndex;
                listFunciones.Items.RemoveAt(indiceFuncionEliminar);
                funciones.RemoveAt(indiceFuncionEliminar);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar una función para eliminar.");
            }
        }

        private void BtnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                boxImagen.Image = new Bitmap(openFileDialog.FileName);
                imagenEvento = openFileDialog.FileName;
            }
        }

        private void LimpiarControles()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                    listBox.Items.Clear();
                }

                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Image = null;
                }

                if (control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = CERO;
                }
            }
        }
    }
}
