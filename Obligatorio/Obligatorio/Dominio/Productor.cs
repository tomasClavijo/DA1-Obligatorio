using Excepciones;

namespace Dominio
{
    public class Productor : Persona
    {

        private string _email;
        private string _password;
        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmailProductorException();
                }
                _email = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ContrasenaProductorException();
                }
                _password = value;
            }
        }

        public Productor() : base() { }
    }
}