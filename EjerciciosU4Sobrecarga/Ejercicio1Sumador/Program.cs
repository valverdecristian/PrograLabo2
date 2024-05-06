using Biblioteca;

namespace I01Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador();


            sumador.Sumar(10,28);
            sumador2.Sumar("a","b");

            int cantidadSumas1 = (int)sumador;
            int cantidadSumas2 = (int)sumador2;
            Console.WriteLine($"Cantidad de sumas en sumador1: {cantidadSumas1}");
            Console.WriteLine($"Cantidad de sumas en sumador2: {cantidadSumas2}");

        }
    }
}