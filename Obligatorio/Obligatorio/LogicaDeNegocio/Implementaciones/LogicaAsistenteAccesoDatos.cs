using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos.Interfaces;
using LogicaDeNegocio.Interfaces;
using Excepciones;

namespace LogicaDeNegocio.Implementaciones
{
    public class LogicaAsistenteAccesoDatos : ILogicaAsistente
    {

        public const int CANTIDAD_MAXIMA_TICKETS = 10;
        public const int CERO_TICKETS = 0;

        private IRepositorioAsistente _repositorioAsistente { get; }

        public LogicaAsistenteAccesoDatos(IRepositorioAsistente repositorioAsistente)
        {
            _repositorioAsistente = repositorioAsistente;
        }

        public List<Evento> VisualizarEventos()
        {
            List<Evento> eventosDisponibles = new List<Evento>();
            foreach (Evento evento in OrdenarEventosPorFechaYNombre())
            {

                Evento eventoFuturo = new Evento()
                {
                    Nombre = evento.Nombre,
                    Descripcion = evento.Descripcion,
                    Categoria = evento.Categoria,
                    Formato = evento.Formato,
                    Tickets = evento.Tickets,
                    Funciones = evento.Funciones,
                    Direccion = evento.Direccion,
                    Imagen = evento.Imagen
                };

                List<Funcion> funcionesFuturo = new List<Funcion>();
                bool tieneTickets = false;

                foreach (Funcion funcion in evento.Funciones)
                {

                    if (DateTime.Now <= funcion.FechaInicio)
                    {
                        List<Ticket> nuevosTickets = new List<Ticket> { };
                        foreach (ParTicketCantidad parTicketCantidad in funcion.ListaTickets)
                        {
                            if (funcion.ConsultarCantidadTickets(parTicketCantidad.Ticket) > 0)
                            {
                                nuevosTickets.Add(parTicketCantidad.Ticket);
                                tieneTickets = true;
                            }
                        }
                        if (tieneTickets)
                        {
                            Funcion nuevaFuncion = new Funcion(funcion.FechaInicio, funcion.FechaFin, nuevosTickets);
                            funcionesFuturo.Add(nuevaFuncion);
                        }
                    }
                }

                if (funcionesFuturo.Count != 0)
                {
                    eventoFuturo.Funciones = funcionesFuturo;
                    eventosDisponibles.Add(eventoFuturo);
                }
            }
            return eventosDisponibles;
        }

        public List<Evento> OrdenarEventosPorFecha()
        {
            return _repositorioAsistente.ObtenerEventos().OrderBy(x => x.Funciones[0].FechaInicio).ToList();
        }

        public List<Evento> OrdenarEventosPorFechaYNombre()
        {
            List<Evento> eventos = _repositorioAsistente.ObtenerEventos();
            return eventos.OrderBy(x => x.Nombre).OrderBy(x => x.Funciones[0].FechaInicio).ToList();
        }

        public List<Evento> OrdenarEventosPorNombre()
        {
            return _repositorioAsistente.ObtenerEventos().OrderBy(x => x.Nombre).ToList();
        }

        public Dictionary<Categoria, int> CantidadCategoria()
        {
            Dictionary<Categoria, int> cantidadCategoria = new Dictionary<Categoria, int>
            {
                { Categoria.Música, 0 },
                { Categoria.Teatro, 0 },
                { Categoria.Cursos, 0 },
                { Categoria.Conferencias, 0 },
                { Categoria.Deportes, 0 },
                { Categoria.Fútbol, 0 },
                { Categoria.Otros, 0 }
            };

            foreach (Evento evento in VisualizarEventos())
            {
                foreach (Categoria categoria in Enum.GetValues(typeof(Categoria)))
                {
                    if (categoria == evento.Categoria)
                    {
                        cantidadCategoria[categoria]++;
                    }
                }
            }

            return cantidadCategoria;
        }
        public List<Evento> FiltrarPorCategoria(Categoria categoria)
        {
            List<Evento> listaDeCategoria = new List<Evento>();
            foreach (Evento evento in this.VisualizarEventos())
            {
                if (categoria == evento.Categoria)
                {
                    listaDeCategoria.Add(evento);
                }
            }
            return listaDeCategoria;
        }

