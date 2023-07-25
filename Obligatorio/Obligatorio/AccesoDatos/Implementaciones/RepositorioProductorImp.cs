using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AccesoDatos.Interfaces;
using Dominio;

namespace AccesoDatos.Implementaciones
{
    public class RepositorioProductorImp : IRepositorioProductor
    {
        public void CrearProductor(Productor productor)
        {
            using (var contexto = new ContextoEvento())
            {
                contexto.Productores.Add(productor);
                contexto.SaveChanges();
            }
        }

        public Productor ObtenerProductor(string emailProductor)
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Productores.FirstOrDefault(p => p.Email == emailProductor);
            }
        }

        public bool ExisteProductor(string emailProductor)
        {
            bool retorno = ObtenerProductor(emailProductor) != null;
            return retorno;
        }

        public void CrearEvento(Evento nuevoEvento)
        {
            using (var contexto = new ContextoEvento())
            {
                contexto.Eventos.Add(nuevoEvento);
                contexto.SaveChanges();
            }
        }

        public Evento ObtenerEvento(string nombreEvento)
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Eventos.Include(e => e.Funciones.Select(f => f.ListaTickets))
                                       .Include(e => e.Tickets)
                                       .FirstOrDefault(e => e.Nombre == nombreEvento);
            }
        }

        public List<Evento> EventosCreados()
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Eventos.Include(e => e.Funciones.Select(f => f.ListaTickets))
                                       .Include(e => e.Tickets)
                                       .Where(e => !e.EsBorrador).ToList();
            }
        }

        public bool ExisteEvento(Evento unEvento)
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Eventos.FirstOrDefault(e => e.Nombre == unEvento.Nombre) != null;
            }
        }

        public bool ExisteEvento(string nombreEvento)
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Eventos.FirstOrDefault(e => e.Nombre == nombreEvento) != null;
            }
        }

        public void CrearEventoBorrador(Evento nuevoEvento)
        {
            using (var contexto = new ContextoEvento())
            {
                contexto.Eventos.Add(nuevoEvento);
                contexto.SaveChanges();
            }
        }

        public List<Evento> ObtenerEventosBorrador()
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Eventos.Include(e => e.Funciones.Select(f => f.ListaTickets))
                                       .Include(e => e.Tickets)
                                       .ToList().FindAll(e => e.EsBorrador);
            }
        }

        public bool ExisteEventoBorrador(Evento unEvento)
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Eventos.FirstOrDefault(e => e.Nombre == unEvento.Nombre && e.EsBorrador) != null;
            }
        }

        public void PublicarEvento(Evento evento)
        {
            using (var contexto = new ContextoEvento())
            {
                Evento eventoBorrador = contexto.Eventos.FirstOrDefault(e => e.Nombre == evento.Nombre);
                eventoBorrador.EsBorrador = false;
                contexto.SaveChanges();
            }
        }

        public void EliminarEvento(Evento eventoBorrar)
        {
            using (var contexto = new ContextoEvento())
            {
                Evento evento = contexto.Eventos.FirstOrDefault(e => e.Nombre == eventoBorrar.Nombre);
                contexto.Eventos.Remove(evento);
                contexto.SaveChanges();
            }
        }

        public void EliminarEvento(string nombreEvento)
        {
            using (var contexto = new ContextoEvento())
            {
                Evento evento = contexto.Eventos.FirstOrDefault(e => e.Nombre == nombreEvento);
                contexto.Eventos.Remove(evento);
                contexto.SaveChanges();
            }
        }

        public List<Compra> ObtenerCompras()
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Compras
                    .Include(c => c.Asistente)
                    .Include(c => c.Codigos)
                    .ToList();
            }
        }

        public void AgregarCupon(Cupon unCupon)
        {
            using (var contexto = new ContextoEvento())
            {
                contexto.Cupones.Add(unCupon);
                contexto.SaveChanges();
            }
        }

        public Cupon ObtenerCupon(string codigoCupon)
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Cupones.FirstOrDefault(c => c.Codigo == codigoCupon);
            }
        }

        public void CambiarNombreCupon(Cupon cupon, string nuevoNombre)
        {
            using (var contexto = new ContextoEvento())
            {
                Cupon cuponModificar = contexto.Cupones.FirstOrDefault(c => c.Codigo == cupon.Codigo);
                cuponModificar.Nombre = nuevoNombre;
                contexto.SaveChanges();
            }
        }

        public void CambiarCantidadRestante(Cupon cupon, int cantidad)
        {
            using (var contexto = new ContextoEvento())
            {
                Cupon cuponModificar = contexto.Cupones.FirstOrDefault(c => c.Codigo == cupon.Codigo);
                cuponModificar.CantidadRestante = cantidad;
                contexto.SaveChanges();
            }
        }

        public List<Cupon> ObtenerCupones()
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.Cupones.ToList();
            }
        }

        public bool ControlarAsistenteEvento(Asistente asistente, Evento evento)
        {
            using (var contexto = new ContextoEvento())
            {
                return contexto.AsistentesCuponesEventos.FirstOrDefault(a => a.CedulaAsistente == asistente.Cedula && a.NombreEvento == evento.Nombre) != null;
            }
        }

        public void AgregarAsistenteCupon(Asistente asistente, Evento evento)
        {
            using (var contexto = new ContextoEvento())
            {
                contexto.AsistentesCuponesEventos.Add(new AsistenteCuponEvento() { CedulaAsistente = asistente.Cedula, NombreEvento = evento.Nombre } );
                contexto.SaveChanges();
            }
        }

        public void VaciarTablaProductores()
        {
            using (var contexto = new ContextoEvento())
            {
                foreach (Productor productor in contexto.Productores.ToList())
                {
                    contexto.Productores.Remove(productor);
                }
                contexto.SaveChanges();
            }
        }

        public void VaciarTablaEventos()
        {
            using (var contexto = new ContextoEvento())
            {
                foreach (Evento evento in contexto.Eventos.Include(e => e.Funciones.Select(f => f.ListaTickets))
                                                          .Include(e => e.Tickets)
                                                          .ToList())
                {
                    contexto.Eventos.Remove(evento);
                }
                contexto.SaveChanges();
            }
        }

        public void VaciarTablaCupones()
        {
            using (var contexto = new ContextoEvento())
            {
                foreach (Cupon cupon in contexto.Cupones.ToList())
                {
                    contexto.Cupones.Remove(cupon);
                }
                contexto.SaveChanges();
            }
        }

        public void VaciarTablaAsistentesCuponesEventos()
        {
            using (var contexto = new ContextoEvento())
            {
                foreach (AsistenteCuponEvento asistenteCuponEvento in contexto.AsistentesCuponesEventos.ToList())
                {
                    contexto.AsistentesCuponesEventos.Remove(asistenteCuponEvento);
                }
                contexto.SaveChanges();
            }
        }
    }
}
