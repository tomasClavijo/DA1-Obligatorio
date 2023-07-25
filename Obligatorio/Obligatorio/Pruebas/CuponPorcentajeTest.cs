using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Excepciones;

namespace PruebasObligatorio
{
    [TestClass]
    public class CuponPorcentajeTest
    {
        [TestMethod]
        public void CuponCorrecto()
        {
            CuponPorcentaje unCupon = new CuponPorcentaje()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                Porcentaje = 1
            };
            Assert.AreEqual(unCupon.Tipo, TipoDescuento.Porcentaje);
            Assert.AreEqual(unCupon.Nombre, "Promocion de invierno");
            Assert.AreEqual(unCupon.Codigo, "ASFG22N9KO");
            Assert.AreEqual(unCupon.CantidadRestante, 30);
            Assert.AreEqual(unCupon.Porcentaje, 1);
        }


        [TestMethod]
        [ExpectedException(typeof(NombreCuponException))]

        public void CuponSinNombre()
        {
            CuponPorcentaje unCupon = new CuponPorcentaje()
            {
                Nombre = "",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                Porcentaje = 1
            };
        }

        [TestMethod]
        [ExpectedException(typeof(LargoCodigoCuponException))]

        public void CuponConCodigoDeLargoMenor()
        {
            CuponPorcentaje unCupon = new CuponPorcentaje()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9K",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                Porcentaje=8
            };
        }

        [TestMethod]
        [ExpectedException(typeof(LargoCodigoCuponException))]

        public void CuponConCodigoDeLargoMayor()
        {
            CuponPorcentaje unCupon = new CuponPorcentaje()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO0",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                Porcentaje = 1
            };
        }


        [TestMethod]
        public void CalcularDescuentoTest()
        {
            CuponPorcentaje unCupon = new CuponPorcentaje()
            {
                Nombre = "Promocion de invierno",
                Codigo = "ASFG22N9KO",
                CantidadRestante = 30,
                Tipo = TipoDescuento.Porcentaje,
                Porcentaje = 1
            };
            int resultado = unCupon.CalcularDescuento(100, 1);
            Assert.AreEqual(resultado, 99);
        }
    }
}
