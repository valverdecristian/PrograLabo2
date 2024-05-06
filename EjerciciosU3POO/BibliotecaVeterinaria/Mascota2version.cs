using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVeterinaria
{
    public class Mascota2version
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private List<string> historialVacunacion;
        private int contadorVacunas;

        public Mascota2version(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            historialVacunacion = new List<string>();
            contadorVacunas = 0;
        }

        public void AgregarVacuna(string nombreVacuna)
        {
            if (contadorVacunas < 4)
            {
                historialVacunacion.Add(nombreVacuna);
                contadorVacunas++;
            }
            else
            {
                Console.WriteLine("No se puede agregar más vacunas. Historial completo.");
            }
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Especie: {especie}");
            sb.AppendLine($"Fecha de Nacimiento: {fechaNacimiento}");
            sb.AppendLine("Historial de Vacunación:");
            if(historialVacunacion is not null)
            {
                foreach (var vacuna in historialVacunacion)
                {
                    sb.AppendLine(vacuna);
                }
            }

            return sb.ToString();
        }
    }
}
