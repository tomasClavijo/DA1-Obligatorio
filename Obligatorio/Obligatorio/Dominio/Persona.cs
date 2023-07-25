using Excepciones;

namespace Dominio
{
    public abstract class Persona
    {
        public int Id { get; set; }
        private string _nombre;
        private string _apellido;

        public string Nombre {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NombrePersonaException();
                }
                _nombre = value;
            }
        }

        public string Apellido {
            get => _apellido;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ApellidoPersonaException();
                }
                _apellido = value;
            }
        }

        public Persona() { }
    }
}