using Entidades;

namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePorTres_DeberiaRetornarFizz(int numero)
        {
            // Arrange: preparacion de los datos
            string expected = "Fizz";

            // Act: invocacion al metodo que vamos a testear
            string actual = numero.FizzBuzz();

            // Assert: evaluacion de los resultados
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePorCinco_DeberiaRetornarBuzz()
        {
            // Arrange: preparacion de los datos
            string expected = "Buzz";
            int numero = 5;

            // Act: invocacion al metodo que vamos a testear
            string actual = numero.FizzBuzz();

            // Assert: evaluacion de los resultados
            Assert.AreEqual(expected, actual);
        }
    }
}