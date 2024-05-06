using HerenciaDeportiva;

namespace EjercicioC01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador(38649, "Cristian", 12, 2);

            Console.WriteLine(jugador.MostrarDatos());


            Equipo equipo = new Equipo(5, "Argentina");


            List<Jugador> jugadores = new List<Jugador>();

            // Crear instancias de Jugador
            Jugador jugador1 = new Jugador(10, "Messi", 400, 900);
            Jugador jugador2 = new Jugador(23, "Martinez", 350, 0);
            Jugador jugador3 = new Jugador(11, "Di Maria", 349, 299);
            Jugador jugador4 = new Jugador(4, "Montiel", 200, 100);

            // Agregar los nuevos jugadores a la lista
            jugadores.Add(jugador1);
            jugadores.Add(jugador2);
            jugadores.Add(jugador3);
            jugadores.Add(jugador4);

            Console.WriteLine("Jugadores en la lista:");
            foreach (Jugador jugadorEnLista in jugadores)
            {
                Console.WriteLine(jugadorEnLista.MostrarDatos());
            }
        }
    }
}