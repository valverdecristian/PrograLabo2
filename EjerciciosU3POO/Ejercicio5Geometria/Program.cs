using Geometria;

namespace Ejercicio5Geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto v1 = new Punto(0, 0);
            Punto v3 = new Punto(4, 3);

            Rectangulo rectangulo = new Rectangulo(v1, v3);

            Console.WriteLine($"Área del rectángulo: {rectangulo.GetArea()}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.GetPerimetro()}");

            Sumador sumador = new Sumador();
            Console.WriteLine(sumador.Sumar(2, "2"));
        }
    }
}