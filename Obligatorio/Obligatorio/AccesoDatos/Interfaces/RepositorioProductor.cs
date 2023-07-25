using System;
using System.Collections.Generic;
using Dominio;

namespace AccesoDatos.Interfaces
{
    public interface IRepositorioProductor
    {
        void CrearProductor(Productor productor);

        Productor ObtenerProductor(string emailProductor);

        bool ExisteProductor(string email);

        void CrearEvento(Evento nuevoEvento);

        Evento ObtenerEvento(string nombreEvento);

        List<Evento> EventosCreados();

        bool ExisteEvento(Evento unEvento);

        bool ExisteEvento(string nombreEvento);

        bool ExisteEventoBorrador(Evento unEvento);

        void CrearEventoBorrador(Evento nuevoEvento);

        List<Evento> ObtenerEventosBorrador();

        void PublicarEvento(Evento evento);

        void EliminarEvento(Evento evento);

        void EliminarEvento(string nombreEvento);

        List<Compra> ObtenerCompras();

        void AgregarCupon(Cupon unCupon);

        Cupon ObtenerCupon(string codigoCupon);

        void CambiarNombreCupon(Cupon unCupon, string nuevoNombre);

        void CambiarCantidadRestante(Cupon cupon, int cantidad);

        List<Cupon> ObtenerCupones();

        bool ControlarAsistenteEvento(Asistente asistente, Evento evento);

        void AgregarAsistenteCupon(Asistente asistente, Evento evento);

        void VaciarTablaProductores();

        void VaciarTablaEventos();

        void VaciarTablaCupones();

        void VaciarTablaAsistentesCuponesEventos();
    }
}
