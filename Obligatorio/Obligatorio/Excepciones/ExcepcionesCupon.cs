using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    [Serializable]
    public class NombreCuponException : Exception
    {
        public NombreCuponException() : base("Debe de contener un nombre.") { }
    }
   
    public class CantidadCuponException : Exception
    {
        public CantidadCuponException() : base("La cantidad de cupones no puede ser negativa o 0.") { }
    }

    public class TipoVacioCuponException : Exception
    {
        public TipoVacioCuponException() : base("Debe de contener un tipo.") { }
    }
    public class TipoErroneoCuponException : Exception
    {
        public TipoErroneoCuponException() : base("El tipo del cupon debe ser uno de los dados.") { }
    }

    public class LargoCodigoCuponException : Exception
    {
        public LargoCodigoCuponException() : base("El largo del código del cupón debe de ser de 10 caracteres.") { }
    }

    public class CodigoReservadoException : Exception
    {
        public CodigoReservadoException() : base("El codigo 0000000000 esta reservado, porfavor elija otro codigo") { }
    }

    public class PorcentajeFueraLimitesExcepetion : Exception
    {
        public PorcentajeFueraLimitesExcepetion() : base("El porcentaje debe estar entre 0 y 100") { }
    }

    public class CuponACantidadNegativa : Exception
    {
        public CuponACantidadNegativa() : base("La cantidad debe de ser mayor a 0") { }
    }

    public class CuponACantidadSegundoMenorPrimero : Exception
    {
        public CuponACantidadSegundoMenorPrimero() : base("La cantidad del segundo numero debe de ser menor a la del primero") { }
    }

    public class CuponValorFijoCero : Exception
    {
        public CuponValorFijoCero() : base("El valor del cupon debe de ser mayor a 0") { }
    }

    public class CuponUtilizadoPorAsistente : Exception
    {
        public CuponUtilizadoPorAsistente() : base("El asistente ya ha utilizado un cupon para este evento") { }
    }

    public class NoHayCuponesDisponibles : Exception
    {
        public NoHayCuponesDisponibles(string nombreCupon) : base("No hay cupones disponibles para " + nombreCupon) { }
    }

    public class CuponInexistente : Exception
    {
        public CuponInexistente() : base("Cupon no encontrado, intente nuevamente") { }
    }
}
