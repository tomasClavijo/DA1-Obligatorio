using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class NombreEventoException : Exception
    {
        public NombreEventoException() : base("Debe de contener un nombre.") { }
    }

    public class NombreMayorAlLimiteException : Exception
    {
        public NombreMayorAlLimiteException() : base("El nombre no debe ser mayor a 110.") { }
    }

    public class DescripcionVaciaEventoException : Exception
    {
        public DescripcionVaciaEventoException() : base("Debe de contener una descripcion.") { }
    }

    public class DireccionVaciaEventoException : Exception
    {
        public DireccionVaciaEventoException() : base("Debe de contener una direccion.") { }
    }


    public class DescripcionMayorAlLimiteException : Exception
    {
        public DescripcionMayorAlLimiteException() : base("La descripcion no debe ser mayor a 250.") { }
    }

    public class EventoSinFuncionesException : Exception
    {
        public EventoSinFuncionesException() : base("Los eventos deben tener al menos una funcion.") { }
    }

    public class EventoSinTicketsException : Exception
    {
        public EventoSinTicketsException() : base("Los eventos deben tener al menos un tipo de ticket.") { }
    }

    [Serializable]
    public class ImagenVaciaException : Exception
    {
        public ImagenVaciaException() : base("Los eventos deben contener una imagen.") { }
    }
}
