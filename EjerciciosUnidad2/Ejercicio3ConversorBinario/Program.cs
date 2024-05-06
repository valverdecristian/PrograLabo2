using Funciones;

namespace Ejercicio3ConversorBinario
{
    internal class Program
    {
        static void Main()
        {
            int numeroDecimal = 10;
            string binario = Conversor.ConvertirDecimalABinario(numeroDecimal);
            Console.WriteLine($"El número decimal {numeroDecimal} en binario es: {binario}");

            string numeroBinario = "1010";
            int decimalResult = Conversor.ConvertirBinarioADecimal(numeroBinario);
            Console.WriteLine($"El número binario {numeroBinario} en decimal es: {decimalResult}");
        }
    }
}