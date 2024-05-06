using Entidades;

namespace C01_EstadisticaDeportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(2, "Argentina");

            Jugador jugador1 = new Jugador(1010, "Leonel");
            Jugador jugador2 = new Jugador(2323, "Dibu");
            Jugador jugador3 = new Jugador(1919, "Enzo");
            Jugador jugador4 = new Jugador(2020, "Julian");

            if(equipo + jugador1)
            {
                Console.WriteLine(jugador1.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se agrego a: \n{jugador1.MostrarDatos()}");
            }
            if (equipo + jugador2)
            {
                Console.WriteLine(jugador2.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se agrego a: \n{jugador2.MostrarDatos()}");
            }
            if (equipo + jugador3)
            {
                Console.WriteLine(jugador3.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se agrego a: \n{jugador3.MostrarDatos()}");
            }
        }
    }
}