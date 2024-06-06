using Biblioteca;

namespace I01Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador();


            long resultado1 = sumador.Sumar(10,28);
            string resultado2 = sumador2.Sumar("hola","mundo");

            int cantidadSumas1 = (int)sumador;
            int cantidadSumas2 = (int)sumador2;
            Console.WriteLine($"Cantidad de sumas en sumador1: {cantidadSumas1}");
            Console.WriteLine($"Cantidad de sumas en sumador2: {cantidadSumas2}");
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);

        }
    }
}