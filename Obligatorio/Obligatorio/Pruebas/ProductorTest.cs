using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System;
using Excepciones;

namespace PruebasObligatorio
{
    [TestClass]
    public class ProductorTest
    {
        [ExpectedException(typeof(NombrePersonaException))]
        [TestMethod]
        public void ProductorNombreVacio()
        {
            Productor unProductor = new Productor
            {
                Nombre = "",
                Apellido = "González",
                Email = "gonzález@gmail.com",
                Password = "gonzálezpassword"
            };
        }

        [ExpectedException(typeof(ApellidoPersonaException))]
        [TestMethod]
        public void ProductorApellidoVacio()
        {
            Productor unProductor = new Productor
            {
                Nombre = "Juan",
                Apellido = "",
                Email = "gonzález@gmail.com",
                Password = "gonzálezpassword"
            };
        }

        [ExpectedException(typeof(EmailProductorException))]
        [TestMethod]
        public void ProductorEmailVacio()
        {
            Productor unProductor = new Productor
            {
                Nombre = "Juan",
                Apellido = "González",
                Email = "",
                Password = "gonzálezpassword"
            };
        }

        [ExpectedException(typeof(ContrasenaProductorException))]
        [TestMethod]
        public void ProductorContrasenaVacio()
        {
            Productor unProductor = new Productor
            {
                Nombre = "Juan",
                Apellido = "González",
                Email = "gonzález@gmail.com",
                Password = ""
            };
        }

        [TestMethod]
        public void ProductorConTodosLosDatos()
        {
            Productor unProductor = new Productor
            {
                Nombre = "Juan",
                Apellido = "González",
                Email = "gonzález@gmail.com",
                Password = "gonzálezpassword"
            };
            Assert.AreEqual(unProductor.Nombre, "Juan");
            Assert.AreEqual(unProductor.Apellido, "González");
            Assert.AreEqual(unProductor.Email, "gonzález@gmail.com");
            Assert.AreEqual(unProductor.Password, "gonzálezpassword");
        }
    }
}