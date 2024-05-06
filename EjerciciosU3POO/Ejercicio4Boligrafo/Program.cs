using BibliotecaDeClases;
namespace Ejercicio4Boligrafo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
                Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);

                string dibujo;
                bool exito = boligrafoRojo.Pintar(20, out dibujo);
                if (exito)
                {
                    Console.WriteLine($"Se pintaron {dibujo.Length} asteriscos");
                    Console.WriteLine(boligrafoRojo.GetTinta());
                }
                else
                {
                    Console.WriteLine("No hay suficiente tinta para pintar.");
                }
            }
        }
    }
}