using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Dominio;
using LogicaDeNegocio.Interfaces;

namespace Interfaz
{
    public partial class ModificarEventoBorrador : UserControl
    {
        private ILogicaProductor _logicaProductor;
        public List<Funcion> nuevasFunciones = new List<Funcion>();
        public List<Ticket> nuevosTickets = new List<Ticket>();
        private string _imagenEvento;

        private Evento _eventoBorrador;

        public ModificarEventoBorrador(Evento evento, ILogicaProductor logicaProductor)
        {

            _logicaProductor = logicaProductor;
            _eventoBorrador = _logicaProductor.ObtenerEvento(evento.Nombre);
            _imagenEvento = _eventoBorrador.Imagen;

            InitializeComponent();
            AutocompletarDatosExistentesDeEvento();
        }

        private void AutocompletarDatosExistentesDeEvento()
        {
            txtNombreEvento.Text = _eventoBorrador.Nombre;
            txtDescripcionEvento.Text = _eventoBorrador.Descripcion;

            cbCategoria.DataSource = Enum.GetValues(typeof(Categoria));
            cbCategoria.SelectedIndex = (int)_eventoBorrador.Categoria;

            cbFormato.DataSource = Enum.GetValues(typeof(Formato));
            cbFormato.SelectedIndex = (int)_eventoBorrador.Formato;

            txtDireccionEvento.Text = _eventoBorrador.Direccion;

            boxImagen.Image = new Bitmap(_eventoBorrador.Imagen);

            PoblarListasTickets();
            PoblarListasFunciones();
        }

        private void BtnModificarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                List<Funcion> _nuevasFunciones = new List<Funcion> { };
                List<Ticket> _nuevosTickets = new List<Ticket> ();

                foreach (Funcion funcion in nuevasFunciones)
                {
                    _nuevosTickets = new List<Ticket>();
                    foreach (Ticket ticket in nuevosTickets)
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
                    Imagen = _imagenEvento,
                    Formato = (Formato)cbFormato.SelectedValue,
                    Categoria = (Categoria)cbCategoria.SelectedValue,
                    Funciones = _nuevasFunciones,
                    Tickets = _nuevosTickets,
                    EsBorrador = true
                };
                _logicaProductor.EliminarEvento(_eventoBorrador);
                _logicaProductor.CrearEventoBorrador(evento);
                
                MessageBox.Show("Evento modificado con éxito");

                Controls.Clear();
                UserControl visualizarEventos = new VisualizarEventosBorrador(_logicaProductor);
                Controls.Add(visualizarEventos);
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
                nuevosTickets.Add(ticket);

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
                nuevosTickets.RemoveAt(indiceTicketEliminado);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un ticket para eliminar.");
            }
        }

        private void PoblarListasTickets()
        {
            foreach (Ticket ticket in _eventoBorrador.Tickets)
            {
                listTickets.Items.Add(ticket.Nombre + " - " + ticket.Cantidad + " - $" + ticket.Precio);
                Ticket nuevoTicket = new Ticket()
                {
                    Nombre = ticket.Nombre,
                    Precio = ticket.Precio,
                    Cantidad = ticket.Cantidad,
                };
                nuevosTickets.Add(nuevoTicket);
            }
        }

        private void BtnEliminarFuncion_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFuncionEliminar = listFunciones.SelectedIndex;
                listFunciones.Items.RemoveAt(indiceFuncionEliminar);
                nuevasFunciones.RemoveAt(indiceFuncionEliminar);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar una función para eliminar.");
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
                Funcion funcion = new Funcion(dtInicio.Value, dtFin.Value, nuevosTickets, checkMostrarTicketsRestantes.Checked);
                listFunciones.Items.Add(funcion.FechaInicio + " - " + funcion.FechaFin);
                nuevasFunciones.Add(funcion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PoblarListasFunciones()
        {
            foreach (Funcion funcion in _eventoBorrador.Funciones)
            {
                listFunciones.Items.Add(funcion.FechaInicio + " - " + funcion.FechaFin);
                Funcion nuevaFuncion = new Funcion()
                {
                    FechaInicio = funcion.FechaInicio,
                    FechaFin = funcion.FechaFin,
                    ListaTickets = funcion.ListaTickets,
                    MostrarDisponibles = funcion.MostrarDisponibles,
                };
                nuevasFunciones.Add(nuevaFuncion);
            }
        }

        private void BtnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                boxImagen.Image = new Bitmap(openFileDialog.FileName);
                _imagenEvento = openFileDialog.FileName;
            }
        }
    }
}
