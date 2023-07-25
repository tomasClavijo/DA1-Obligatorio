using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocio.Interfaces
{
    public interface ILogicaAsistente
    {
        List<Evento> VisualizarEventos();

        List<Evento> OrdenarEventosPorNombre();

        List<Evento> OrdenarEventosPorFecha();

        List<Evento> OrdenarEventosPorFechaYNombre();

        Dictionary<Categoria, int> CantidadCategoria();

        List<Evento> FiltrarPorCategoria(Categoria categoria);

        Dictionary<Categoria, int> GenerarReporte(int precioMin, int precioMax);

        void ComprarTickets(Evento eventoComprar, Funcion funcionComprar, Ticket ticketComprar, int cantidadComprar);

        Compra RegistrarCompra(Evento eventoComprar, List<(Ticket, int)> ticketsComprados, Asistente asistente, DateTime? fechaComprado = null);

        Compra ComprarYRegistrar(Evento eventoComprar, Funcion funcionComprar, List<(Ticket, int)> ticketsComprados, Asistente asistente, DateTime? fechaComprado = null);

        List<Evento> FiltrarEventosEntreFechas(DateTime fechaInicio, DateTime fechaFin, List<Evento> eventos);

        List<Evento> FiltrarEventosPorNombre(string nombreEvento, List<Evento> eventos);

        int ConsultarCantidadTicketFuncion(Evento evento, Funcion funcion, Ticket ticket);

        Compra ObtenerCompra(Evento evento, Funcion funcion, Asistente asistente, List<(Ticket, int)> compra1);

        void ControlarTotal(int total);
    }
}
