using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    [Serializable]
    public class CedulaAsistenteException : Exception
    {
        public CedulaAsistenteException() : base("Debe de contener una cédula") { }
    }
    public class TotalMayorA10Exception : Exception
    {
        public TotalMayorA10Exception() : base("No se permite comprar más de 10 tickets.") { }
    }

    public class TotalIgualCeroException : Exception
    {
        public TotalIgualCeroException() : base("No se permite comprar 0 tickets.") { }
    }
}