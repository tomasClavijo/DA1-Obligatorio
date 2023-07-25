using System;
using System.Collections.Generic;

namespace Dominio
{

    public class Codigo
    {
        public int Id { get; set; }

        public Compra Compra { get; set; }

        public string CodigoCompra { get; set; }

    }

    public class Compra
    {
        public int Id { get; set; }

        public Asistente Asistente { get; set; }

        public List<Codigo> Codigos { get; set; }

        public int Monto { get; set; }
        public DateTime FechaEfectuada { get; set; }

        public Compra() { }
    }
}
