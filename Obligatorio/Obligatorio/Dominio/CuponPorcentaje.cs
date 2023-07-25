using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Dominio
{
    public class CuponPorcentaje : Cupon
    {
        private int _porcentaje;
        public int Porcentaje
        {
            get => _porcentaje;
            set
            {
                if(value<1 || value > 100)
                {
                    throw new PorcentajeFueraLimitesExcepetion();
                }
                _porcentaje = value;
            }
        }

        public override int CalcularDescuento(int costoEntrada, int numeroEntradas)
        {
            int nuevoCosto = costoEntrada * (100 -_porcentaje) /100;
            //reducir costo a 0?
            return nuevoCosto ;
        }

        public  CuponPorcentaje() : base()  { }

    }
}
