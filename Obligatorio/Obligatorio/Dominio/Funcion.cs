using Excepciones;
using System;
using System.Collections.Generic;

namespace Dominio
{

    public class ParTicketCantidad
    {
        public int Id { get; set; }
        public Ticket Ticket { get; set; }
        public int Cantidad { get; set; }

        public Funcion Funcion { get; set; }

        public ParTicketCantidad(Ticket nuevoTicket, int nuevaCantidad)
        {
            Ticket = nuevoTicket;
            Cantidad = nuevaCantidad;
        }

        public ParTicketCantidad()
        {

        }
    }

    public class Funcion
    {
        public Evento Evento { get; set; }

        public int Id { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public List<ParTicketCantidad> ListaTickets { get; set; }
        public bool MostrarDisponibles { get; set; }


        public Funcion(DateTime fechaInicio, DateTime fechaFin, List<Ticket> listatickets, bool mostrarDisponible = false) : base()
        {
            MostrarDisponibles  = false;
            if (DateTime.Compare(fechaInicio, fechaFin) >= 0)
            {
                throw new FechaException();
            }
            if (listatickets.Count == 0)
            {
                throw new TicketsVaciosFuncionException();
            }
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.MostrarDisponibles = mostrarDisponible;
            this.ListaTickets = new List<ParTicketCantidad>();
            foreach (Ticket ticket in listatickets)
            {
                ParTicketCantidad nuevoPar = new ParTicketCantidad(ticket, ticket.Cantidad);
                ListaTickets.Add(nuevoPar);
            }
        }

        public Funcion()
        {

        }

        public void RestarCantidadTickets(Ticket ticketCompra, int cantidadCompra)
        {
            if (cantidadCompra == 0)
            {
                throw new RestarCeroException();
            }
            else
            {
                ParTicketCantidad ticket = BuscarTicket(ticketCompra);
                if (cantidadCompra > ticket.Cantidad)
                {
                    throw new RestaMayorTicketsExpection();
                }
                ticket.Cantidad -= cantidadCompra;
            }
        }

        public void RestarTicketsComprados(Ticket ticketComprado, int cantidadComprado)
        {
            foreach (ParTicketCantidad parTicketCantidad in ListaTickets)
            {
                if (parTicketCantidad.Ticket.Nombre == ticketComprado.Nombre)
                {
                    parTicketCantidad.Cantidad -= cantidadComprado;
                }
            }
        }



        public int ConsultarCantidadTickets(Ticket ticketConsulta)
        {
            ParTicketCantidad ticket = BuscarTicket(ticketConsulta);
            return ticket.Cantidad;
        }

        private ParTicketCantidad BuscarTicket(Ticket ticketConsulta)
        {
            foreach (ParTicketCantidad ticket in ListaTickets)
            {
                if (ticketConsulta.Nombre == ticket.Ticket.Nombre)
                {
                    return ticket;
                }
            }
            throw new TicketInexistenteException();
        }

    }
}