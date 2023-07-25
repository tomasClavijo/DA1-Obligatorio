using DatosEnMemoria;
using Dominio;
using Excepciones;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaDeNegocio.Implementaciones;
using LogicaDeNegocio.Interfaces;
using AccesoDatos.Implementaciones;

namespace PruebasObligatorio
{
    [TestClass]
    public class LogicaAsistenteTest
    {

        private static RepositorioProductorImp _repositorioProductor = new RepositorioProductorImp();
        private static RepositorioAsistenteImp _repositorioAsistente = new RepositorioAsistenteImp();

        [TestInitialize]
        public void LimpiarBase()
        {
            _repositorioProductor.VaciarTablaProductores();
            _repositorioProductor.VaciarTablaEventos();
            _repositorioAsistente.VaciarTablaCompras();
            _repositorioAsistente.VaciarTablaAsistentes();
            _repositorioAsistente.VaciarTablaEntradasVendidas();
        }

        [TestMethod]
        public void VisualizarUnEvento()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna América",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 3, 2, 12, 0, 0),
                                  new DateTime(2022, 3, 2, 14, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2022, 8, 7, 12, 0, 0),
                                  new DateTime(2022, 8, 7, 14, 0, 0),
                                  listaTickets);

            List<Funcion> listaFunciones = new List<Funcion>
            {
                funcion1,
                funcion2
            };

            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };


            _logicaProductorAccesoDatos.CrearEvento(evento);

            List<Evento> listaEventosDisponibles = _logicaAsistenteAccesoDatos.VisualizarEventos();

            Assert.AreEqual(funcion2.FechaInicio, listaEventosDisponibles[0].Funciones[0].FechaInicio);
            Assert.AreEqual(funcion2.FechaFin, listaEventosDisponibles[0].Funciones[0].FechaFin);
        }

        [TestMethod]
        public void VisualizarEventosOrdenadosPorNombre()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };

            Ticket ticket3 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets3 = new List<Ticket>
            {
                ticket3
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 3, 2, 12, 0, 0),
                                  new DateTime(2022, 3, 2, 14, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2022, 8, 7, 12, 0, 0),
                                  new DateTime(2022, 8, 7, 14, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1,
                funcion2
            };

            Funcion funcion3 = new Funcion(new DateTime(2022, 4, 3, 12, 0, 0),
                                  new DateTime(2022, 4, 3, 14, 0, 0),
                                  listaTickets2);
            Funcion funcion4 = new Funcion(new DateTime(2022, 9, 8, 12, 0, 0),
                                  new DateTime(2022, 9, 8, 14, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion3,
                funcion4
            };


            Funcion funcion5 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets3);
            Funcion funcion6 = new Funcion(new DateTime(2022, 10, 8, 12, 0, 0),
                                  new DateTime(2022, 10, 8, 14, 0, 0),
                                  listaTickets3);

            List<Funcion> listaFunciones3 = new List<Funcion>
            {
                funcion5,
                funcion6
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Jorge Drexler",
                Descripcion = "Tras más de cuatro años de silencio discográfico, el cantante y compositor uruguayo Jorge Drexler presenta su nuevo álbum, “Tinta y tiempo”",
                Categoria = Categoria.Música,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            Evento evento3 = new Evento()
            {
                Nombre = "Andrés Calamaro",
                Descripcion = "Luego de 3 años de ausencia de los escenarios regresa a Uruguay uno de los maximos exponentes del rock en español.",
                Categoria = Categoria.Música,
                Funciones = listaFunciones3,
                Tickets = listaTickets3,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);
            _logicaProductorAccesoDatos.CrearEvento(evento2);
            _logicaProductorAccesoDatos.CrearEvento(evento3);

            List<Evento> eventosOrdenados = _logicaAsistenteAccesoDatos.OrdenarEventosPorNombre();

            Assert.AreEqual(true, EventosIguales(evento3, eventosOrdenados[0]));
            Assert.AreEqual(true, EventosIguales(evento1, eventosOrdenados[1]));
            Assert.AreEqual(true, EventosIguales(evento2, eventosOrdenados[2]));
        }

        [TestMethod]
        public void VisualizarEventosOrdenadosPorFecha()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };

            Ticket ticket3 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets3 = new List<Ticket>
            {
                ticket3
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 5, 20, 0, 0),
                                  new DateTime(2022, 5, 5, 22, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 6, 20, 0, 0),
                                  new DateTime(2022, 5, 6, 22, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1,
                funcion2
            };

            Funcion funcion3 = new Funcion(new DateTime(2022, 4, 14, 21, 0, 0),
                                  new DateTime(2022, 4, 14, 23, 0, 0),
                                  listaTickets2);
            Funcion funcion4 = new Funcion(new DateTime(2022, 5, 8, 21, 0, 0),
                                  new DateTime(2022, 5, 8, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion3,
                funcion4
            };


            Funcion funcion5 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets3);
            Funcion funcion6 = new Funcion(new DateTime(2022, 6, 4, 12, 0, 0),
                                  new DateTime(2022, 6, 4, 14, 0, 0),
                                  listaTickets3);

            List<Funcion> listaFunciones3 = new List<Funcion>
            {
                funcion5,
                funcion6
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Jorge Drexler",
                Descripcion = "Tras más de cuatro años de silencio discográfico, el cantante y compositor uruguayo Jorge Drexler presenta su nuevo álbum, “Tinta y tiempo”",
                Categoria = Categoria.Música,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            Evento evento3 = new Evento()
            {
                Nombre = "Andrés Calamaro",
                Descripcion = "Luego de 3 años de ausencia de los escenarios regresa a Uruguay uno de los maximos exponentes del rock en español.",
                Categoria = Categoria.Música,
                Funciones = listaFunciones3,
                Tickets = listaTickets3,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);
            _logicaProductorAccesoDatos.CrearEvento(evento2);
            _logicaProductorAccesoDatos.CrearEvento(evento3);

            List<Evento> eventosOrdenados = _logicaAsistenteAccesoDatos.OrdenarEventosPorFecha();

            Assert.AreEqual(true, EventosIguales(evento2, eventosOrdenados[0]));
            Assert.AreEqual(true, EventosIguales(evento3, eventosOrdenados[1]));
            Assert.AreEqual(true, EventosIguales(evento1, eventosOrdenados[2]));
        }

        [TestMethod]
        public void VisualizarEventosOrdenadosPorFechaYNombre()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };

            Ticket ticket3 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            List<Ticket> listaTickets3 = new List<Ticket>
            {
                ticket3
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 5, 20, 0, 0),
                                  new DateTime(2022, 5, 5, 22, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 6, 20, 0, 0),
                                  new DateTime(2022, 5, 6, 22, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1,
                funcion2
            };

            Funcion funcion3 = new Funcion(new DateTime(2022, 4, 14, 21, 0, 0),
                                  new DateTime(2022, 4, 14, 23, 0, 0),
                                  listaTickets2);
            Funcion funcion4 = new Funcion(new DateTime(2022, 5, 8, 21, 0, 0),
                                  new DateTime(2022, 5, 8, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion3,
                funcion4
            };


            Funcion funcion5 = new Funcion(new DateTime(2022, 4, 14, 21, 0, 0),
                                  new DateTime(2022, 4, 14, 23, 0, 0),
                                  listaTickets3);
            Funcion funcion6 = new Funcion(new DateTime(2022, 5, 8, 21, 0, 0),
                                  new DateTime(2022, 5, 8, 23, 0, 0),
                                  listaTickets3);

            List<Funcion> listaFunciones3 = new List<Funcion>
            {
                funcion5,
                funcion6
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Jorge Drexler",
                Descripcion = "Tras más de cuatro años de silencio discográfico, el cantante y compositor uruguayo Jorge Drexler presenta su nuevo álbum, “Tinta y tiempo”",
                Categoria = Categoria.Música,
                Funciones = listaFunciones3,
                Tickets = listaTickets3,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            Evento evento3 = new Evento()
            {
                Nombre = "Andrés Calamaro",
                Descripcion = "Luego de 3 años de ausencia de los escenarios regresa a Uruguay uno de los maximos exponentes del rock en español.",
                Categoria = Categoria.Música,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);
            _logicaProductorAccesoDatos.CrearEvento(evento2);
            _logicaProductorAccesoDatos.CrearEvento(evento3);

            List<Evento> eventosOrdenados = _logicaAsistenteAccesoDatos.OrdenarEventosPorFechaYNombre();

            Assert.AreEqual(true, EventosIguales(evento3, eventosOrdenados[0]));
            Assert.AreEqual(true, EventosIguales(evento2, eventosOrdenados[1]));
            Assert.AreEqual(true, EventosIguales(evento1, eventosOrdenados[2]));
        }



        public bool EventosIguales(Evento evento1, Evento evento2)
        {
            return evento1.Nombre == evento2.Nombre
                && evento1.Descripcion == evento2.Descripcion
                && evento1.Direccion == evento2.Direccion
                && FuncionesIguales(evento1.Funciones, evento2.Funciones)
                && TicketsIguales(evento1.Tickets, evento2.Tickets)
                && evento1.Formato == evento2.Formato;
        }

        [TestMethod]
        public void VisualizarEventosVencidos()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Funcion funcion1 = new Funcion(new DateTime(2021, 3, 2, 12, 0, 0),
                                  new DateTime(2021, 3, 2, 14, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2021, 8, 7, 12, 0, 0),
                                  new DateTime(2021, 8, 7, 14, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones = new List<Funcion>
            {
                funcion1,
                funcion2
            };

            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            _logicaProductorAccesoDatos.CrearEvento(evento);

            List<Evento> listaEventosDisponibles = _logicaAsistenteAccesoDatos.VisualizarEventos();
            Assert.AreEqual(0, listaEventosDisponibles.Count);
        }

        [TestMethod]
        public void VisualizarDosEventosOrdenados()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };

            Ticket ticket3 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            List<Ticket> listaTickets3 = new List<Ticket>
            {
                ticket3
            };

            Funcion funcion1 = new Funcion(new DateTime(2021, 5, 5, 20, 0, 0),
                                  new DateTime(2021, 5, 5, 22, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2021, 5, 6, 20, 0, 0),
                                  new DateTime(2021, 5, 6, 22, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1,
                funcion2
            };

            Funcion funcion3 = new Funcion(new DateTime(2023, 5, 14, 21, 0, 0),
                                  new DateTime(2023, 5, 14, 23, 0, 0),
                                  listaTickets2);
            Funcion funcion4 = new Funcion(new DateTime(2023, 5, 15, 21, 0, 0),
                                  new DateTime(2023, 5, 15, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion3,
                funcion4
            };


            Funcion funcion5 = new Funcion(new DateTime(2023, 5, 7, 21, 0, 0),
                                  new DateTime(2023, 5, 7, 23, 0, 0),
                                  listaTickets3);
            Funcion funcion6 = new Funcion(new DateTime(2023, 5, 13, 21, 0, 0),
                                  new DateTime(2023, 5, 13, 23, 0, 0),
                                  listaTickets3);

            List<Funcion> listaFunciones3 = new List<Funcion>
            {
                funcion5,
                funcion6
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Jorge Drexler",
                Descripcion = "Tras más de cuatro años de silencio discográfico, el cantante y compositor uruguayo Jorge Drexler presenta su nuevo álbum, “Tinta y tiempo”",
                Categoria = Categoria.Música,
                Funciones = listaFunciones3,
                Tickets = listaTickets3,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento3 = new Evento()
            {
                Nombre = "Andrés Calamaro",
                Descripcion = "Luego de 3 años de ausencia de los escenarios regresa a Uruguay uno de los maximos exponentes del rock en español.",
                Categoria = Categoria.Música,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);
            _logicaProductorAccesoDatos.CrearEvento(evento2);
            _logicaProductorAccesoDatos.CrearEvento(evento3);

            List<Evento> eventosOrdenados = _logicaAsistenteAccesoDatos.VisualizarEventos();

            Assert.AreEqual(evento2.Nombre, eventosOrdenados[0].Nombre);
            Assert.AreEqual(evento3.Nombre, eventosOrdenados[1].Nombre);
        }

        [TestMethod]
        public void VisualizarEventosSinTickets()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 10,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1
            };


            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 7, 21, 0, 0),
                                  new DateTime(2023, 5, 7, 23, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2023, 5, 13, 21, 0, 0),
                                  new DateTime(2023, 5, 13, 23, 0, 0),
                                  listaTickets);

            List<Funcion> listaFunciones = new List<Funcion>
            {
                funcion1,
                funcion2
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);

            Asistente asistente = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123 - 9" };

            List<(Ticket, int)> compra = new List<(Ticket, int)>() { (ticket1, 10) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra, asistente);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion2, compra, asistente);

            List<Evento> eventosDisponibles = _logicaAsistenteAccesoDatos.VisualizarEventos();
            Assert.AreEqual(0, eventosDisponibles.Count);
        }

        [TestMethod]
        public void VisualizarEventoConTicketsEnUnaSolaFuncion()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 10,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1
            };


            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 7, 21, 0, 0),
                                  new DateTime(2023, 5, 7, 23, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2023, 5, 13, 21, 0, 0),
                                  new DateTime(2023, 5, 13, 23, 0, 0),
                                  listaTickets);

            List<Funcion> listaFunciones = new List<Funcion>
            {
                funcion1,
                funcion2
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);
            evento1.Funciones[0].RestarCantidadTickets(ticket1, 10);

            List<Evento> eventosDisponibles = _logicaAsistenteAccesoDatos.VisualizarEventos();
            Assert.AreEqual(1, eventosDisponibles.Count);
            Assert.AreEqual(funcion1.FechaInicio, eventosDisponibles[0].Funciones[0].FechaInicio);
            Assert.AreEqual(funcion1.FechaFin, eventosDisponibles[0].Funciones[0].FechaFin);
        }

        [TestMethod]
        public void ComprarTickets()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 10,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1
            };


            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 7, 21, 0, 0),
                                  new DateTime(2023, 5, 7, 23, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2023, 5, 13, 21, 0, 0),
                                  new DateTime(2023, 5, 13, 23, 0, 0),
                                  listaTickets);

            List<Funcion> listaFunciones = new List<Funcion>
            {
                funcion1,
                funcion2
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);

            Asistente asistente = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123 - 9" };

            List<(Ticket, int)> compra = new List<(Ticket, int)> { (ticket1, 5) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra, asistente);
            
            int cantidadDisponible = _logicaAsistenteAccesoDatos.ConsultarCantidadTicketFuncion(evento1, funcion1, ticket1);

            Assert.AreEqual(5, cantidadDisponible);
        }

        [TestMethod]

        public void CantidadCategoriaTest()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };

            Ticket ticket3 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets3 = new List<Ticket>
            {
                ticket3
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 8, 6, 12, 0, 0),
                                  new DateTime(2022, 8, 6, 14, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2022, 8, 7, 12, 0, 0),
                                  new DateTime(2022, 8, 7, 14, 0, 0),
                                  listaTickets2);
            Funcion funcion3 = new Funcion(new DateTime(2022, 8, 7, 12, 0, 0),
                                  new DateTime(2022, 8, 8, 14, 0, 0),
                                  listaTickets3);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1
            };
            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion2
            };
            List<Funcion> listaFunciones3 = new List<Funcion>
            {
                funcion3
            };

            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario2",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Teatro,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            Evento evento3 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario3",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones3,
                Tickets = listaTickets3,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            _logicaProductorAccesoDatos.CrearEvento(evento);
            _logicaProductorAccesoDatos.CrearEvento(evento2);
            _logicaProductorAccesoDatos.CrearEvento(evento3);

            Dictionary<Categoria, int> cantidadCategoria = new Dictionary<Categoria, int>
            {
                { Categoria.Música, 2 },
                { Categoria.Teatro, 1 },
                { Categoria.Cursos, 0 },
                { Categoria.Conferencias, 0 },
                { Categoria.Deportes, 0 },
                { Categoria.Fútbol, 0 },
                { Categoria.Otros, 0 }
            };

            Assert.AreEqual(true, CompararCantidadCategoria(cantidadCategoria, _logicaAsistenteAccesoDatos.CantidadCategoria()));

        }

        [TestMethod]
        public void VisualizarCateogriaTest()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };

            Ticket ticket3 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 6500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets3 = new List<Ticket>
            {
                ticket3
            };

            Funcion funcion1 = new Funcion(new DateTime(2023, 3, 2, 12, 0, 0),
                                  new DateTime(2023, 3, 2, 14, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2023, 8, 7, 12, 0, 0),
                                  new DateTime(2023, 8, 7, 14, 0, 0),
                                  listaTickets2);
            Funcion funcion3 = new Funcion(new DateTime(2023, 8, 7, 12, 0, 0),
                                  new DateTime(2023, 8, 7, 14, 0, 0),
                                  listaTickets3);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1
            };

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion2
            };

            List<Funcion> listaFunciones3 = new List<Funcion>
            {
                funcion3
            };

            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario2",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Teatro,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento3 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario3",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones3,
                Tickets = listaTickets3,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento);
            _logicaProductorAccesoDatos.CrearEvento(evento2);
            _logicaProductorAccesoDatos.CrearEvento(evento3);

            List<Evento> eventosMusicales = new List<Evento>
            {
                evento,
                evento3
            };

            Assert.IsTrue(CompararListasEventos(eventosMusicales, _logicaAsistenteAccesoDatos.FiltrarPorCategoria(Categoria.Música)));
        }

        private bool CompararCantidadCategoria(Dictionary<Categoria, int> cantidadCategoria1, Dictionary<Categoria, int> cantidadCategoria2)
        {
            foreach (Categoria categoria in Enum.GetValues(typeof(Categoria)))
            {
                if (cantidadCategoria1[categoria] != cantidadCategoria2[categoria])
                {
                    return false;
                }
            }
            return true;
        }

        private bool CompararListasEventos(List<Evento> ListaEventos1, List<Evento> ListaEventos2)
        {
            if (ListaEventos1.Count != ListaEventos2.Count)
            {
                return false;
            }
            for (int i = 0; i < ListaEventos1.Count; i++)
            {
                if (ListaEventos1[i].Nombre != ListaEventos2[i].Nombre)
                {
                    return false;
                }
            }
            return true;
        }

        [TestMethod]
        public void VisualizarEventosEntreFechas()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };
            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 8, 5, 20, 0, 0),
                                  new DateTime(2022, 8, 5, 22, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1
            };

            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 14, 21, 0, 0),
                                  new DateTime(2022, 5, 14, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion2
            };

            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Jorge Drexler",
                Descripcion = "Tras más de cuatro años de silencio discográfico, el cantante y compositor uruguayo Jorge Drexler presenta su nuevo álbum, “Tinta y tiempo”",
                Categoria = Categoria.Música,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);
            _logicaProductorAccesoDatos.CrearEvento(evento2);

            DateTime fechaInicio = new DateTime(2022, 05, 01, 00, 00, 00);
            DateTime fechaFin = new DateTime(2022, 05, 30, 00, 00, 00);

            List<Evento> eventosEntreFechas = _logicaAsistenteAccesoDatos.FiltrarEventosEntreFechas(fechaInicio, fechaFin, _logicaProductorAccesoDatos.EventosCreados());

            Assert.AreEqual(true, EventosIguales(evento2, eventosEntreFechas[0]));
        }

        [TestMethod]
        public void BuscarEventoPorNombre()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };
            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };
            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 8, 5, 20, 0, 0),
                                  new DateTime(2022, 8, 5, 22, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1
            };

            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 14, 21, 0, 0),
                                  new DateTime(2022, 5, 14, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion2
            };

            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Jorge Drexler",
                Descripcion = "Tras más de cuatro años de silencio discográfico, el cantante y compositor uruguayo Jorge Drexler presenta su nuevo álbum, “Tinta y tiempo”",
                Categoria = Categoria.Música,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);
            _logicaProductorAccesoDatos.CrearEvento(evento2);

            DateTime fechaInicio = new DateTime(2022, 05, 01, 00, 00, 00);
            DateTime fechaFin = new DateTime(2022, 05, 30, 00, 00, 00);

            List<Evento> eventosEntreFechas = _logicaAsistenteAccesoDatos.FiltrarEventosPorNombre("Roses", _logicaProductorAccesoDatos.EventosCreados());
            Assert.AreEqual(true, EventosIguales(evento1, eventosEntreFechas[0]));
        }

        [TestMethod]
        public void ReporteEntradasVendidas()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };
            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };
            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };


            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 7, 21, 0, 0),
                                  new DateTime(2023, 5, 7, 23, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2023, 5, 13, 21, 0, 0),
                                  new DateTime(2023, 5, 13, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1
            };

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion2
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Uruguay vs Argentina",
                Descripcion = "Mundial",
                Categoria = Categoria.Deportes,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);
            _logicaProductorAccesoDatos.CrearEvento(evento2);

            Asistente asistente = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123 - 9" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket2, 10) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento2, funcion2, compra2, asistente);

            Dictionary<Categoria, int> resultado = _logicaAsistenteAccesoDatos.GenerarReporte(2000, 3000);

            Assert.AreEqual(true, resultado.ContainsKey(Categoria.Música));
            Assert.AreEqual(true, resultado.ContainsKey(Categoria.Deportes));
            Assert.AreEqual(true, resultado.ContainsValue(5));
            Assert.AreEqual(true, resultado.ContainsValue(10));
        }

        [TestMethod]
        public void ReporteEntradasVendidasSinResultado()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };
            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };
            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };


            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 7, 21, 0, 0),
                                  new DateTime(2023, 5, 7, 23, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2023, 5, 13, 21, 0, 0),
                                  new DateTime(2023, 5, 13, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1
            };

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion2
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Uruguay vs Argentina",
                Descripcion = "Mundial",
                Categoria = Categoria.Deportes,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);
            _logicaProductorAccesoDatos.CrearEvento(evento2);

            Asistente asistente = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123 - 9" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket1, 10) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento2, funcion2, compra2, asistente);

            Dictionary<Categoria, int> resultado = _logicaAsistenteAccesoDatos.GenerarReporte(1000, 2000);

            Assert.AreEqual(false, resultado.ContainsKey(Categoria.Música));
            Assert.AreEqual(false, resultado.ContainsKey(Categoria.Deportes));
            Assert.AreEqual(false, resultado.ContainsValue(5));
            Assert.AreEqual(false, resultado.ContainsValue(10));
        }

        [TestMethod]
        public void ReporteEntradasVendidasUnTicket()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 100,
            };
            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 1500,
                Cantidad = 100,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1,
                ticket2
            };

            Ticket ticket3 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 100,
            };
            Ticket ticket4 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 1500,
                Cantidad = 100,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket3,
                ticket4
            };

            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 7, 21, 0, 0),
                                  new DateTime(2023, 5, 7, 23, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2023, 5, 13, 21, 0, 0),
                                  new DateTime(2023, 5, 13, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1
            };

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion2
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Uruguay vs Argentina",
                Descripcion = "Mundial",
                Categoria = Categoria.Deportes,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);
            _logicaProductorAccesoDatos.CrearEvento(evento2);

            Asistente asistente = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123 - 9" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket2, 2) };
            List<(Ticket, int)> compra3 = new List<(Ticket, int)>() { (ticket3, 10) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra2, asistente);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento2, funcion2, compra3, asistente);

            Dictionary<Categoria, int> resultado = _logicaAsistenteAccesoDatos.GenerarReporte(1000, 2000);

            Assert.AreEqual(true, resultado.ContainsKey(Categoria.Música));
            Assert.AreEqual(true, resultado.ContainsValue(2));
        }

        [TestMethod]
        public void ObtenerCompraExistete()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 100,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 7, 21, 0, 0),
                                  new DateTime(2023, 5, 7, 23, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1
            };


            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento1);

            Asistente asistente = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123 - 9" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente);

            Compra compra = _logicaAsistenteAccesoDatos.ObtenerCompra(evento1, funcion1, asistente, compra1);

        }

        [TestMethod]
        public void ControlarTotal()
        {
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);
            int unTotal = 8;
            _logicaAsistenteAccesoDatos.ControlarTotal(unTotal);
        }

        [TestMethod]
        [ExpectedException(typeof(TotalIgualCeroException))]
        public void ControlarUnTotalIgualCero()
        {
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);
            int unTotal = 0;
            _logicaAsistenteAccesoDatos.ControlarTotal(unTotal);

        }

        [TestMethod]
        [ExpectedException(typeof(TotalMayorA10Exception))]
        public void ControlarUnTotalMayor10()
        {
            ILogicaAsistente _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);
            int unTotal = 11;
            _logicaAsistenteAccesoDatos.ControlarTotal(unTotal);
        }

        public bool TicketsIguales(List<Ticket> tickets1, List<Ticket> tickets2)
        {
            bool resultado = true;
            for (int i = 0; i < tickets1.Count; i++)
            {
                if (tickets1[i].Nombre != tickets2[i].Nombre
                    || tickets1[i].Precio != tickets2[i].Precio
                    || tickets1[i].Cantidad != tickets2[i].Cantidad)
                {
                    resultado = false;
                }
            }
            return resultado;
        }

        public bool FuncionesIguales(List<Funcion> funciones1, List<Funcion> funciones2)
        {
            bool resultado = true;
            for (int i = 0; i < funciones1.Count; i++)
            {
                if (funciones1[i].FechaInicio != funciones2[i].FechaInicio
                    || funciones1[i].FechaFin != funciones2[i].FechaFin
                    || funciones1[i].MostrarDisponibles != funciones2[i].MostrarDisponibles)
                {
                    resultado = false;
                }
            }
            return resultado;
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _repositorioProductor.VaciarTablaProductores();
            _repositorioProductor.VaciarTablaEventos();
            _repositorioAsistente.VaciarTablaCompras();
            _repositorioAsistente.VaciarTablaAsistentes();
            _repositorioAsistente.VaciarTablaEntradasVendidas();
        }

    }
}
