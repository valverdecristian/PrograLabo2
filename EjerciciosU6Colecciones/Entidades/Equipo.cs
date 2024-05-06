using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        short cantidadDeJugadores;
        List<Jugador> jugadores;
        string nombre;

        private Equipo() 
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre): this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                if (e.jugadores.Contains(j))
                {
                    return false;
                }

                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
    }
}

/*
 * public static bool operator +(Equipo e, Jugador j)
        {
            if(jugadores.Count < e.cantidadDeJugadores)
            {
                foreach(Jugador item in e.cantidadDeJugadores)
                {
                    if(item == j) return false;
                }
                e.jugadores.Add(j);
                return true;
            }
            return false;
            
        }
 * 
 */