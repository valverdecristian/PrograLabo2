using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDeportiva
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        string nombre;
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre):this()
        {
            this.nombre = nombre;
            cantidadJugadores = cantidad;
        }
        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            if (!equipo.jugadores.Contains(jugador) && equipo.jugadores.Count < equipo.cantidadJugadores)
            {
                equipo.jugadores.Add(jugador);
                return true; // Se agregó el jugador al equipo
            }
            return false;
        }

        public string MostrarJugadores()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var jugador in jugadores)
            {
                sb.AppendLine(jugador.Nombre);
            }

            return sb.ToString();
        }
    }
}
