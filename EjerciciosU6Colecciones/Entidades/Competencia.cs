using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        short cantidadVueltas;
        short cantidadCompetidores;
        List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de competidores: {competidores}");
            sb.AppendLine($"Cantidad de vueltas: {cantidadVueltas}");
            sb.AppendLine($"Lista de competidores:");
            foreach (AutoF1 item in competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }

            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random random = new Random();

            if (c.competidores.Count < c.cantidadCompetidores)
            {
                if (c == a)
                {
                    return false;
                }

                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCantidadCombustible((short)random.Next(15, 100));

                c.competidores.Add(a);
                return true;

            }
            return false;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if(c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
            {
                if(item == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

}
}
