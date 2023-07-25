using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using AccesoDatos.Interfaces;
using Dominio;

namespace AccesoDatos.Implementaciones
{
    public class RepositorioAsistenteImp : IRepositorioAsistente
    {
        public List<Evento> ObtenerEventos()
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Eventos.Include(e => e.Funciones.Select(f => f.ListaTickets))
                                       .Include(e => e.Tickets)
                                       .Where(e => !e.EsBorrador)
                                       .ToList();
            }
        }

        public void ComprarTickets(Evento eventoComprar, Funcion funcionComprar, Ticket ticketComprar, int cantidadComprar)
        {
            using (var contexto = new ContextoEvento())
            {
                Evento evento = contexto.Eventos.Include(e => e.Funciones.Select(f => f.ListaTickets))
                                       .Include(e => e.Tickets)
                                       .FirstOrDefault(e => e.Nombre == eventoComprar.Nombre);

                foreach (Funcion funcion in evento.Funciones)
                {
                    if (funcionComprar.FechaInicio == funcion.FechaInicio
                        && funcionComprar.FechaFin == funcion.FechaFin)
                    {
                        funcion.RestarTicketsComprados(ticketComprar, cantidadComprar);
                    }
                }
                contexto.SaveChanges();
            }
        }

        public void RegistrarCompra(Compra nuevaCompra, Evento eventoComprar, List<(Ticket, int)> ticketsComprados)
        {
            using (var contexto = new ContextoEvento())
            {
                contexto.Compras.Add(nuevaCompra);
                
                foreach ((Ticket, int) ticketComprado in ticketsComprados)
                {
                    for (int i = 0; i < ticketComprado.Item2; i++)
                    {
                        contexto.EntradasVendidas.Add(new EntradaVendida() { Categoria = eventoComprar.Categoria, Monto = ticketComprado.Item1.Precio });
                    }
                }
                contexto.SaveChanges();
            }
        }

        public int ConsultarCantidadTicketFuncion(Evento eventoConsultar, Funcion funcionConsultar, Ticket ticketConsultar)
        {
            using (var contexto = new ContextoEvento())
            {
                Evento evento = contexto.Eventos.Include(e => e.Funciones.Select(f => f.ListaTickets))
                                       .Include(e => e.Tickets)
                                       .FirstOrDefault(e => e.Nombre == eventoConsultar.Nombre);

                Funcion funcion = evento.Funciones.FirstOrDefault(f => f.FechaInicio == funcionConsultar.FechaInicio
                && f.FechaFin == funcionConsultar.FechaFin);

                return funcion.ListaTickets.FirstOrDefault(t => t.Ticket.Nombre == ticketConsultar.Nombre).Cantidad;
            }
        }

        public List<(Categoria, int)> ObtenerEntradasVendidas()
        {
            List<(Categoria, int)> retorno = new List<(Categoria, int)>();

            using (var contexto = new ContextoEvento())
            {
                List<EntradaVendida> entradasVendidas = contexto.EntradasVendidas.ToList();
                foreach (EntradaVendida entradaVendida in entradasVendidas)
                {
                    retorno.Add((entradaVendida.Categoria, entradaVendida.Monto));
                }
            }
            return retorno;
        }

        public Compra ObtenerCompra(Evento evento, Funcion funcion, Asistente asistente, List<(Ticket, int)> compra)
        {
            using (var contexto = new ContextoEvento())
            {
                // return contexto.Compras.FirstOrDefault(c => c.Asistente.Cedula == asistente.Cedula && c. == compra);
            }
            return null;
        }

        public void VaciarTablaAsistentes()
        {
            using (var contexto = new ContextoEvento())
            {
                foreach (Asistente asistente in contexto.Asistentes.ToList())
                {
                    contexto.Asistentes.Remove(asistente);
                }
                contexto.SaveChanges();
            }
        }

        public void VaciarTablaCompras()
        {
            using (var contexto = new ContextoEvento())
            {
                foreach (Compra compra in contexto.Compras.Include(c => c.Codigos).ToList())
                {
                    contexto.Compras.Remove(compra);
                }
                contexto.SaveChanges();
            }
        }

        public void VaciarTablaEntradasVendidas()
        {
            using (var contexto = new ContextoEvento())
            {
                foreach (EntradaVendida entradaVendida in contexto.EntradasVendidas.ToList())
                {
                    contexto.EntradasVendidas.Remove(entradaVendida);
                }
                contexto.SaveChanges();
            }
        }
    }
}
