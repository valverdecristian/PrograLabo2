using BibliotecaDeClases;
namespace Ejercicio3Estudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Alexi", "Aranda", "112");
            Estudiante estudiante2 = new Estudiante("Rodrigo", "Ruiz", "456");
            Estudiante estudiante3 = new Estudiante("Dian", "Yrigay", "789");

            estudiante1.SetNotaPrimerParcial(6);
            estudiante1.SetNotaSegundoParcial(9);

            estudiante2.SetNotaPrimerParcial(5);
            estudiante2.SetNotaSegundoParcial(6);

            estudiante3.SetNotaPrimerParcial(5);
            estudiante3.SetNotaSegundoParcial(3);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}