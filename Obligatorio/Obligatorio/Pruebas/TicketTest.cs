using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Excepciones;

namespace PruebasObligatorio
{
    [TestClass]
    public class TicketTest
    {
        [TestMethod]
        public void CrearTicketTest()
        {
            Ticket ticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };
            Assert.AreEqual(ticket.Nombre, "Tribuna Olímpica");
            Assert.AreEqual(ticket.Precio, 2500);
            Assert.AreEqual(ticket.Cantidad, 20000);
        }

        [ExpectedException(typeof(NombreTicketException))]
        [TestMethod]
        public void CrearTicketNombreVacioTest()
        {
            Ticket ticket = new Ticket()
            {
                Nombre = "",
                Precio = 2500,
                Cantidad = 20000,
            };
        }

        [ExpectedException(typeof(PrecioTicketException))]
        [TestMethod]
        public void CrearTicketPrecioNegativoTest()
        {
            Ticket ticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = -200,
                Cantidad = 20000,
            };
        }

        [ExpectedException(typeof(PrecioTicketException))]
        [TestMethod]
        public void CrearTicketPrecio0Test()
        {
            Ticket ticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 0,
                Cantidad = 20000,
            };
        }

        [ExpectedException(typeof(CantidadTicketException))]
        [TestMethod]
        public void CrearTicketCantidadNegativaTest()
        {
            Ticket ticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = -20000,
            };
        }

        [ExpectedException(typeof(CantidadTicketException))]
        [TestMethod]
        public void CrearTicketCantidad0Test()
        {
            Ticket ticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 0,
            };
        }
    }
}