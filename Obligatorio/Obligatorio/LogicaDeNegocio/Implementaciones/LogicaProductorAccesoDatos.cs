using System.Linq;
using Dominio;
using LogicaDeNegocio.Interfaces;
using Excepciones;
using AccesoDatos.Interfaces;
using AccesoDatos.Implementaciones;
using System.Collections.Generic;
using System;

namespace LogicaDeNegocio.Implementaciones
{
    public class LogicaProductorAccesoDatos : ILogicaProductor
    {
        private IRepositorioProductor _repositorioProductor { get; }

        public LogicaProductorAccesoDatos(IRepositorioProductor repositorioProductor)
        {
            _repositorioProductor = repositorioProductor;
        }

        public void RegistrarProductor(Productor nuevoProductor)
        {
            if (_repositorioProductor.ExisteProductor(nuevoProductor.Email))
            {
                throw new ProductorExistenteException(nuevoProductor.Email);
            }
            _repositorioProductor.CrearProductor(nuevoProductor);
        }

        public bool ExisteProductor(string email)
        {
            return _repositorioProductor.ExisteProductor(email);
        }

        public Productor ObtenerProductor(string email)
        {
            return _repositorioProductor.ObtenerProductor(email);
        }

        public void InicioSesionCorrecto(Productor productor)
        {
            if (!_repositorioProductor.ExisteProductor(productor.Email))
            {
                throw new InicioDeSesionIncorrecto();
            }
        }

            public void CrearEvento(Evento nuevoEvento)
        {
            if (ExisteEvento(nuevoEvento))
            {
                throw new EventoExistenteException();
            }
            _repositorioProductor.CrearEvento(nuevoEvento);
        }

        public Evento ObtenerEvento(string nombreEvento)
        {
            return _repositorioProductor.ObtenerEvento(nombreEvento);
        }

        public List<Evento> EventosCreados()
        {
            return _repositorioProductor.EventosCreados();
        }

        public bool ExisteEvento(Evento unEvento)
        {
            return _repositorioProductor.ExisteEvento(unEvento);
        }

        public bool ExisteEvento(string nombreEvento)
        {
            return _repositorioProductor.ExisteEvento(nombreEvento);
        }

        public void CrearEventoBorrador(Evento nuevoEvento)
        {
            if (ExisteEvento(nuevoEvento))
            {
                throw new EventoExistenteException();
            }
            _repositorioProductor.CrearEventoBorrador(nuevoEvento);
        }

        public List<Evento> VisualizarEventosBorrador()
        {
            return _repositorioProductor.ObtenerEventosBorrador();
        }

        public void PublicarEvento(Evento unEvento)
        {
            _repositorioProductor.PublicarEvento(unEvento);
        }
        public void EliminarEvento(Evento evento)
        {
            if (!ExisteEvento(evento))
            {
                throw new EventoInexistenteException();
            }
            _repositorioProductor.EliminarEvento(evento);
        }

        public void EliminarEvento(string nombreEvento)
        {
            if (!ExisteEvento(nombreEvento))
            {
                throw new EventoInexistenteException();
            }
            _repositorioProductor.EliminarEvento(nombreEvento);
        }

        public bool ExisteEventoBorrador(Evento eventoBorrador)
        {
            return _repositorioProductor.ExisteEventoBorrador(eventoBorrador);
        }

        public List<Compra> ObtenerCompras()
        {
            List<Compra> compras = _repositorioProductor.ObtenerCompras();
            if (compras.Count > 0)
            {
                return compras;
            }
            throw new NoHayComprasRegistradas();
        }

        public List<Compra> ObtenerComprasFiltradasCedula(List<Compra> compras, string cedula)
        {
            if (cedula != "")
            {
                List<Compra> comprasRetorno = compras.FindAll(c => c.Asistente.Cedula == cedula);
                if (comprasRetorno.Count > 0)
                {
                    return comprasRetorno;
                }
                throw new NoHayComprasRegistradas();
            }
            return compras;
        }

        public List<Compra> ObtenerComprasFiltradasMonto(List<Compra> compras, int monto)
        {
            if (monto != 0)
            {
                List<Compra> comprasRetorno = compras.FindAll(c => c.Monto > monto);
                if (comprasRetorno.Count > 0)
                {
                    return comprasRetorno;
                }
                throw new NoHayComprasRegistradas();
            }
            return compras;
        }

        public List<Compra> ObtenerComprasFiltradasFecha(List<Compra> compras, DateTime fechaInicio, DateTime fechaFinal)
        {
            List<Compra> comprasRetorno = compras.FindAll(c => c.FechaEfectuada >= fechaInicio && c.FechaEfectuada <= fechaFinal);
            if (comprasRetorno.Count > 0)
            {
                return comprasRetorno;
            }
            throw new NoHayComprasRegistradas();
        }

        public void AgregarCupon(Cupon unCupon)
        {
            if (unCupon.Codigo.Equals("0000000000"))
            {
                throw new CodigoReservadoException();
            }
            _repositorioProductor.AgregarCupon(unCupon);
        }

        public void ControlarCupon(Cupon cuponAplicado)
        {
            if (cuponAplicado.CantidadRestante <= 0)
            {
                throw new NoHayCuponesDisponibles(cuponAplicado.Nombre);
            }
        }

        public Cupon ObtenerCupon(string codigoCupon)
        {
            if (codigoCupon.Equals("0000000000"))
            {
                return new CuponPorcentaje()
                {
                    Nombre = "No se aplico cupon",
                    Codigo = codigoCupon,
                    CantidadRestante = 1,
                    Tipo = TipoDescuento.Porcentaje,
                    Porcentaje = 1
                };
            }
            Cupon cuponObtenido = _repositorioProductor.ObtenerCupon(codigoCupon);

            if (cuponObtenido != null)
            {
                return cuponObtenido;
            }
            throw new CuponInexistente(); 
        }

        public void CambiarNombreCupon(Cupon unCupon, string nuevoNombre)
        {
            _repositorioProductor.CambiarNombreCupon(unCupon, nuevoNombre);
        }

        public void CambiarCantidadRestante(Cupon unCupon, int cantidad)
        {
            _repositorioProductor.CambiarCantidadRestante(unCupon, cantidad);

        }

        public List<Cupon> ObtenerCupones()
        {
            return _repositorioProductor.ObtenerCupones();
        }

        public void AgregarAsistenteEvento(Asistente asistente, Evento evento)
        {
            _repositorioProductor.AgregarAsistenteCupon(asistente, evento);
        }

        public void ControlarAsistenteEvento(Asistente asistente, Evento evento)
        {
            if (_repositorioProductor.ControlarAsistenteEvento(asistente, evento))
            {
                throw new CuponUtilizadoPorAsistente();
            }
        }
    }
}
