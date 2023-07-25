using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System;
using Excepciones;
using System.Collections.Generic;

namespace PruebasObligatorio
{
    [TestClass]
    public class FuncionTest
    {
        [TestMethod]
        [ExpectedException(typeof(FechaException))]
        public void FechasContradictorias()
        {
            List<Ticket> listavacia = new List<Ticket>();
            DateTime Fecha1 = new DateTime(2003, 7, 31, 12, 0, 0);
            DateTime Fecha2 = new DateTime(2002, 1, 18, 0, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listavacia);
        }

        [TestMethod]
        public void MostrarTicketsDisponiblesEnFuncion()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket unticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 1,
            };
            listatickets.Add(unticket);
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listatickets, true);
            Assert.AreEqual(true, funcion.MostrarDisponibles);
        }

        [TestMethod]
        [ExpectedException(typeof(TicketsVaciosFuncionException))]
        public void TicketsVacio()
        {
            List<Ticket> listavacia = new List<Ticket>();
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listavacia);
        }


        [TestMethod]
        [ExpectedException(typeof(RestaMayorTicketsExpection))]
        public void RestaMayorTickets()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket unticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 1,
            };
            listatickets.Add(unticket);
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listatickets);
            funcion.RestarCantidadTickets(unticket, 2);
        }



        [TestMethod]
        [ExpectedException(typeof(RestarCeroException))]
        public void RestaCeroTickets()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket unticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 1,
            };
            listatickets.Add(unticket);
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listatickets);
            funcion.RestarCantidadTickets(unticket, 0);
        }

        [TestMethod]
        public void RestarTicketsCorrecto()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket unticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 100,
            };
            listatickets.Add(unticket);
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listatickets);
            funcion.RestarCantidadTickets(unticket, 50);
            Assert.AreEqual(50, funcion.ConsultarCantidadTickets(unticket));
        }

        [TestMethod]
        public void RestarTicketsDeUnaFuncion()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket unticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 100,
            };
            listatickets.Add(unticket);

            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion1 = new Funcion(Fecha1, Fecha2, listatickets);


            DateTime Fecha3 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha4 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion2 = new Funcion(Fecha1, Fecha2, listatickets);

            funcion1.RestarCantidadTickets(unticket, 50);
            Assert.AreEqual(50, funcion1.ConsultarCantidadTickets(unticket));
            Assert.AreEqual(100, funcion2.ConsultarCantidadTickets(unticket));
        }

        [TestMethod]
        public void RestarTicketsDistintosDeFuncionesDistintas()
        {
            List<Ticket> listaTickets = new List<Ticket>();
            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 100,
            };
            Ticket ticket2 = new Ticket()
            {
                Nombre = "Platea Olímpica",
                Precio = 3500,
                Cantidad = 20,
            };
            listaTickets.Add(ticket1);
            listaTickets.Add(ticket2);

            DateTime fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion1 = new Funcion(fecha1, fecha2, listaTickets);


            DateTime fecha3 = new DateTime(2008, 8, 2, 0, 0, 0);
            DateTime fecha4 = new DateTime(2008, 8, 2, 12, 0, 0);
            Funcion funcion2 = new Funcion(fecha3, fecha4, listaTickets);

            funcion1.RestarCantidadTickets(ticket1, 50);
            Assert.AreEqual(50, funcion1.ConsultarCantidadTickets(ticket1));
            Assert.AreEqual(20, funcion2.ConsultarCantidadTickets(ticket2));

            funcion2.RestarCantidadTickets(ticket1, 90);
            funcion2.RestarCantidadTickets(ticket2, 15);
            Assert.AreEqual(10, funcion2.ConsultarCantidadTickets(ticket1));
            Assert.AreEqual(5, funcion2.ConsultarCantidadTickets(ticket2));
        }

        [TestMethod]
        [ExpectedException(typeof(TicketInexistenteException))]
        public void TicketNoExistente()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 1,
            };
            Ticket ticket2 = new Ticket()
            {
                Nombre = "Tribuna Mercedes",
                Precio = 2500,
                Cantidad = 1,
            };
            listatickets.Add(ticket1);
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listatickets);
            funcion.RestarCantidadTickets(ticket2, 2);
        }

        [TestMethod]
        public void ConsultarTicket()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket unticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 1,
            };
            listatickets.Add(unticket);
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listatickets);
            Assert.AreEqual(funcion.ConsultarCantidadTickets(unticket), unticket.Cantidad);
        }

        [TestMethod]
        public void RestaTickets()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket unticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 10,
            };
            listatickets.Add(unticket);
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listatickets);
            funcion.RestarCantidadTickets(unticket, 5);
            Assert.AreEqual(funcion.ConsultarCantidadTickets(unticket), 5);
        }
        [TestMethod]
        public void TicketsRestantesNoVisibles()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket unticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 1,
            };
            listatickets.Add(unticket);
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listatickets);
            Assert.IsFalse(funcion.MostrarDisponibles);
        }

        [TestMethod]
        public void CambiarVisibilidadTickets()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket unticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 1,
            };
            listatickets.Add(unticket);
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listatickets);
            funcion.MostrarDisponibles = true;
            Assert.IsTrue(funcion.MostrarDisponibles);
        }

        [TestMethod]
        public void FuncionCompleta()
        {
            List<Ticket> listatickets = new List<Ticket>();
            Ticket unticket = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 1,
            };
            listatickets.Add(unticket);
            DateTime Fecha1 = new DateTime(2008, 8, 1, 0, 0, 0);
            DateTime Fecha2 = new DateTime(2008, 8, 1, 12, 0, 0);
            List<ParTicketCantidad> ListaTicketsCantidad = new List<ParTicketCantidad>();
            ParTicketCantidad nuevoPar = new ParTicketCantidad(unticket, unticket.Cantidad);
            ListaTicketsCantidad.Add(nuevoPar);
            Funcion funcion = new Funcion(Fecha1, Fecha2, listatickets);
            Assert.AreEqual(funcion.FechaInicio, Fecha1);
            Assert.AreEqual(funcion.FechaFin, Fecha2);
            Assert.IsTrue(CompararListasTicketsCantidad(funcion.ListaTickets, ListaTicketsCantidad));
        }

        private bool CompararListasTicketsCantidad(List<ParTicketCantidad> ListaTicketsCantidad1, List<ParTicketCantidad> ListaTicketsCantidad2)
        {
            if (ListaTicketsCantidad1.Count != ListaTicketsCantidad2.Count)
            {
                return false;
            }
            for (int i = 0; i < ListaTicketsCantidad1.Count; i++)
            {
                if (ListaTicketsCantidad1[i].Ticket != ListaTicketsCantidad2[i].Ticket || ListaTicketsCantidad1[i].Cantidad != ListaTicketsCantidad2[i].Cantidad)
                {
                    return false;
                }
            }
            return true;
        }
    }
}