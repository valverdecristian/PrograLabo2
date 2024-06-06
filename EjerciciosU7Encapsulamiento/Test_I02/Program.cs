using Entidades;

namespace Test_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Libro I";
            libro[1] = "Libro II";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            libro[1] = "Libro III";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            Console.WriteLine("Fuera del rango");
            Console.WriteLine(libro[2]);
            Console.WriteLine(libro[3]);
        }
    }
}