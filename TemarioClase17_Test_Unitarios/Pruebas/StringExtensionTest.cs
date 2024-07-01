using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void ContarVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = "try pl";

            // Act
            int actual = StringExtension.ContarVocales(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoTieneDosVocales_DeberiaRetornarDos()
        {
            // Arrange
            int expected = 2;
            string text = "casa";

            // Act
            int actual = StringExtension.ContarVocales(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoElTextoEsNulo_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = null;

            // Act
            int actual = StringExtension.ContarVocales(text);

            Assert.AreEqual(expected, actual);
        }
    }
}
