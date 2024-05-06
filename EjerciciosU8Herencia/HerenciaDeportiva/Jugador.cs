using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDeportiva
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados
        {
            get { return partidosJugados; }
            set { partidosJugados = value; }
        }

        public int TotalGoles
        {
            get { return totalGoles; }
            set { totalGoles = value; }
        }

        public Jugador(int dni, string nombre) : base(dni, nombre) {}

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Partidos jugados: {PartidosJugados}");
            sb.AppendLine($"Goles convertidos: {TotalGoles}");
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }

}
