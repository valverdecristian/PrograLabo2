using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Estudiante
    {
        private string? apellido;
        private string? legajo;
        private string? nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random? random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return ((float)notaPrimerParcial + (float)notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }
            else
            {
                return -1;
            }    
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y Apellido: {nombre} {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nota del primer parcial: {notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            sb.AppendLine(CalcularNotaFinal() != -1 ? $"Nota final: {CalcularNotaFinal()}" : "Alumno desaprobado");

            return sb.ToString();
        }





    }
}
