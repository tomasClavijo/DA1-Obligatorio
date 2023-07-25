using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Excepciones
{
    [Serializable]
    public class FechaException : Exception
    {
         public FechaException() : base("La fecha de inicio de debe ser anterior a la fecha de fin") { }
    }

    public class TicketsVaciosFuncionException : Exception
    {
        public TicketsVaciosFuncionException() : base("Cada funcion debe tener almenos un ticket") { }
    }

    public class RestaMayorTicketsExpection : Exception
    {
        public RestaMayorTicketsExpection() : base("Los tickets a restar son mayores a la cantidad restante") { }
    }

    public class RestarCeroException : Exception
    {
        public RestarCeroException() : base("No puede restarse cero") { }
    }

    public class TicketInexistenteException : Exception
    {
        public TicketInexistenteException() : base("El ticket no esta en la lista") { }
    }


}
