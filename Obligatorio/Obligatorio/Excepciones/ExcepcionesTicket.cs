using System;

namespace Excepciones
{
    [Serializable]
    public class NombreTicketException : Exception
    {
        public NombreTicketException() : base("Debe de contener un nombre.") { }
    }

    public class PrecioTicketException : Exception
    {
        public PrecioTicketException() : base("El precio no puede ser negativo o 0.") { }
    }

    public class CantidadTicketException : Exception
    {
        public CantidadTicketException() : base("La cantidad de tickets no puede ser negativa o 0.") { }
    }
}