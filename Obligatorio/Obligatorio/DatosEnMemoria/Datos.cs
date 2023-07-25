using Dominio;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatosEnMemoria
{
    public class Datos
    {
        public Productor ProductorIniciado { get; set; }

        public Datos()
        {
            ProductorIniciado = null;
        }

        public void IniciarSesion(Productor productor)
        {
            ProductorIniciado = productor;
        }
    }
}