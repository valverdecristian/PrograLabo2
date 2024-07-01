using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine(i.FizzBuzz());
            }

            Console.WriteLine("--- CONTAR PALABRAS ---");

            string saludo = "Hola mundo";
            string saludo2 = "Hola mundo estoy aqui";

            // dos formas
            Console.WriteLine(saludo.ContarPalabras());
            Console.WriteLine(StringExtension.ContarPalabras(saludo2));


        }
    }
}