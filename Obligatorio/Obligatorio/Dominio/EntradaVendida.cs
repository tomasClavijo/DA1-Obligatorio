using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class EntradaVendida
    {
        public int Id { get; set; }

        public Categoria Categoria { get; set; }

        public int Monto { get; set; }

        public EntradaVendida() { }
    }
}
