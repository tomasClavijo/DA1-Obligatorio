using System.Collections.Generic;
using Dominio;


namespace AccesoDatos.Interfaces
{
    public interface IRepositorioAsistente
    {
        List<Evento> ObtenerEventos();

        int ConsultarCantidadTicketFuncion(Evento evento, Funcion funcion, Ticket ticket);

        void ComprarTickets(Evento eventoComprar, Funcion funcionComprar, Ticket ticketComprar, int cantidadComprar);

        void RegistrarCompra(Compra nuevaCompra, Evento eventoComprar, List<(Ticket, int)> ticketsComprados);

        List<(Categoria, int)> ObtenerEntradasVendidas();

        Compra ObtenerCompra(Evento evento, Funcion funcion, Asistente asistente, List<(Ticket, int)> compra);
    }
}