        public List<Evento> FiltrarEventosEntreFechas(DateTime fechaInicio, DateTime fechaFin, List<Evento> eventos)
        {
            return eventos.FindAll(x => x.Funciones.Find(y => y.FechaInicio >= fechaInicio && y.FechaFin <= fechaFin) != null);
        }

        public List<Evento> FiltrarEventosPorNombre(string nombreEvento, List<Evento> eventos)
        {
            return eventos.FindAll(x => x.Nombre.Contains(nombreEvento));
        }

        public Dictionary<Categoria, int> GenerarReporte(int precioMin, int precioMax)
        {
            Dictionary<Categoria, int> resultado = new Dictionary<Categoria, int>();

            foreach ((Categoria, int) valor in _repositorioAsistente.ObtenerEntradasVendidas())
            {
                if (valor.Item2 >= precioMin && valor.Item2 <= precioMax)
                {
                    if (resultado.ContainsKey(valor.Item1))
                    {
                        resultado[valor.Item1] += 1;
                    }
                    else
                    {
                        resultado.Add(valor.Item1, 1);
                    }
                }
            }
            return resultado;
        }

        public Compra ComprarYRegistrar(Evento eventoComprar, Funcion funcionComprar, List<(Ticket, int)> ticketsComprados, Asistente asistente, DateTime? fechaComprado = null)
        {
            CompraCorrecta(ticketsComprados);
            foreach ((Ticket, int) ticketComprado in ticketsComprados)
            {
                ComprarTickets(eventoComprar, funcionComprar, ticketComprado.Item1, ticketComprado.Item2);
            }
            return RegistrarCompra(eventoComprar, ticketsComprados, asistente, fechaComprado);
        }

        public void CompraCorrecta(List<(Ticket, int)> ticketsComprados,Funcion funcionComprar=null)
        {
            foreach ((Ticket, int) ticketComprado in ticketsComprados)
            {
                if (ticketComprado.Item2 == 0)
                {
                    throw new RestarCeroException();
                }
                else
                {
                    if (funcionComprar !=null && ticketComprado.Item2 > funcionComprar.ConsultarCantidadTickets(ticketComprado.Item1))
                    {
                        throw new RestaMayorTicketsExpection();
                    }
                }
            }
        }

        public void ComprarTickets(Evento eventoComprar, Funcion funcionComprar, Ticket ticketComprar, int cantidadComprar)
        {
            _repositorioAsistente.ComprarTickets(eventoComprar, funcionComprar, ticketComprar, cantidadComprar);
        }

        public Compra RegistrarCompra(Evento eventoComprar, List<(Ticket, int)> ticketsComprados, Asistente asistente, DateTime? fechaComprado = null)
        {

            int montoTotal = 0;
            List<Codigo> codigos = new List<Codigo>();

            foreach ((Ticket, int) ticketComprado in ticketsComprados)
            {
                montoTotal += (ticketComprado.Item1.Precio * ticketComprado.Item2);

                for (int i = 0; i < ticketComprado.Item2; i++)
                {
                    Codigo nuevoCodigo = new Codigo()
                    {
                        CodigoCompra = GenerarCodigo()
                    };
                    codigos.Add(nuevoCodigo);
                }
            }

            if (!fechaComprado.HasValue)
            {
                fechaComprado = DateTime.Now;
            }

            Compra nuevaCompra = new Compra()
            {
                Asistente = asistente,
                Codigos = codigos,
                Monto = montoTotal,
                FechaEfectuada = (DateTime)fechaComprado
            };

            _repositorioAsistente.RegistrarCompra(nuevaCompra, eventoComprar, ticketsComprados);
            return nuevaCompra;
        }

        public int ConsultarCantidadTicketFuncion(Evento evento, Funcion funcion, Ticket ticket)
        {
            return _repositorioAsistente.ConsultarCantidadTicketFuncion(evento, funcion, ticket);
        }

        public Compra ObtenerCompra(Evento evento, Funcion funcion, Asistente asistente, List<(Ticket, int)> compra)
        {
            return _repositorioAsistente.ObtenerCompra(evento, funcion, asistente, compra);
        }



        private string GenerarCodigo()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }



        public void ControlarTotal(int unTotal)
        {
            if (unTotal > CANTIDAD_MAXIMA_TICKETS)
            {
                throw new TotalMayorA10Exception();
            }
            if (unTotal == CERO_TICKETS)
            {
                throw new TotalIgualCeroException();
            }
        }

 
    }
}
