using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class NombrePersonaException : Exception
    {
        public NombrePersonaException() : base("Debe de contener un nombre.") { }
    }

    [Serializable]
    public class ApellidoPersonaException : Exception
    {
        public ApellidoPersonaException() : base("Debe de contener un apellido.") { }
    }
}