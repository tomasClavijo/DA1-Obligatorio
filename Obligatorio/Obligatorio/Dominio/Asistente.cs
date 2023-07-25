using Excepciones;

namespace Dominio
{
    public class Asistente : Persona
    {

        private string _cedula;
        public string Cedula
        {
            get => _cedula;
            set 
            { 
                if (string.IsNullOrWhiteSpace(value)) 
                { 
                    throw new CedulaAsistenteException(); 
                }
                _cedula = value;
            }
        }

        public Asistente() : base() { }
    }

}