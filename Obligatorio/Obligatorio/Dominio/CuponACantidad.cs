using Excepciones;

namespace Dominio
{
    public class CuponACantidad : Cupon
    {
        private int _primerValor;
        public int PrimerValor
        {
            get => _primerValor;
            set
            {
                if (value <= 0)
                {
                    throw new CuponACantidadNegativa();
                }
                _primerValor = value;
            }
        }

        private int _segundoValor;
        public int SegundoValor {
            get => _segundoValor;
            set {
                if (value > PrimerValor)
                {
                    throw new CuponACantidadSegundoMenorPrimero();
                }
                _segundoValor = value;
            }
        }

        public override int CalcularDescuento(int costoEntrada, int numeroEntradas)
        {
            int cociente = numeroEntradas / _primerValor;
            int resto = numeroEntradas %_primerValor;
            int aux = cociente * _segundoValor;
            aux += resto;
            return ((aux * costoEntrada)/numeroEntradas);
        }

        public CuponACantidad() : base() { }

    }
}
