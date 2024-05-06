

using Biblioteca;

namespace I01ElViajarEsUnPlacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil(4,4, Colores.Negro, 20, 3);

            Console.WriteLine(auto.MostrarInfo());
        }
    }
}