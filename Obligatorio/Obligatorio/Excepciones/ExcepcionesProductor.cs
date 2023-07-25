using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class EmailProductorException : Exception
    {
        public EmailProductorException() : base("Debe de contener un email.") { }
    }
    
    [Serializable]
    public class ContrasenaProductorException : Exception
    {
        public ContrasenaProductorException() : base ("Debe de contener una contrasena.") { }
    }

    public class ProductorExistenteException : Exception
    {
        public ProductorExistenteException(string emailProductor) : base("Ya existe un productor registrado con el correo: " + emailProductor) { }
    }

    public class InicioDeSesionIncorrecto : Exception
    {
        public InicioDeSesionIncorrecto() : base("No existe el productor o los datos son incorrectos.") { }
    }

    public class EventoExistenteException : Exception
    {
        public EventoExistenteException() : base("El evento ya existe.") { }
    }

    public class EventoInexistenteException : Exception
    {
        public EventoInexistenteException() : base("El evento no puede ser eliminado porque no existe.") { }
    }

    public class NoHayComprasRegistradas : Exception
    {
        public NoHayComprasRegistradas() : base("No hay compras registradas.") { }
    }
}