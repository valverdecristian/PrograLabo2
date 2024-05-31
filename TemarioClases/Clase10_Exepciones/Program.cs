using EntidadesException;

namespace Clase10_Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception miExcepcion; // puedo asi acceder a sus metodos y propiedades

            // Propiedad InnerException: esta propiedad es de solo lectura

            // Propiedad StackTrace:
            // apila todas las llamadas a los metodos en orden LIFO
            // la ultima linea sera donde se origino el problema
            // seguimiento del error

            try
            {
                MetodosBasicos.Metodo1(); // esto al llegar al metodo 3 rompe!
            }
            catch (Exception e) // CATCH GENERAL [a lo ultimo]
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("********************************");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("********************************");
                Console.WriteLine(e.InnerException);
                Console.WriteLine("********************************");
            }
        }
    }

    /* Es importante el manejo de excepciones para que el programa no se cierre.
     * 
     * Todas las excepciones derivan de la clase Exception
     */
}