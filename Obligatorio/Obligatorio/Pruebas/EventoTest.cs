using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System;
using Excepciones;
using System.Collections.Generic;

namespace PruebasObligatorio
{
    [TestClass]
    public class EventoTest
    {

        [TestMethod]
        public void EventoConNombreCorrecto()
        {
            Evento unEvento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Otros
            };
            Assert.AreEqual("Guns N Roses en Montevideo - Estadio Centenario", unEvento.Nombre);
        }

        [TestMethod]
        [ExpectedException(typeof(NombreEventoException))]
        public void EventoNombreVacio()
        {
            Evento unEvento = new Evento()
            {
                Nombre = "",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Otros
            };
        }

        [TestMethod]
        public void EventoConCategoriaCorrecta()
        {
            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música
            };
            Assert.AreEqual(Categoria.Música, evento.Categoria);
        }

        [TestMethod]
        [ExpectedException(typeof(DescripcionVaciaEventoException))]
        public void EventoSinDescripcion()
        {
            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "",
                Categoria = Categoria.Música
            };
        }

        [TestMethod]
        public void EventoConDescripcionCorrecta()
        {
            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música
            };
            Assert.AreEqual("¡Guns N Roses vuelve a Montevideo pero con su formación original!", evento.Descripcion);
        }
        [TestMethod]
        [ExpectedException(typeof(DireccionVaciaEventoException))]
        public void EventoDireccionVacia()
        {
            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Direccion = ""
            };
        }

        [TestMethod]
        public void EventoConDireccionCorrecta()
        {
            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Online,
                Direccion = "https://zoom.us/"
            };
            Assert.AreEqual("https://zoom.us/", evento.Direccion);
        }

        [TestMethod]
        public void EventoConImagenCorrecta()
        {
            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Online,
                Imagen = "/imagenes/imagen1.jpg"
            };
            Assert.AreEqual("/imagenes/imagen1.jpg", evento.Imagen);
        }

        [TestMethod]
        [ExpectedException(typeof(ImagenVaciaException))]
        public void EventoSinImagen()
        {
            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Online,
                Imagen = ""
            };
        }

        [TestMethod]
        [ExpectedException(typeof(DescripcionMayorAlLimiteException))]
        public void EventoDescripcionMayorAlLimite()
        {
            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "Luego del impacto socio-económico producido por la pandemia en nuestro país afortunadamente muchos sectores e industrias han comenzado a reactivarse.Uno de ellos es el sector del entretenimiento, particularmente en el área de los espectáculos públicos, que han vuelto a adquirir relevancia dada la creciente oferta de los mismos. Bajo este contexto usted ha sido contratado para construir un sistema que facilite la gestión de espectáculos y eventos, orientada a facilitar la experiencia de sus usuarios(los asistentes a los mismos).Dicha experiencia abarca todo el ciclo de vida: desde que los eventos son publicados, pasando por la búsqueda de los mismos y finalmente terminando en la adquisición de entradas. A continuación se comenzará a describir el funcionamiento básico de la aplicación, que constituirá una prueba de concepto para analizar la viabilidad del producto.Luego, en una segunda etapa, luego de haber mitigado los principales riesgos del mismo, se apuntará a iterar y evolucionarlo.",
                Categoria = Categoria.Música
            };
        }


        [TestMethod]
        public void EventoConFunciones()
        {
            Ticket ticket1 = new Ticket()
            {
                Nombre = "Tribuna Olímpica",
                Precio = 2500,
                Cantidad = 20000,
            };

            List<Ticket> listaTickets = new List<Ticket>();
            listaTickets.Add(ticket1);

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
                Funciones = listaFunciones,
            };
            Assert.AreEqual(funcion1, evento.Funciones[0]);
            Assert.AreEqual(funcion2, evento.Funciones[1]);
        }



        [TestMethod]
        public void EventoConTickets()
        {
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

            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Tickets = listaTickets
            };
            Assert.AreEqual(ticket1, evento.Tickets[0]);
            Assert.AreEqual(ticket2, evento.Tickets[1]);
        }



        [TestMethod]
        public void EventoFormatoCorrecto()
        {
            Evento evento = new Evento()
            {
                Nombre = "Guns N Roses en Montevideo - Estadio Centenario",
                Descripcion = "¡Guns N Roses vuelve a Montevideo pero con su formación original!",
                Categoria = Categoria.Música,
                Formato = Formato.Presencial
            };
            Assert.AreEqual(Formato.Presencial, evento.Formato);
        }
    }


}

