using Excepciones;

namespace Dominio
{
    public class CuponValorFijo : Cupon
    {
        private int _valorFijo;
        public int ValorFijo
        {
            get => _valorFijo;
            set
            {
                if (value <= 0)
                {
                    throw new CuponValorFijoCero();
                }
                _valorFijo = value;
            }
        }

        public override int CalcularDescuento(int costoEntrada, int numeroEntradas)
        {
            int nuevoCosto = costoEntrada -_valorFijo;
            return nuevoCosto ;
        }

        public CuponValorFijo() : base() { }
    }
}
