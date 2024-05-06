using System.Text;

namespace Entidades
{
    public class Jugador
    {
        int dni;
        string nombre;
        int partidosJugados;
        float promedioGoles;
        int totalGoles;

        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }

        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            if(totalGoles != 0)
            {
                return (float)partidosJugados / totalGoles;
            }

            return 0;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Partidos Jugados: {partidosJugados}");
            sb.AppendLine($"Total de goles: {totalGoles}");
            sb.AppendLine($"Promedio de goles: {GetPromedioGoles()}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if(j1.dni == j2.dni)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}