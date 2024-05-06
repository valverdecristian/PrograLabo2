using BibliotecaDeClases;

namespace Ejercicio2Primaveras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Rodrigo", new DateTime(1999, 2, 14), 37371234);
            Persona persona2 = new Persona("Martin",  new DateTime(2010, 4, 14), 45451234);
            Persona persona3 = new Persona("Enzo",    new DateTime(2006, 8, 4),  43425412);

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());
        }
    }
}