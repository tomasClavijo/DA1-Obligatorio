using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LogicaDeNegocio;
using LogicaDeNegocio.Interfaces;
using Dominio;

namespace Interfaz
{
    public partial class VisualizarFunciones : UserControl
    {
        private Evento _eventoSeleccionado;
        private ILogicaAsistente _logicaAsistenteAccesoDatos;
        private ILogicaProductor _logicaProductorAccesoDatos;
        private int _cantidadTotal;
        private Asistente _asistente;
        private Cupon _cupon;

        public VisualizarFunciones(Evento eventoSeleccionado, ILogicaAsistente logicaAsistente,  ILogicaProductor logicaProductor, Cupon cupon, Asistente asistente)

        {

            _eventoSeleccionado = eventoSeleccionado;
            _logicaAsistenteAccesoDatos = logicaAsistente;
            _logicaProductorAccesoDatos = logicaProductor;
            _asistente = asistente;
            _cupon = cupon;

            InitializeComponent();
            PoblarDatosAsistente(asistente);

            foreach (var funcion in _eventoSeleccionado.Funciones)
            {
                dgvFunciones.Rows.Add(funcion.FechaInicio, funcion.FechaFin);
            }
            CedulaAsistente.Text = asistente.Cedula;

        }


        private void SeleccionarFuncion(object sender, EventArgs e)
        {
            dgvTickets.Rows.Clear();
            int numeroFuncionSeleccionada = dgvFunciones.CurrentCell.RowIndex;
            Funcion funcionSeleccionada = _eventoSeleccionado.Funciones[numeroFuncionSeleccionada];

            foreach (ParTicketCantidad ticketCantidad in funcionSeleccionada.ListaTickets)
            {
                if (funcionSeleccionada.MostrarDisponibles)
                {
                    dgvTickets.Rows.Add(ticketCantidad.Ticket.Nombre, ticketCantidad.Ticket.Precio, ticketCantidad.Cantidad,0);
                }
                else
                {
                    dgvTickets.Rows.Add(ticketCantidad.Ticket.Nombre, ticketCantidad.Ticket.Precio, "-",0);
                }
            }
        }

        private void BtnComprarTickets_Click(object sender, EventArgs e)
        {
            Dictionary<String, int> ticketCantidad = ObtenerDatosDeCompra();
            try
            {
                _logicaAsistenteAccesoDatos.ControlarTotal(_cantidadTotal);
                List<(Ticket, int)> ticketsComprados = new List<(Ticket, int)>();
                Funcion funcion = _eventoSeleccionado.Funciones[dgvFunciones.CurrentCell.RowIndex];

                for (int i = 0; i < dgvTickets.RowCount; i++)
                {
                    if (funcion.ListaTickets[i].Ticket.Nombre == ticketCantidad.ElementAt(i).Key && ticketCantidad.ElementAt(i).Value > 0)
                    {

                        Ticket ticketAuxiliar = new Ticket()
                        {
                            Nombre = funcion.ListaTickets[i].Ticket.Nombre,
                            Precio = funcion.ListaTickets[i].Ticket.Precio,
                            Cantidad = funcion.ListaTickets[i].Ticket.Cantidad,
                        };

                        // le resta el precio al ticket...

                        Ticket ticketConDescuento = AplicarDescuento(ticketAuxiliar, ticketCantidad.ElementAt(i).Value);
                        ticketsComprados.Add((ticketConDescuento, ticketCantidad.ElementAt(i).Value));
                    }
                }

                Compra compra = _logicaAsistenteAccesoDatos.ComprarYRegistrar(_eventoSeleccionado, funcion, ticketsComprados, _asistente);
                _logicaProductorAccesoDatos.AgregarAsistenteEvento(_asistente, _eventoSeleccionado);

                if (_cupon.Codigo != "0000000000")
                {
                    int nuevaCantidad = _cupon.CantidadRestante - 1;
                    _logicaProductorAccesoDatos.CambiarCantidadRestante(_cupon, nuevaCantidad);
                }

                Controls.Clear();
                UserControl confirmarCompra = new ConfirmarCompra(compra, ticketsComprados, _logicaProductorAccesoDatos, _logicaAsistenteAccesoDatos);
                Controls.Add(confirmarCompra);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        private Ticket AplicarDescuento(Ticket ticket,int numeroEntradas)
        {
            Ticket ticketPrecioActualizado=ticket;
            if (_cupon.Codigo !="0000000000")
            {
                ticketPrecioActualizado.Precio = _cupon.CalcularDescuento(ticketPrecioActualizado.Precio, numeroEntradas);
            }
            return ticketPrecioActualizado;
        }

        private Dictionary<String, int>  ObtenerDatosDeCompra()
        {
            Dictionary<String, int> ticketCantidad = new Dictionary<String, int>();
            for (int i = 0; i < dgvTickets.RowCount; i++)
            {
                var valor = dgvTickets.Rows[i].Cells[3].Value;
                if (valor == null)
                {
                    ticketCantidad.Add((string)dgvTickets.Rows[i].Cells[0].Value, 0);
                }
                else
                {
                    int cantidadTickets = int.Parse(valor.ToString());
                    ticketCantidad.Add((string)dgvTickets.Rows[i].Cells[0].Value, cantidadTickets);
                }
            }
            return ticketCantidad;
        }

        private void CambioValorCantidadComprar(object sender, EventArgs e)
        {
            var valorCantidadCompra = decimal.ToInt32(numCantidadComprar.Value);
            var valorDeFilaElegida = dgvTickets.Rows[dgvTickets.CurrentCell.RowIndex].Cells[3].Value;
            _cantidadTotal += (valorCantidadCompra - int.Parse(valorDeFilaElegida.ToString()));
            dgvTickets.Rows[dgvTickets.CurrentCell.RowIndex].Cells[3].Value = numCantidadComprar.Value;
        }
        private void PoblarDatosAsistente(Asistente asistente)
        {
            estadoCupon.Text = _cupon.Nombre;
            estadoCupon.Text = _cupon.Nombre;
            CedulaAsistente.Text = asistente.Cedula;
            NombreAsistente.Text = asistente.Nombre;
            apellidoAsistente.Text = asistente.Apellido;
        }
    }
}
