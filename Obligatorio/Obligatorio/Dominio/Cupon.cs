using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Dominio
{
    public enum TipoDescuento
    {
        Porcentaje,
        ValorFijo,
        CantidadDeEntradas,
    }
    public abstract class Cupon
    {
        public Dictionary<TipoDescuento, string> tipoDescuentoMensaje = new Dictionary<TipoDescuento, String>()
        { 
            {TipoDescuento.Porcentaje,"A porcentaje"},
            {TipoDescuento.ValorFijo,"A un valor fijo"},
            {TipoDescuento.CantidadDeEntradas,"A cantidad de entradas" }
        };

        private string _nombre;
        private string _codigo;
        private int _cantidadRestante;
        private TipoDescuento _tipo;

        public int Id { get; set; }

        public TipoDescuento Tipo
        {
            get => _tipo;
            set
            {
                _tipo = value;
            }
        }

        public string Nombre { 
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NombreCuponException();
                }
                _nombre = value;
            }
        }

        public int CantidadRestante
        {
            get => _cantidadRestante;
            set
            {
                if (value < 0)
                {
                    throw new CantidadCuponException();
                }
                _cantidadRestante = value;
            }
        }

        public string Codigo
        {
            get => _codigo;
            set
            {
                if (value.Length < 10 || value.Length > 10)
                {
                    throw new LargoCodigoCuponException();
                }
                else
                {
                    _codigo = value;
                }
            }
        }

        public virtual int CalcularDescuento(int costoEntrada,int numeroEntradas) { return 0; }
        public Cupon() { }
    }
}
