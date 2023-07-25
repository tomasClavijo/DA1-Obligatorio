using Excepciones;
using System.Collections.Generic;

namespace Dominio
{
    public enum Categoria
    {
        Conferencias,
        Cursos,
        Deportes,
        Fútbol,
        Música,
        Teatro,
        Otros
    }

    public enum Formato
    {
        Presencial,
        Online
    }

    public class Evento
    {
        public int Id { get; set; }

        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NombreEventoException();
                }
                else if (value.Length > 110)
                {
                    throw new NombreMayorAlLimiteException();
                }
                _nombre = value;
            }
        }

        private Categoria _categoria;
        public Categoria Categoria
        {
            get => _categoria;
            set => _categoria = value;
        }

        public Formato Formato { get; set; }

        private string _descripcion;
        public string Descripcion 
            { 
                get =>_descripcion; 
                set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new DescripcionVaciaEventoException();
                }
                else if(value.Length > 250)
                {
                    throw new DescripcionMayorAlLimiteException();
                }
                _descripcion = value;
            }
        }

        private List<Funcion> _funciones;
        public List<Funcion> Funciones 
        {
            get => _funciones;
            set
            {
                _funciones = value;
            }
        }

        private List<Ticket> _tickets;
        public List<Ticket> Tickets
        {
            get => _tickets;
            set
            {
                _tickets = value;
            }
        }
        private string _direccion;

        public string Direccion
        {
            get => _direccion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new DireccionVaciaEventoException();
                }
                _direccion = value;
            }
        }

        private string _imagen;
        public string Imagen
        {
            get => _imagen;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ImagenVaciaException();
                }
                _imagen = value;
            }
        }

        public bool EsBorrador { get; set; }

        public Evento()
        {
        }
    }
}