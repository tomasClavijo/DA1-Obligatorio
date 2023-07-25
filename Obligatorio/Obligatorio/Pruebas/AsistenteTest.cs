using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Excepciones;

namespace PruebasObligatorio
{
    [TestClass]
    public class AsistenteTest
    {
        [ExpectedException(typeof(NombrePersonaException))]
        [TestMethod]
        public void AsistenteNombreVacio()
        {
            Asistente unAsistente = new Asistente
            {
                Nombre = "",
                Apellido = "Irabedra",
                Cedula = "5.209.134-2"
            };
        }

        [ExpectedException(typeof(ApellidoPersonaException))]
        [TestMethod]
        public void AsistenteApellidoVacio()
        {
            Asistente unAsistente = new Asistente
            {
                Nombre = "Juan",
                Apellido = "",
                Cedula = "5.209.134-2"
            };
        }

        [ExpectedException(typeof(CedulaAsistenteException))]
        [TestMethod]
        public void AsistenteCedulaVacia()
        {
            Asistente unAsistente = new Asistente
            {
                Nombre = "Juan",
                Apellido = "Irabedra",
                Cedula = ""
            };
        }

        [TestMethod]
        public void AsistenteCedulaCorrecta()
        {
            Asistente unAsistente = new Asistente
            {
                Nombre = "Juan",
                Apellido = "Irabedra",
                Cedula = "5.209.134-2"
            };
            Assert.AreEqual("5.209.134-2", unAsistente.Cedula);
        }

        [TestMethod]
        public void AsistenteDatosCompletos()
        {
            Asistente unAsistente = new Asistente
            {
                Nombre = "Juan",
                Apellido = "Irabedra",
                Cedula = "5.209.134-2"
            };
        }

    }


}