using System;
using System.Collections.Generic;
using Dominio;

namespace LogicaDeNegocio.Interfaces
{
    public interface ILogicaProductor
    {
        void RegistrarProductor(Productor nuevoProductor);

        bool ExisteProductor(string email);

        Productor ObtenerProductor(string email);

        void InicioSesionCorrecto(Productor productor);

        void CrearEvento(Evento nuevoEvento);

        Evento ObtenerEvento(string nombreEvento);

        List<Evento> EventosCreados();

        bool ExisteEvento(Evento unEvento);

        bool ExisteEvento(string nombreEvento);

        void CrearEventoBorrador(Evento nuevoEvento);
        
        bool ExisteEventoBorrador(Evento eventoBorrador);

        List<Evento> VisualizarEventosBorrador();

        void PublicarEvento(Evento eventoBorrador);

        void EliminarEvento(Evento evento);

        void EliminarEvento(string nombreEvento);

        List<Compra> ObtenerCompras();

        List<Compra> ObtenerComprasFiltradasCedula(List<Compra> compras, string cedula);

        List<Compra> ObtenerComprasFiltradasMonto(List<Compra> compras, int monto);

        List<Compra> ObtenerComprasFiltradasFecha(List<Compra> compras, DateTime fechaInicial, DateTime fechaFinal);

        void AgregarCupon(Cupon unCupon);

        void ControlarCupon(Cupon cuponAplicado);

        Cupon ObtenerCupon(string codigoCupon);

        void CambiarNombreCupon(Cupon unCupon, string nuevoNombre);

        void CambiarCantidadRestante(Cupon unCupon, int cantidad);

        List<Cupon> ObtenerCupones();

        void AgregarAsistenteEvento(Asistente asistente, Evento evento);

        void ControlarAsistenteEvento(Asistente asistente, Evento evento);

    }
}
