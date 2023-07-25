using Dominio;

namespace LogicaDeNegocio.Interfaces
{
    public interface ILogicaProductorLogin
    {
        void IniciarSesion(Productor productor);

        bool HayProductorIniciado();
    }
}
