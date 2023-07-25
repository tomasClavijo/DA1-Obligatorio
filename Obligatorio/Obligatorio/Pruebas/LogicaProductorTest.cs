using Dominio;
using Excepciones;
using DatosEnMemoria;
using LogicaDeNegocio.Implementaciones;
using LogicaDeNegocio.Interfaces;
using AccesoDatos.Implementaciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace PruebasObligatorio
{
    [TestClass]
    public class LogicaProductorTest
    {
        private static RepositorioProductorImp _repositorioProductor = new RepositorioProductorImp();
        private static RepositorioAsistenteImp _repositorioAsistente = new RepositorioAsistenteImp();

        [TestInitialize]
        public void LimpiarBase()
        {
            _repositorioProductor.VaciarTablaProductores();
            _repositorioProductor.VaciarTablaEventos();
            _repositorioProductor.VaciarTablaCupones();
            _repositorioProductor.VaciarTablaAsistentesCuponesEventos();
            _repositorioAsistente.VaciarTablaCompras();
            _repositorioAsistente.VaciarTablaAsistentes();
            _repositorioAsistente.VaciarTablaEntradasVendidas();
        }

        [TestMethod]
        public void RegistrarPrimerProductorTest()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Productor unProductor = new Productor()
            {
                Nombre = "Juan",
                Apellido = "González",
                Email = "gonzález@gmail.com",
                Password = "gonzálezpassword"
            };

            _logicaProductorAccesoDatos.RegistrarProductor(unProductor);
            Assert.AreEqual(true, _logicaProductorAccesoDatos.ExisteProductor(unProductor.Email));
        }

        [TestMethod]
        public void RegistrarSegundoProductorTest()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Productor primerProductor = new Productor()
            {
                Nombre = "Juan",
                Apellido = "González",
                Email = "gonzález@gmail.com",
                Password = "gonzálezpassword"
            };

            Productor segundoProductor = new Productor()
            {
                Nombre = "Pedro",
                Apellido = "Sanchez",
                Email = "pedro@gmail.com",
                Password = "pedropassword"
            };

            _logicaProductorAccesoDatos.RegistrarProductor(primerProductor);
            _logicaProductorAccesoDatos.RegistrarProductor(segundoProductor);
            Assert.AreEqual(true, _logicaProductorAccesoDatos.ExisteProductor(primerProductor.Email));
            Assert.AreEqual(true, _logicaProductorAccesoDatos.ExisteProductor(segundoProductor.Email));
        }

        [ExpectedException(typeof(ProductorExistenteException))]
        [TestMethod]
        public void RegistrarProductorExistenteTest()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Productor primerProductor = new Productor()
            {
                Nombre = "Juan",
                Apellido = "González",
                Email = "gonzález@gmail.com",
                Password = "gonzálezpassword"
            };

            Productor segundoProductor = new Productor()
            {
                Nombre = "Juan",
                Apellido = "González",
                Email = "gonzález@gmail.com",
                Password = "gonzálezpassword"
            };

            _logicaProductorAccesoDatos.RegistrarProductor(primerProductor);
            _logicaProductorAccesoDatos.RegistrarProductor(segundoProductor);
        }

        [ExpectedException(typeof(ProductorExistenteException))]
        [TestMethod]
        public void RegistrarDistintosProductoresConMismoEmail()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Productor primerProductor = new Productor()
            {
                Nombre = "Ferrell",
                Apellido = "Torald",
                Email = "mismoemail@email.com",
                Password = "Ferrellpassword"
            };

            Productor segundoProductor = new Productor()
            {
                Nombre = "Andie",
                Apellido = "Jerosch",
                Email = "mismoemail@email.com",
                Password = "Andiepassword"
            };
            _logicaProductorAccesoDatos.RegistrarProductor(primerProductor);
            _logicaProductorAccesoDatos.RegistrarProductor(segundoProductor);
        }

        [TestMethod]
        public void RegistrarMismoProductorConDistintosEmails()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Productor primerProductor = new Productor()
            {
                Nombre = "Kate",
                Apellido = "Cossum",
                Email = "Kate1@email.com",
                Password = "Katepassword"
            };

            Productor segundoProductor = new Productor()
            {
                Nombre = "Kate",
                Apellido = "Cossum",
                Email = "Kate2@email.com",
                Password = "Katepassword"
            };

            _logicaProductorAccesoDatos.RegistrarProductor(primerProductor);
            _logicaProductorAccesoDatos.RegistrarProductor(segundoProductor);
            Assert.AreEqual(true, _logicaProductorAccesoDatos.ExisteProductor(primerProductor.Email));
            Assert.AreEqual(true, _logicaProductorAccesoDatos.ExisteProductor(segundoProductor.Email));
        }

        [TestMethod]
        public void IniciarSesionConProductorExistenteTest()
        {
            Datos datos = new Datos();
            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaProductorLogin logicaProductorMemoria = new LogicaProductorLogin(datos);

            Productor productor = new Productor()
            {
                Nombre = "Gloia",
                Apellido = "Carretero",
                Email = "n1rouyszir@netscape.net",
                Password = "Gloriapassword"
            };
            logicaProductorAccesoDatos.RegistrarProductor(productor);
            logicaProductorMemoria.IniciarSesion(logicaProductorAccesoDatos.ObtenerProductor(productor.Email));

            Assert.AreEqual(productor.Nombre, datos.ProductorIniciado.Nombre);
            Assert.AreEqual(productor.Apellido, datos.ProductorIniciado.Apellido);
            Assert.AreEqual(productor.Email, datos.ProductorIniciado.Email);
            Assert.AreEqual(productor.Password, datos.ProductorIniciado.Password);
        }

        [ExpectedException(typeof(InicioDeSesionIncorrecto))]
        [TestMethod]
        public void IniciarSesionSinTenerProductoresTest()
        {
            Datos datos = new Datos();
            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Productor productor = new Productor()
            {
                Nombre = "Gloia",
                Apellido = "Carretero",
                Email = "n1rouyszir@netscape.net",
                Password = "Gloriapassword"
            };
            logicaProductorAccesoDatos.InicioSesionCorrecto(productor);
        }

        [TestMethod]
        public void CrearEventoTest()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Platea Olímpica",
                Precio = 3500,
                Cantidad = 5000,
            };

            List<Ticket> listaTickets = new List<Ticket>();
            listaTickets.Add(ticket1);
            listaTickets.Add(ticket2);

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 4, 12, 0, 0),
                                  new DateTime(2022, 5, 4, 14, 0, 0),
                                  listaTickets);

            List<Funcion> listaFunciones = new List<Funcion>();
            listaFunciones.Add(funcion1);
            listaFunciones.Add(funcion2);

            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            _logicaProductorAccesoDatos.CrearEvento(evento);
            Assert.AreEqual(true, _logicaProductorAccesoDatos.ExisteEvento(evento));
        }

        [TestMethod]
        public void EventosCreadosTest()
        {
            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Platea Olímpica",
                Precio = 3500,
                Cantidad = 5000,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1,
                ticket2
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 4, 12, 0, 0),
                                  new DateTime(2022, 5, 4, 14, 0, 0),
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
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            logicaProductorAccesoDatos.CrearEvento(evento);
            List<Evento> listaeventos = new List<Evento>
            {
                evento
            };

            CompararListasEventos(listaeventos, logicaProductorAccesoDatos.EventosCreados());

        }

        [ExpectedException(typeof(EventoExistenteException))]
        [TestMethod]
        public void CrearEventoExistenteTest()
        {
            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Platea Olímpica",
                Precio = 3500,
                Cantidad = 5000,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1,
                ticket2
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 4, 12, 0, 0),
                                  new DateTime(2022, 5, 4, 14, 0, 0),
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
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            logicaProductorAccesoDatos.CrearEvento(evento1);
            logicaProductorAccesoDatos.CrearEvento(evento2);
        }

        [TestMethod]
        public void EliminarEventoExistenteTest()
        {
            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets);

            List<Funcion> listaFunciones = new List<Funcion>
            {
                funcion1
            };

            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            logicaProductorAccesoDatos.CrearEvento(evento);
            logicaProductorAccesoDatos.EliminarEvento("Guns N Roses en Montevideo - Estadio Centenario");
            Assert.AreEqual(false, logicaProductorAccesoDatos.ExisteEvento(evento.Nombre));
            Assert.AreEqual(false, logicaProductorAccesoDatos.ExisteEvento(evento));
        }

        [ExpectedException(typeof(EventoInexistenteException))]
        [TestMethod]
        public void EliminarEventoInexistenteTest()
        {
            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets);

            List<Funcion> listaFunciones = new List<Funcion>
            {
                funcion1
            };

            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo 2 - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            logicaProductorAccesoDatos.CrearEvento(evento1);
            logicaProductorAccesoDatos.EliminarEvento("Guns N Roses en Montevideo 2 - Estadio Centenario");
        }

        [TestMethod]
        public void CrearEventoModoBorrador()
        {
            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets);

            List<Funcion> listaFunciones = new List<Funcion>
            {
                funcion1
            };

            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = true
            };

            logicaProductorAccesoDatos.CrearEventoBorrador(evento);
            Assert.AreEqual(true, logicaProductorAccesoDatos.ExisteEventoBorrador(evento));
        }

        [TestMethod]
        public void CrearEventoBorradorYNoBorrador()
        {
            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket2
            };

            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion2
            };

            Evento evento1 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = false
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Antel Arena",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = true
            };

            logicaProductorAccesoDatos.CrearEventoBorrador(evento1);
            logicaProductorAccesoDatos.CrearEventoBorrador(evento2);

            Assert.AreEqual(true, logicaProductorAccesoDatos.ExisteEvento(evento1));
            Assert.AreEqual(false, logicaProductorAccesoDatos.ExisteEventoBorrador(evento1));
            Assert.AreEqual(true, logicaProductorAccesoDatos.ExisteEventoBorrador(evento2));
        }

        [ExpectedException(typeof(EventoExistenteException))]
        [TestMethod]
        public void CrearEventoBorradorExistenteTest()
        {
            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Platea Olímpica",
                Precio = 3500,
                Cantidad = 5000,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1,
                ticket2
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 4, 12, 0, 0),
                                  new DateTime(2022, 5, 4, 14, 0, 0),
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
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento2 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            logicaProductorAccesoDatos.CrearEventoBorrador(evento1);
            logicaProductorAccesoDatos.CrearEventoBorrador(evento2);
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
        public void VisualizarEventosBorrador()
        {
            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 4500,
                Cantidad = 1000,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1,
                ticket2
            };

            Ticket ticket3 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket3
            };

            Ticket ticket4 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            List<Ticket> listaTickets3 = new List<Ticket>
            {
                ticket4
            };

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 5, 20, 0, 0),
                                  new DateTime(2022, 5, 5, 22, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 6, 20, 0, 0),
                                  new DateTime(2022, 5, 6, 22, 0, 0),
                                  listaTickets);

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
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = true
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
                EsBorrador = true
            };

            logicaProductorAccesoDatos.CrearEventoBorrador(evento1);
            logicaProductorAccesoDatos.CrearEventoBorrador(evento2);
            logicaProductorAccesoDatos.CrearEventoBorrador(evento3);

            List<Evento> eventosBorrador = logicaProductorAccesoDatos.VisualizarEventosBorrador();

            Assert.AreEqual(true, EventosIguales(evento1, eventosBorrador[0]));
            Assert.AreEqual(true, EventosIguales(evento3, eventosBorrador[1]));
        }

        [TestMethod]
        public void PublicarEvento()
        {
            RepositorioAsistenteImp repositorioAsistente = new RepositorioAsistenteImp();

            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(repositorioAsistente);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 4500,
                Cantidad = 1000,
            };

            List<Ticket> listaTickets = new List<Ticket>
            {
                ticket1,
                ticket2
            };

            Ticket ticket3 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 4500,
                Cantidad = 1000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket3
            };

            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 5, 20, 0, 0),
                                  new DateTime(2023, 5, 5, 22, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2023, 5, 6, 20, 0, 0),
                                  new DateTime(2023, 5, 6, 22, 0, 0),
                                  listaTickets);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1,
                funcion2
            };

            Funcion funcion5 = new Funcion(new DateTime(2023, 4, 14, 21, 0, 0),
                                  new DateTime(2023, 4, 14, 23, 0, 0),
                                  listaTickets2);
            Funcion funcion6 = new Funcion(new DateTime(2023, 5, 8, 21, 0, 0),
                                  new DateTime(2023, 5, 8, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones2 = new List<Funcion>
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
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = true
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
                EsBorrador = true
            };

            logicaProductorAccesoDatos.CrearEventoBorrador(evento1);
            logicaProductorAccesoDatos.CrearEventoBorrador(evento2);

            logicaProductorAccesoDatos.PublicarEvento(evento1);

            List<Evento> eventosBorrador = logicaProductorAccesoDatos.VisualizarEventosBorrador();
            List<Evento> eventosPublicados = logicaAsistenteAccesoDatos.VisualizarEventos();

            Assert.AreEqual(1, eventosBorrador.Count);
            Assert.AreEqual(1, eventosPublicados.Count);
        }

        [TestMethod]
        public void ModificarEventoEnBorradorYNoPublicarlo()
        {
            RepositorioAsistenteImp repositorioAsistente = new RepositorioAsistenteImp();

            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);

            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 4500,
                Cantidad = 1000,
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
                Cantidad = 2000,
            };

            Ticket ticket4 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 4500,
                Cantidad = 1000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket3,
                ticket4
            };

            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 5, 20, 0, 0),
                                  new DateTime(2023, 5, 5, 22, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2023, 5, 6, 20, 0, 0),
                                  new DateTime(2023, 5, 6, 22, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1,
                funcion2
            };

            Funcion funcion5 = new Funcion(new DateTime(2023, 4, 14, 21, 0, 0),
                                  new DateTime(2023, 4, 14, 23, 0, 0),
                                  listaTickets2);
            Funcion funcion6 = new Funcion(new DateTime(2023, 5, 8, 21, 0, 0),
                                  new DateTime(2023, 5, 8, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion5,
                funcion6
            };


            Evento eventoViejo = new Evento()
            {
                Nombre = "Jorge Drexler",
                Descripcion = "Tras más de cuatro años de silencio discográfico, el cantante y compositor uruguayo Jorge Drexler presenta su nuevo álbum, “Tinta y tiempo”",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = true
            };

            Evento eventoNuevo = new Evento()
            {
                Nombre = "Jorge Drexler",
                Descripcion = "Tras más de cuatro años de silencio discográfico, el cantante y compositor uruguayo Jorge Drexler presenta su nuevo álbum, “Tinta y tiempo”",
                Categoria = Categoria.Música,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path",
                EsBorrador = true
            };

            logicaProductorAccesoDatos.CrearEventoBorrador(eventoViejo);

            logicaProductorAccesoDatos.EliminarEvento(eventoViejo);
            logicaProductorAccesoDatos.CrearEventoBorrador(eventoNuevo);

            Assert.AreEqual(true, EventosIguales(eventoNuevo, logicaProductorAccesoDatos.VisualizarEventosBorrador()[0]));

        }

        [TestMethod]
        public void ModificarEventoEnBorradorYPublicarlo()
        {
            RepositorioAsistenteImp repositorioAsistente = new RepositorioAsistenteImp();

            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(repositorioAsistente);


            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 4500,
                Cantidad = 1000,
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
                Cantidad = 2000,
            };

            Ticket ticket4 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 4500,
                Cantidad = 1000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket3,
                ticket4
            };

            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 5, 20, 0, 0),
                                  new DateTime(2023, 5, 5, 22, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2023, 5, 6, 20, 0, 0),
                                  new DateTime(2023, 5, 6, 22, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1,
                funcion2
            };

            Funcion funcion5 = new Funcion(new DateTime(2023, 4, 14, 21, 0, 0),
                                  new DateTime(2023, 4, 14, 23, 0, 0),
                                  listaTickets2);
            Funcion funcion6 = new Funcion(new DateTime(2023, 5, 8, 21, 0, 0),
                                  new DateTime(2023, 5, 8, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion5,
                funcion6
            };


            Evento eventoViejo = new Evento()
            {
                Nombre = "Jorge Drexler",
                Descripcion = "Tras más de cuatro años de silencio discográfico, el cantante y compositor uruguayo Jorge Drexler presenta su nuevo álbum, “Tinta y tiempo”",
                Categoria = Categoria.Música,
                Funciones = listaFunciones1,
                Tickets = listaTickets1,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento eventoNuevo = new Evento()
            {
                Nombre = "Jorge Drexler",
                Descripcion = "Tras más de cuatro años de silencio discográfico, el cantante y compositor uruguayo Jorge Drexler presenta su nuevo álbum, “Tinta y tiempo”",
                Categoria = Categoria.Música,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            logicaProductorAccesoDatos.CrearEventoBorrador(eventoViejo);
            logicaProductorAccesoDatos.EliminarEvento(eventoViejo);
            logicaProductorAccesoDatos.CrearEventoBorrador(eventoNuevo);
            logicaProductorAccesoDatos.PublicarEvento(eventoNuevo);

            Assert.AreEqual(true, EventosIguales(eventoNuevo, logicaProductorAccesoDatos.ObtenerEvento(eventoNuevo.Nombre)));
            Assert.AreEqual(true, EventosIguales(eventoNuevo, logicaAsistenteAccesoDatos.VisualizarEventos()[0]));
        }

        
        [ExpectedException(typeof(EventoExistenteException))]
        [TestMethod]
        public void ModificarEventoAUnoExistente()
        {
            RepositorioAsistenteImp repositorioAsistente = new RepositorioAsistenteImp();

            ILogicaProductor logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            ILogicaAsistente logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(repositorioAsistente);


            Ticket ticket1 = new Ticket()
            {
                Nombre = "Sector A",
                Precio = 2500,
                Cantidad = 2000,
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 4500,
                Cantidad = 1000,
            };

            List<Ticket> listaTickets1 = new List<Ticket>
            {
                ticket1,
                ticket2
            };

            Ticket ticket3 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 4500,
                Cantidad = 1000,
            };

            List<Ticket> listaTickets2 = new List<Ticket>
            {
                ticket3
            };

            Ticket ticket4 = new Ticket()
            {
                Nombre = "Sector B",
                Precio = 4500,
                Cantidad = 1000,
            };

            List<Ticket> listaTickets3 = new List<Ticket>
            {
                ticket4
            };

            Funcion funcion1 = new Funcion(new DateTime(2023, 5, 5, 20, 0, 0),
                                  new DateTime(2023, 5, 5, 22, 0, 0),
                                  listaTickets1);
            Funcion funcion2 = new Funcion(new DateTime(2023, 5, 6, 20, 0, 0),
                                  new DateTime(2023, 5, 6, 22, 0, 0),
                                  listaTickets1);

            List<Funcion> listaFunciones1 = new List<Funcion>
            {
                funcion1,
                funcion2
            };

            Funcion funcion5 = new Funcion(new DateTime(2023, 4, 14, 21, 0, 0),
                                  new DateTime(2023, 4, 14, 23, 0, 0),
                                  listaTickets2);
            Funcion funcion6 = new Funcion(new DateTime(2023, 5, 8, 21, 0, 0),
                                  new DateTime(2023, 5, 8, 23, 0, 0),
                                  listaTickets2);

            List<Funcion> listaFunciones2 = new List<Funcion>
            {
                funcion5,
                funcion6
            };

            Funcion funcion7 = new Funcion(new DateTime(2023, 4, 15, 21, 0, 0),
                                  new DateTime(2023, 4, 15, 23, 0, 0),
                                  listaTickets3);
            Funcion funcion8 = new Funcion(new DateTime(2023, 5, 9, 21, 0, 0),
                                  new DateTime(2023, 5, 9, 23, 0, 0),
                                  listaTickets3);

            List<Funcion> listaFunciones3 = new List<Funcion>
            {
                funcion7,
                funcion8
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
                Nombre = "Guns N Roses en Montevideo",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones2,
                Tickets = listaTickets2,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            Evento evento3 = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Funciones = listaFunciones3,
                Tickets = listaTickets3,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };

            logicaProductorAccesoDatos.CrearEvento(evento1);
            logicaProductorAccesoDatos.CrearEventoBorrador(evento2);


            logicaProductorAccesoDatos.EliminarEvento(evento2);
            logicaProductorAccesoDatos.CrearEventoBorrador(evento3);
        }

        [TestMethod]
        public void ObtenerTodasLasCompras()
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

            Asistente asistente1 = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123-9" };
            Asistente asistente2 = new Asistente() { Nombre = "Roberto", Apellido = "Rama", Cedula = "4.111.333-2" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket1, 8) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente1);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra2, asistente2);

            List<Compra> compras = _logicaProductorAccesoDatos.ObtenerCompras();

            Assert.AreEqual(compras[0].Asistente.Nombre, asistente1.Nombre);
            Assert.AreEqual(compras[1].Asistente.Nombre, asistente2.Nombre);

            Assert.AreEqual(compras[0].Monto, ticket1.Precio * 5);
            Assert.AreEqual(compras[1].Monto, ticket1.Precio * 8);
        }

        [ExpectedException(typeof(NoHayComprasRegistradas))]
        [TestMethod]
        public void ObtenerComprasInexistentes()
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

            List<Compra> compras = _logicaProductorAccesoDatos.ObtenerCompras();
        }

        [TestMethod]
        public void ObtenerComprasFiltradasPorCedula()
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

            Asistente asistente1 = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123-9" };
            Asistente asistente2 = new Asistente() { Nombre = "Roberto", Apellido = "Rama", Cedula = "4.111.333-2" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket1, 8) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente1);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra2, asistente2);

            List<Compra> compras;
            compras = _logicaProductorAccesoDatos.ObtenerCompras();
            compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasCedula(compras, "4.111.333-2");

            Assert.AreEqual(compras[0].Asistente.Nombre, asistente2.Nombre);
            Assert.AreEqual(compras[0].Monto, ticket1.Precio * 8);
        }

        [ExpectedException(typeof(NoHayComprasRegistradas))]
        [TestMethod]
        public void ObtenerComprasIntexistentesFiltradasPorCedula()
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

            Asistente asistente1 = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123-9" };
            Asistente asistente2 = new Asistente() { Nombre = "Roberto", Apellido = "Rama", Cedula = "4.111.333-2" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket1, 8) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente1);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra2, asistente2);

            List<Compra> compras;
            compras = _logicaProductorAccesoDatos.ObtenerCompras();
            compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasCedula(compras, "4.444.444-4");
        }

        [TestMethod]
        public void ObtenerComprasFiltradasPorMonto()
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

            Asistente asistente1 = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123-9" };
            Asistente asistente2 = new Asistente() { Nombre = "Roberto", Apellido = "Rama", Cedula = "4.111.333-2" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket1, 8) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente1);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra2, asistente2);

            List<Compra> compras;
            compras = _logicaProductorAccesoDatos.ObtenerCompras();
            compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasMonto(compras, 12500);

            Assert.AreEqual(compras[0].Asistente.Nombre, asistente2.Nombre);
            Assert.AreEqual(compras[0].Monto, 20000);
        }

        [ExpectedException(typeof(NoHayComprasRegistradas))]
        [TestMethod]
        public void ObtenerComprasInexistentesFiltradasPorMonto()
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

            Asistente asistente1 = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123-9" };
            Asistente asistente2 = new Asistente() { Nombre = "Roberto", Apellido = "Rama", Cedula = "4.111.333-2" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket1, 8) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente1);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra2, asistente2);

            List<Compra> compras;
            compras = _logicaProductorAccesoDatos.ObtenerCompras();
            compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasMonto(compras, 20000);
        }

        [TestMethod]
        public void ObtenerComprasFiltradasPorCedulaYMonto()
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

            Asistente asistente1 = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123-9" };
            Asistente asistente2 = new Asistente() { Nombre = "Roberto", Apellido = "Rama", Cedula = "4.111.333-2" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket1, 8) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente1);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra2, asistente2);

            List<Compra> compras;
            compras = _logicaProductorAccesoDatos.ObtenerCompras();
            compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasMonto(compras, 12500);
            compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasCedula(compras, "4.111.333-2");

            Assert.AreEqual(compras[0].Asistente.Nombre, asistente2.Nombre);
            Assert.AreEqual(compras[0].Monto, 20000);
        }

        [ExpectedException(typeof(NoHayComprasRegistradas))]
        [TestMethod]
        public void ObtenerComprasInexistentesFiltradasPorCedulaYMonto()
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

            Asistente asistente1 = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123-9" };
            Asistente asistente2 = new Asistente() { Nombre = "Roberto", Apellido = "Rama", Cedula = "4.111.333-2" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket1, 8) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente1);
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra2, asistente2);

            List<Compra> compras;
            compras = _logicaProductorAccesoDatos.ObtenerCompras();
            compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasMonto(compras, 12500);
            compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasCedula(compras, "4.444.444-4");
        }

        [TestMethod]
        public void ObtenerComprasFiltradasPorFecha()
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

            Asistente asistente1 = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123-9" };
            Asistente asistente2 = new Asistente() { Nombre = "Roberto", Apellido = "Rama", Cedula = "4.111.333-2" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket1, 8) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente1, new DateTime(2023, 4, 4, 21, 0, 0));
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra2, asistente2, new DateTime(2023, 4, 5, 19, 0, 0));

            List<Compra> compras;
            compras = _logicaProductorAccesoDatos.ObtenerCompras();
            compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasFecha(compras, new DateTime(2023, 4, 3, 21, 0, 0), new DateTime(2023, 4, 5, 18, 0, 0));

            Assert.AreEqual(compras[0].Asistente.Nombre, asistente1.Nombre);
            Assert.AreEqual(compras[0].Monto, 2500 * 5);
        }

        [ExpectedException(typeof(NoHayComprasRegistradas))]
        [TestMethod]
        public void ObtenerComprasInexistentesFiltradasPorFecha()
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

            Asistente asistente1 = new Asistente() { Nombre = "Juan", Apellido = "Pérez", Cedula = "4.123.123-9" };
            Asistente asistente2 = new Asistente() { Nombre = "Roberto", Apellido = "Rama", Cedula = "4.111.333-2" };

            List<(Ticket, int)> compra1 = new List<(Ticket, int)>() { (ticket1, 5) };
            List<(Ticket, int)> compra2 = new List<(Ticket, int)>() { (ticket1, 8) };

            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra1, asistente1, new DateTime(2023, 4, 4, 21, 0, 0));
            _logicaAsistenteAccesoDatos.ComprarYRegistrar(evento1, funcion1, compra2, asistente2, new DateTime(2023, 4, 5, 19, 0, 0));

            List<Compra> compras;
            compras = _logicaProductorAccesoDatos.ObtenerCompras();
            compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasFecha(compras, new DateTime(2023, 4, 5, 20, 0, 0), new DateTime(2023, 4, 5, 22, 0, 0));
        }

        [TestMethod]
        public void AgregarCupon()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);


            CuponPorcentaje unCupon = new CuponPorcentaje()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                Porcentaje = 1
            };

            _logicaProductorAccesoDatos.AgregarCupon(unCupon);

            Cupon cuponObtenido = _logicaProductorAccesoDatos.ObtenerCupon("ASFG22N9KO");

            Assert.AreEqual(cuponObtenido.Tipo, TipoDescuento.Porcentaje);
            Assert.AreEqual(cuponObtenido.Nombre, "Promocion de invierno");
            Assert.AreEqual(cuponObtenido.Codigo, "ASFG22N9KO");
            Assert.AreEqual(cuponObtenido.CantidadRestante, 30);
        }

        [ExpectedException(typeof(CodigoReservadoException))]
        [TestMethod]
        public void AgregarCuponConCodigoResrvado()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);


            CuponPorcentaje unCupon = new CuponPorcentaje()
            {
                Nombre = "Promocion de invierno",
                Codigo = "0000000000",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                Porcentaje = 1
            };

            _logicaProductorAccesoDatos.AgregarCupon(unCupon);



        }


        [ExpectedException(typeof(PorcentajeFueraLimitesExcepetion))]
        [TestMethod]
        public void AgregarCuponPorcentaje0()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            CuponPorcentaje unCupon = new CuponPorcentaje()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                Porcentaje = 0
            };

            _logicaProductorAccesoDatos.AgregarCupon(unCupon);

            Cupon cuponObtenido = _repositorioProductor.ObtenerCupon("ASFG22N9KO");
        }

        [TestMethod]
        public void AgregarCuponACantidad()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            CuponACantidad unCupon = new CuponACantidad()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                PrimerValor = 2,
                SegundoValor = 1
            };

            _logicaProductorAccesoDatos.AgregarCupon(unCupon);

            Cupon cuponObtenido = _repositorioProductor.ObtenerCupon("ASFG22N9KO");

            Assert.AreEqual(cuponObtenido.Tipo, TipoDescuento.Porcentaje);
            Assert.AreEqual(cuponObtenido.Nombre, "Promocion de invierno");
            Assert.AreEqual(cuponObtenido.Codigo, "ASFG22N9KO");
            Assert.AreEqual(cuponObtenido.CantidadRestante, 30);
        }

        [ExpectedException(typeof(CuponACantidadSegundoMenorPrimero))]
        [TestMethod]
        public void AgregarCuponACantidadSegundoMayorPrimero()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            CuponACantidad unCupon = new CuponACantidad()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                PrimerValor = 3,
                SegundoValor = 4
            };

            _logicaProductorAccesoDatos.AgregarCupon(unCupon);
        }

        [ExpectedException(typeof(CuponACantidadNegativa))]
        [TestMethod]
        public void AgregarCuponACantidadPrimeroCero()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            CuponACantidad unCupon = new CuponACantidad()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                PrimerValor = 0,
                SegundoValor = 2
            };

            _logicaProductorAccesoDatos.AgregarCupon(unCupon);
        }

        [TestMethod]
        public void AgregarCuponValorFijo()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            CuponValorFijo unCupon = new CuponValorFijo()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                ValorFijo = 100
            };

            _logicaProductorAccesoDatos.AgregarCupon(unCupon);

            CuponValorFijo cuponObtenido = (CuponValorFijo)_repositorioProductor.ObtenerCupon("ASFG22N9KO");

            Assert.AreEqual(cuponObtenido.Tipo, TipoDescuento.Porcentaje);
            Assert.AreEqual(cuponObtenido.Nombre, "Promocion de invierno");
            Assert.AreEqual(cuponObtenido.Codigo, "ASFG22N9KO");
            Assert.AreEqual(cuponObtenido.CantidadRestante, 30);
            Assert.AreEqual(cuponObtenido.ValorFijo, 100);
        }


        [ExpectedException(typeof(CuponValorFijoCero))]
        [TestMethod]
        public void AgregarCuponValorFijoValor0()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            CuponValorFijo unCupon = new CuponValorFijo()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                ValorFijo = 0
            };

            _logicaProductorAccesoDatos.AgregarCupon(unCupon);
        }

        [TestMethod]
        public void AgregarAsistenteEventoTest()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            Ticket ticket2 = new Ticket()
            {
                Nombre = "Platea Olímpica",
                Precio = 3500,
                Cantidad = 5000,
            };

            List<Ticket> listaTickets = new List<Ticket>();
            listaTickets.Add(ticket1);
            listaTickets.Add(ticket2);

            Funcion funcion1 = new Funcion(new DateTime(2022, 5, 3, 12, 0, 0),
                                  new DateTime(2022, 5, 3, 14, 0, 0),
                                  listaTickets);
            Funcion funcion2 = new Funcion(new DateTime(2022, 5, 4, 12, 0, 0),
                                  new DateTime(2022, 5, 4, 14, 0, 0),
                                  listaTickets);

            List<Funcion> listaFunciones = new List<Funcion>();
            listaFunciones.Add(funcion1);
            listaFunciones.Add(funcion2);

            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial,
                Funciones = listaFunciones,
                Tickets = listaTickets,
                Direccion = "Estadio Centenario",
                Imagen = "path"
            };
            Asistente unAsistente = new Asistente
            {
                Nombre = "asdf",
                Apellido = "Irabedra",
                Cedula = "5.209.134-2"
            };

            _logicaProductorAccesoDatos.AgregarAsistenteEvento(unAsistente, evento);
            Assert.IsTrue(_repositorioProductor.ControlarAsistenteEvento(unAsistente, evento));

        }

        [TestMethod]
        public void CambiarNombreCuponTest()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            CuponValorFijo unCupon = new CuponValorFijo()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                ValorFijo = 100
            };
            _logicaProductorAccesoDatos.AgregarCupon(unCupon);
            _logicaProductorAccesoDatos.CambiarNombreCupon(unCupon, "otro nombre");
            Cupon cuponObtenido =_logicaProductorAccesoDatos.ObtenerCupon("ASFG22N9KO");
            Assert.AreEqual(cuponObtenido.Nombre, "otro nombre");
        }

        [TestMethod]
        public void CambiarCantidadCuponTest()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            CuponValorFijo unCupon = new CuponValorFijo()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                ValorFijo = 100
            };
            _logicaProductorAccesoDatos.AgregarCupon(unCupon);
            _logicaProductorAccesoDatos.CambiarCantidadRestante(unCupon, 1);
            Cupon cuponCambiado = _logicaProductorAccesoDatos.ObtenerCupon("ASFG22N9KO");
            Assert.AreEqual(cuponCambiado.CantidadRestante, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(NoHayCuponesDisponibles))]
        public void ControlarCupon()
        {
            ILogicaProductor _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            CuponValorFijo unCupon = new CuponValorFijo()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 0,
                Tipo = TipoDescuento.Porcentaje,
                ValorFijo = 100
            };
            _logicaProductorAccesoDatos.ControlarCupon(unCupon);
 
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
            _repositorioProductor.VaciarTablaCupones();
            _repositorioProductor.VaciarTablaAsistentesCuponesEventos();
            _repositorioAsistente.VaciarTablaCompras();
            _repositorioAsistente.VaciarTablaAsistentes();
            _repositorioAsistente.VaciarTablaEntradasVendidas();
        }

    }

}
