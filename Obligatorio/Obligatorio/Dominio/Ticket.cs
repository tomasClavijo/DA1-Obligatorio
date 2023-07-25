using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Dominio
{
    public class Ticket
    {
        public int Id { get; set; }
        public Evento Evento { get; set; }

        private string _nombre;
        private int _precio;
        private int _cantidad;

        public string Nombre 
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NombreTicketException();
                }
                _nombre = value;
            }
        }
        public int Precio
        {
            get => _precio;
            set
            {
                if (value <= 0)
                {
                    throw new PrecioTicketException();
                }
                _precio = value;
            }
        }
        public int Cantidad
        {
            get => _cantidad;
            set
            {
                if (value <= 0)
                {
                    throw new CantidadTicketException();
                }
                _cantidad = value;
            }
        }

        public Ticket() { }
    }
}