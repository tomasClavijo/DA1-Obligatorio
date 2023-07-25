using DatosEnMemoria;
using Dominio;
using Excepciones;
using LogicaDeNegocio.Interfaces;

namespace LogicaDeNegocio.Implementaciones
{
    public class LogicaProductorLogin : ILogicaProductorLogin
    {
        private Datos _datosMemoria { get; }

        public LogicaProductorLogin(Datos nuevosDatos)
        {
            _datosMemoria = nuevosDatos;
        }

        public void IniciarSesion(Productor productor)
        {
            if (productor != null)
            {
                _datosMemoria.IniciarSesion(productor);
            }
            else
            {
                throw new InicioDeSesionIncorrecto();
            }
        }

        public bool HayProductorIniciado()
        {
            return _datosMemoria.ProductorIniciado != null;
        }
    }
}
